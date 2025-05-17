namespace TradingEconomicsViewer.Presentation
{
    partial class TradingEconomicsComparator
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIndicator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountry1 = new System.Windows.Forms.TextBox();
            this.txtCountry2 = new System.Windows.Forms.TextBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblLoading1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Country1:";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(15, 466);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(210, 35);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Indicator:";
            // 
            // cmbIndicator
            // 
            this.cmbIndicator.FormattingEnabled = true;
            this.cmbIndicator.Items.AddRange(new object[] {
            "GDP",
            "Inflation Rate",
            "Unemployment",
            "Interest Rate"});
            this.cmbIndicator.Location = new System.Drawing.Point(89, 423);
            this.cmbIndicator.Name = "cmbIndicator";
            this.cmbIndicator.Size = new System.Drawing.Size(136, 21);
            this.cmbIndicator.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "TRADING ECONOMICS DATA VIEWER  ";
            // 
            // txtCountry1
            // 
            this.txtCountry1.Location = new System.Drawing.Point(89, 318);
            this.txtCountry1.Name = "txtCountry1";
            this.txtCountry1.Size = new System.Drawing.Size(136, 20);
            this.txtCountry1.TabIndex = 14;
            // 
            // txtCountry2
            // 
            this.txtCountry2.Location = new System.Drawing.Point(89, 357);
            this.txtCountry2.Name = "txtCountry2";
            this.txtCountry2.Size = new System.Drawing.Size(136, 20);
            this.txtCountry2.TabIndex = 15;
            // 
            // listBoxResults
            // 
            this.listBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(358, 86);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(438, 164);
            this.listBoxResults.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(261, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 246);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Country2:";
            // 
            // btnFetchData
            // 
            this.btnFetchData.Location = new System.Drawing.Point(73, 155);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(201, 44);
            this.btnFetchData.TabIndex = 21;
            this.btnFetchData.Text = "Fetch data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-7, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 14);
            this.panel2.TabIndex = 22;
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Items.AddRange(new object[] {
            "New Zealand",
            "Thailand",
            "Mexico",
            "Mexico",
            "Japan",
            "Germany",
            "UK",
            "Nigeria"});
            this.cmbCountries.Location = new System.Drawing.Point(106, 86);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(191, 21);
            this.cmbCountries.TabIndex = 23;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(85, 527);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(62, 20);
            this.lblLoading.TabIndex = 24;
            this.lblLoading.Text = "Status";
            // 
            // lblLoading1
            // 
            this.lblLoading1.AutoSize = true;
            this.lblLoading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading1.Location = new System.Drawing.Point(102, 225);
            this.lblLoading1.Name = "lblLoading1";
            this.lblLoading1.Size = new System.Drawing.Size(62, 20);
            this.lblLoading1.TabIndex = 25;
            this.lblLoading1.Text = "Status";
            // 
            // TradingEconomicsComparator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 576);
            this.Controls.Add(this.lblLoading1);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.txtCountry2);
            this.Controls.Add(this.txtCountry1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIndicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Name = "TradingEconomicsComparator";
            this.Text = "TradingEconomicsComparator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIndicator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountry1;
        private System.Windows.Forms.TextBox txtCountry2;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblLoading1;
    }
}