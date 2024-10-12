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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutomaticScanning));
            BtnScan = new Button();
            BtnSettings = new Button();
            panel1 = new Panel();
            BtnUpdate = new Button();
            LbNoScanners = new Label();
            CbxResolution = new ComboBox();
            LbResolution = new Label();
            CbxScanner = new ComboBox();
            LbScanner = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnScan
            // 
            resources.ApplyResources(BtnScan, "BtnScan");
            BtnScan.BackColor = Color.Gray;
            BtnScan.Name = "BtnScan";
            BtnScan.UseVisualStyleBackColor = false;
            BtnScan.Click += BtnScan_Click;
            // 
            // BtnSettings
            // 
            resources.ApplyResources(BtnSettings, "BtnSettings");
            BtnSettings.Name = "BtnSettings";
            BtnSettings.UseVisualStyleBackColor = true;
            BtnSettings.Click += BtnSettings_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(BtnUpdate);
            panel1.Controls.Add(LbNoScanners);
            panel1.Controls.Add(CbxResolution);
            panel1.Controls.Add(LbResolution);
            panel1.Controls.Add(CbxScanner);
            panel1.Controls.Add(LbScanner);
            panel1.Name = "panel1";
            // 
            // BtnUpdate
            // 
            resources.ApplyResources(BtnUpdate, "BtnUpdate");
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // LbNoScanners
            // 
            resources.ApplyResources(LbNoScanners, "LbNoScanners");
            LbNoScanners.Name = "LbNoScanners";
            // 
            // CbxResolution
            // 
            resources.ApplyResources(CbxResolution, "CbxResolution");
            CbxResolution.FormattingEnabled = true;
            CbxResolution.Name = "CbxResolution";
            // 
            // LbResolution
            // 
            resources.ApplyResources(LbResolution, "LbResolution");
            LbResolution.Name = "LbResolution";
            // 
            // CbxScanner
            // 
            resources.ApplyResources(CbxScanner, "CbxScanner");
            CbxScanner.FormattingEnabled = true;
            CbxScanner.Name = "CbxScanner";
            // 
            // LbScanner
            // 
            resources.ApplyResources(LbScanner, "LbScanner");
            LbScanner.Name = "LbScanner";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // FrmAutomaticScanning
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(BtnSettings);
            Controls.Add(BtnScan);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAutomaticScanning";
            Load += FrmAutomaticScanning_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
    }
}
