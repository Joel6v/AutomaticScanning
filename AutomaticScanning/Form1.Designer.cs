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
            BtnUpdate = new Button();
            LbNoScanners = new Label();
            CbxResolution = new ComboBox();
            LbResolution = new Label();
            CbxScanner = new ComboBox();
            LbScanner = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnScan
            // 
            BtnScan.BackColor = Color.Gray;
            BtnScan.Font = new Font("Segoe UI", 12F);
            BtnScan.Location = new Point(12, 221);
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
            BtnSettings.Click += BtnSettings_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnUpdate);
            panel1.Controls.Add(LbNoScanners);
            panel1.Controls.Add(CbxResolution);
            panel1.Controls.Add(LbResolution);
            panel1.Controls.Add(CbxScanner);
            panel1.Controls.Add(LbScanner);
            panel1.Location = new Point(12, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 153);
            panel1.TabIndex = 6;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 9F);
            BtnUpdate.Location = new Point(157, 55);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(47, 23);
            BtnUpdate.TabIndex = 7;
            BtnUpdate.Text = "Laden";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // LbNoScanners
            // 
            LbNoScanners.AutoSize = true;
            LbNoScanners.Font = new Font("Segoe UI", 9F);
            LbNoScanners.Location = new Point(12, 59);
            LbNoScanners.Name = "LbNoScanners";
            LbNoScanners.Size = new Size(16, 15);
            LbNoScanners.TabIndex = 6;
            LbNoScanners.Text = "   ";
            // 
            // CbxResolution
            // 
            CbxResolution.FormattingEnabled = true;
            CbxResolution.Location = new Point(12, 119);
            CbxResolution.Name = "CbxResolution";
            CbxResolution.Size = new Size(192, 23);
            CbxResolution.TabIndex = 5;
            // 
            // LbResolution
            // 
            LbResolution.AutoSize = true;
            LbResolution.Font = new Font("Segoe UI", 12F);
            LbResolution.Location = new Point(12, 95);
            LbResolution.Name = "LbResolution";
            LbResolution.Size = new Size(119, 21);
            LbResolution.TabIndex = 4;
            LbResolution.Text = "Auflösung (DPI)";
            // 
            // CbxScanner
            // 
            CbxScanner.FormattingEnabled = true;
            CbxScanner.Location = new Point(12, 29);
            CbxScanner.Name = "CbxScanner";
            CbxScanner.Size = new Size(192, 23);
            CbxScanner.TabIndex = 2;
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
            // FrmAutomaticScanning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 266);
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
        private Label LbResolution;
        private ComboBox CbxResolution;
        private Label LbScanner;
        private ComboBox CbxScanner;
        private Label LbNoScanners;
        private Button BtnUpdate;
    }
}
