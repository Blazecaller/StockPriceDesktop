using AngleSharp; // issue this cmd: NuGet\Install-Package AngleSharp -Version 1.1.2
using AngleSharp.Html.Parser;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPriceDesktop
{
    public partial class mainFormSPD : Form
    {
        bool isUrlValid = false;

        // async task static variables
        private static HttpClient client = new HttpClient();
        private static string htmlContent;
        private static HttpResponseMessage response;
        //private static AngleSharp.Dom.IDocument document;
        //private static IConfiguration config;
        //private static IBrowsingContext context;
        private static string stockPrice;
        private System.Threading.Timer timer;

        // etc
        private string url;
        //private string msg1;
        private int scanInterval = 600; // 600 seconds by default

        public mainFormSPD()
        {
            InitializeComponent();
        }

        public static async Task<string> CallUrl(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            client.DefaultRequestHeaders.Accept.Clear();
            response = await client.GetAsync(url);
            htmlContent = await response.Content.ReadAsStringAsync();

            // Create an AngleSharp configuration 
            //config = Configuration.Default.WithDefaultLoader();
            //context = BrowsingContext.New(config);
            //document = await context.OpenAsync(req => req.Content(htmlContent));
            // div class is YMlKec.fxKbKc (April 2024)
            //stockPrice = document.QuerySelector("div.YMlKec.fxKbKc")?.TextContent ?? "Unavaliable";
            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    var parser = new HtmlParser();

                    // Load only the necessary part of the page directly from the stream
                    var document = parser.ParseDocument(stream);

                    // Use CSS selector to directly target the element containing the stock price
                    var stockPriceElement = document.QuerySelector("div.YMlKec.fxKbKc");
                    stockPrice = stockPriceElement?.TextContent ?? "Unavailable";

                    return stockPrice;
                }
            }
            else
            {
                // Handle the case where the request was not successful
                return "Failed to fetch stock price";
            }
            // Ex: GUBRF:IST
        }
        //TODO: https://blog.elmah.io/csharp-how-to-convert-a-string-to-int/

        private async Task TrackEventHandlerAsync()
        {
            url = inputTextBox.Text;
            if ((String.IsNullOrWhiteSpace(url) == false) & isUrlValid == false)
            {
                isUrlValid = true;
                url = $"https://www.google.com/finance/quote/{url}";

                // Use a timer to periodically check for updates
                timer = new System.Threading.Timer(async _ =>
                {
                    try
                    {
                        string stockPrice = await CallUrl(url);

                        // Update the UI on the UI thread
                        stockPriceTextBox.Invoke((MethodInvoker)delegate {
                            stockPriceTextBox.Text = stockPrice;
                        });
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors
                        Console.WriteLine($"Error fetching stock price: {ex.Message}");
                    }
                }, null, TimeSpan.Zero, TimeSpan.FromSeconds(scanInterval)); // Check every 5 seconds

            }
            else if (isUrlValid == true)
            {
                MessageBox.Show("Deactivate the tracker first.");
            }
            else
            {
                MessageBox.Show("Please enter a valid stock name");
            }
        }

        private void trackButton_Click(object sender, EventArgs e)
        {
            _ = TrackEventHandlerAsync();
            stockAlertNotification.ShowBalloonTip(2000, "Stock price changed!", $"{"\ns"} {DateTime.Now:h:mm:ss tt}", ToolTipIcon.Warning);
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                _ = TrackEventHandlerAsync();
            }

            if (e.KeyChar == 27)
            {
                //Timer stops
                timer?.Change(Timeout.Infinite, Timeout.Infinite);
                isUrlValid = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            //Timer stops
            timer?.Change(Timeout.Infinite, Timeout.Infinite);
            isUrlValid = false;
        }

    }
}
