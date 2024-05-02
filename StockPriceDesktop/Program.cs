using System;
using System.Windows.Forms;

namespace StockPriceDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.s
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainFormSPD());
        }
    }
}
