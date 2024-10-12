namespace AutomaticScanning
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            ChbxLastSettingsDefault = new CheckBox();
            BtnOk = new Button();
            BtnCurrentSettingsDefault = new Button();
            LbCurrentSettingsDefault = new Label();
            BtnCancle = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ChbxLastSettingsDefault
            // 
            resources.ApplyResources(ChbxLastSettingsDefault, "ChbxLastSettingsDefault");
            ChbxLastSettingsDefault.Name = "ChbxLastSettingsDefault";
            ChbxLastSettingsDefault.UseVisualStyleBackColor = true;
            ChbxLastSettingsDefault.CheckedChanged += ChbxLastSettingsDefault_CheckedChanged;
            // 
            // BtnOk
            // 
            resources.ApplyResources(BtnOk, "BtnOk");
            BtnOk.BackColor = Color.Gray;
            BtnOk.Name = "BtnOk";
            BtnOk.UseVisualStyleBackColor = false;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCurrentSettingsDefault
            // 
            resources.ApplyResources(BtnCurrentSettingsDefault, "BtnCurrentSettingsDefault");
            BtnCurrentSettingsDefault.Name = "BtnCurrentSettingsDefault";
            BtnCurrentSettingsDefault.UseVisualStyleBackColor = true;
            BtnCurrentSettingsDefault.Click += BtnCurrentSettingsDefault_Click;
            // 
            // LbCurrentSettingsDefault
            // 
            resources.ApplyResources(LbCurrentSettingsDefault, "LbCurrentSettingsDefault");
            LbCurrentSettingsDefault.Name = "LbCurrentSettingsDefault";
            // 
            // BtnCancle
            // 
            resources.ApplyResources(BtnCancle, "BtnCancle");
            BtnCancle.BackColor = Color.Gray;
            BtnCancle.Name = "BtnCancle";
            BtnCancle.UseVisualStyleBackColor = false;
            BtnCancle.Click += BtnCancle_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // FrmSettings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(BtnCancle);
            Controls.Add(LbCurrentSettingsDefault);
            Controls.Add(BtnCurrentSettingsDefault);
            Controls.Add(BtnOk);
            Controls.Add(ChbxLastSettingsDefault);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmSettings";
            Load += FrmSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ChbxLastSettingsDefault;
        private Button BtnOk;
        private Button BtnCurrentSettingsDefault;
        private Label LbCurrentSettingsDefault;
        private Button BtnCancle;
        private Label label1;
    }
}