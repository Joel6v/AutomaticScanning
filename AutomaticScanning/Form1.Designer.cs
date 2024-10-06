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
            BtnScannerSettings = new Button();
            BtnSaveSettings = new Button();
            PbxPreview = new PictureBox();
            BtnSave = new Button();
            BtnScan = new Button();
            BtnImgBack = new Button();
            BtnImgNext = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxPreview).BeginInit();
            SuspendLayout();
            // 
            // BtnScannerSettings
            // 
            BtnScannerSettings.BackColor = Color.Gray;
            BtnScannerSettings.Font = new Font("Segoe UI", 12F);
            BtnScannerSettings.Location = new Point(12, 12);
            BtnScannerSettings.Name = "BtnScannerSettings";
            BtnScannerSettings.Size = new Size(172, 33);
            BtnScannerSettings.TabIndex = 0;
            BtnScannerSettings.Text = "Scanner Einstellungen";
            BtnScannerSettings.UseVisualStyleBackColor = false;
            // 
            // BtnSaveSettings
            // 
            BtnSaveSettings.BackColor = Color.Gray;
            BtnSaveSettings.Font = new Font("Segoe UI", 12F);
            BtnSaveSettings.Location = new Point(277, 12);
            BtnSaveSettings.Name = "BtnSaveSettings";
            BtnSaveSettings.Size = new Size(185, 33);
            BtnSaveSettings.TabIndex = 1;
            BtnSaveSettings.Text = "Speichern Einstellungen";
            BtnSaveSettings.UseVisualStyleBackColor = false;
            // 
            // PbxPreview
            // 
            PbxPreview.BackColor = Color.FromArgb(224, 224, 224);
            PbxPreview.Location = new Point(12, 60);
            PbxPreview.Name = "PbxPreview";
            PbxPreview.Size = new Size(450, 533);
            PbxPreview.TabIndex = 2;
            PbxPreview.TabStop = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.Gray;
            BtnSave.Font = new Font("Segoe UI", 12F);
            BtnSave.Location = new Point(357, 603);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(105, 33);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "Speichern";
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnScan
            // 
            BtnScan.BackColor = Color.Gray;
            BtnScan.Font = new Font("Segoe UI", 12F);
            BtnScan.Location = new Point(12, 603);
            BtnScan.Name = "BtnScan";
            BtnScan.Size = new Size(105, 33);
            BtnScan.TabIndex = 2;
            BtnScan.Text = "Scannen";
            BtnScan.UseVisualStyleBackColor = false;
            // 
            // BtnImgBack
            // 
            BtnImgBack.Location = new Point(217, 599);
            BtnImgBack.Name = "BtnImgBack";
            BtnImgBack.Size = new Size(25, 25);
            BtnImgBack.TabIndex = 3;
            BtnImgBack.Text = "<";
            BtnImgBack.UseVisualStyleBackColor = true;
            // 
            // BtnImgNext
            // 
            BtnImgNext.Location = new Point(248, 599);
            BtnImgNext.Name = "BtnImgNext";
            BtnImgNext.Size = new Size(25, 25);
            BtnImgNext.TabIndex = 4;
            BtnImgNext.Text = ">";
            BtnImgNext.UseVisualStyleBackColor = true;
            // 
            // FrmAutomaticScanning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 648);
            Controls.Add(BtnImgNext);
            Controls.Add(BtnImgBack);
            Controls.Add(BtnScan);
            Controls.Add(BtnSave);
            Controls.Add(PbxPreview);
            Controls.Add(BtnSaveSettings);
            Controls.Add(BtnScannerSettings);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmAutomaticScanning";
            Text = "Automatisches Scannen";
            ((System.ComponentModel.ISupportInitialize)PbxPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnScannerSettings;
        private Button BtnSaveSettings;
        private PictureBox PbxPreview;
        private Button BtnSave;
        private Button BtnScan;
        private Button BtnImgBack;
        private Button BtnImgNext;
    }
}
