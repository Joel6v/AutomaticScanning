namespace AutomaticScanning
{
    partial class FrmScanning
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
            PbxImages = new PictureBox();
            LblPages = new Label();
            BtnBack = new Button();
            BtnNext = new Button();
            BtnSavePreview = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxImages).BeginInit();
            SuspendLayout();
            // 
            // PbxImages
            // 
            PbxImages.Location = new Point(12, 12);
            PbxImages.Name = "PbxImages";
            PbxImages.Size = new Size(295, 417);
            PbxImages.TabIndex = 0;
            PbxImages.TabStop = false;
            // 
            // LblPages
            // 
            LblPages.AutoSize = true;
            LblPages.Location = new Point(12, 439);
            LblPages.Name = "LblPages";
            LblPages.Size = new Size(31, 15);
            LblPages.TabIndex = 1;
            LblPages.Text = "1 / n";
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(141, 435);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(23, 23);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "<";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(171, 435);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(23, 23);
            BtnNext.TabIndex = 3;
            BtnNext.Text = ">";
            BtnNext.UseVisualStyleBackColor = true;
            // 
            // BtnSavePreview
            // 
            BtnSavePreview.Font = new Font("Segoe UI", 12F);
            BtnSavePreview.Location = new Point(12, 483);
            BtnSavePreview.Name = "BtnSavePreview";
            BtnSavePreview.Size = new Size(295, 33);
            BtnSavePreview.TabIndex = 4;
            BtnSavePreview.Text = "Speichern Vorschau";
            BtnSavePreview.UseVisualStyleBackColor = true;
            // 
            // FrmScanning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 537);
            Controls.Add(BtnSavePreview);
            Controls.Add(BtnNext);
            Controls.Add(BtnBack);
            Controls.Add(LblPages);
            Controls.Add(PbxImages);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmScanning";
            Text = "Vorschau";
            ((System.ComponentModel.ISupportInitialize)PbxImages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbxImages;
        private Label LblPages;
        private Button BtnBack;
        private Button BtnNext;
        private Button BtnSavePreview;
    }
}