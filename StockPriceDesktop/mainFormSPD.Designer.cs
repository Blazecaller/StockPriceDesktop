
namespace StockPriceDesktop
{
    partial class mainFormSPD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormSPD));
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.stockPriceLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.stockPriceTextBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.trackButton = new System.Windows.Forms.Button();
            this.stockAlertNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.AutoSize = true;
            this.stockNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockNameLabel.Location = new System.Drawing.Point(3, 109);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(117, 24);
            this.stockNameLabel.TabIndex = 0;
            this.stockNameLabel.Text = "Stock Name:";
            // 
            // stockPriceLabel
            // 
            this.stockPriceLabel.AutoSize = true;
            this.stockPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockPriceLabel.Location = new System.Drawing.Point(62, 154);
            this.stockPriceLabel.Name = "stockPriceLabel";
            this.stockPriceLabel.Size = new System.Drawing.Size(58, 24);
            this.stockPriceLabel.TabIndex = 1;
            this.stockPriceLabel.Text = "Price:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputTextBox.Location = new System.Drawing.Point(126, 112);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(162, 29);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // stockPriceTextBox
            // 
            this.stockPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockPriceTextBox.Location = new System.Drawing.Point(126, 149);
            this.stockPriceTextBox.Name = "stockPriceTextBox";
            this.stockPriceTextBox.Size = new System.Drawing.Size(162, 29);
            this.stockPriceTextBox.TabIndex = 3;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopButton.Location = new System.Drawing.Point(294, 149);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(64, 29);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // trackButton
            // 
            this.trackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trackButton.Location = new System.Drawing.Point(294, 114);
            this.trackButton.Name = "trackButton";
            this.trackButton.Size = new System.Drawing.Size(64, 29);
            this.trackButton.TabIndex = 6;
            this.trackButton.Text = "Track";
            this.trackButton.UseVisualStyleBackColor = true;
            this.trackButton.Click += new System.EventHandler(this.trackButton_Click);
            // 
            // stockAlertNotification
            // 
            this.stockAlertNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.stockAlertNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("stockAlertNotification.Icon")));
            this.stockAlertNotification.Text = "notification";
            this.stockAlertNotification.Visible = true;
            // 
            // mainFormSPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 290);
            this.Controls.Add(this.trackButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.stockPriceTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.stockPriceLabel);
            this.Controls.Add(this.stockNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainFormSPD";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockNameLabel;
        private System.Windows.Forms.Label stockPriceLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox stockPriceTextBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button trackButton;
        private System.Windows.Forms.NotifyIcon stockAlertNotification;
    }
}

