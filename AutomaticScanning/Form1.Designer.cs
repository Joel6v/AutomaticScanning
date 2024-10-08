namespace AutomaticScanning
{
    partial class FrmAutomaticScanning
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnScan = new Button();
            BtnSettings = new Button();
            panel1 = new Panel();
            LbScanner = new Label();
            this.CbxScannner = new ComboBox();
            this.LbRes = new Label();
            CbxRes = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnScan
            // 
            BtnScan.BackColor = Color.Gray;
            BtnScan.Font = new Font("Segoe UI", 12F);
            BtnScan.Location = new Point(12, 189);
            BtnScan.Name = "BtnScan";
            BtnScan.Size = new Size(207, 33);
            BtnScan.TabIndex = 5;
            BtnScan.Text = "Scannen";
            BtnScan.UseVisualStyleBackColor = false;
            // 
            // BtnSettings
            // 
            BtnSettings.Font = new Font("Segoe UI", 12F);
            BtnSettings.Location = new Point(103, 12);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(116, 33);
            BtnSettings.TabIndex = 0;
            BtnSettings.Text = "Einstellungen";
            BtnSettings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(CbxRes);
            panel1.Controls.Add(this.LbRes);
            panel1.Controls.Add(this.CbxScannner);
            panel1.Controls.Add(LbScanner);
            panel1.Location = new Point(12, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 132);
            panel1.TabIndex = 6;
            // 
            // LbScanner
            // 
            LbScanner.AutoSize = true;
            LbScanner.Font = new Font("Segoe UI", 12F);
            LbScanner.Location = new Point(12, 5);
            LbScanner.Name = "LbScanner";
            LbScanner.Size = new Size(66, 21);
            LbScanner.TabIndex = 1;
            LbScanner.Text = "Scanner";
            // 
            // CbxScannner
            // 
            this.CbxScannner.FormattingEnabled = true;
            this.CbxScannner.Location = new Point(12, 29);
            this.CbxScannner.Name = "CbxScannner";
            this.CbxScannner.Size = new Size(185, 23);
            this.CbxScannner.TabIndex = 2;
            // 
            // LbRes
            // 
            this.LbRes.AutoSize = true;
            this.LbRes.Font = new Font("Segoe UI", 12F);
            this.LbRes.Location = new Point(12, 74);
            this.LbRes.Name = "LbRes";
            this.LbRes.Size = new Size(81, 21);
            this.LbRes.TabIndex = 3;
            this.LbRes.Text = "Auflösung";
            // 
            // CbxRes
            // 
            CbxRes.FormattingEnabled = true;
            CbxRes.Location = new Point(12, 98);
            CbxRes.Name = "CbxRes";
            CbxRes.Size = new Size(185, 23);
            CbxRes.TabIndex = 4;
            // 
            // FrmAutomaticScanning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 235);
            Controls.Add(panel1);
            Controls.Add(BtnSettings);
            Controls.Add(BtnScan);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAutomaticScanning";
            Text = "Automatisches Scannen";
            Load += FrmAutomaticScanning_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnScan;
        private Button BtnImgBack;
        private Button BtnImgNext;
        private Button BtnSettings;
        private Panel panel1;
        private ComboBox CbxRes;
        private Label label2;
        private ComboBox comboBox1;
        private Label LbScanner;
    }
}
