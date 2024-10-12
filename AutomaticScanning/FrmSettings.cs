using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticScanning
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void ChbxLastSettingsDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbxLastSettingsDefault.Checked)
            {
                BtnCurrentSettingsDefault.Enabled = false;
            }
            else
            {
                BtnCurrentSettingsDefault.Enabled = true;
            }
        }

        private bool CurrentSettingsDefault = false;

        private void BtnCurrentSettingsDefault_Click(object sender, EventArgs e)
        {
            ChbxLastSettingsDefault.Checked = false;
            if (CurrentSettingsDefault)
            {
                CurrentSettingsDefault = false;
                BtnCurrentSettingsDefault.Text = "Anwenden";
                ChbxLastSettingsDefault.Enabled = true;
            }
            else
            {
                CurrentSettingsDefault = true;
                BtnCurrentSettingsDefault.Text = "Rückgänig";
                ChbxLastSettingsDefault.Enabled = false;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            FileHandler.UserSaveSettingsCurrent.aut_save = ChbxLastSettingsDefault.Checked;
            if (CurrentSettingsDefault)
            {
                FileHandler.UserSaveSettingsStorage = FileHandler.UserSaveSettingsCurrent;
                FileHandler.UserSaveSettingsStorage.Write();
                FileHandler.UserScannerSettingsStorage = FileHandler.UserScannerSettingsCurrent;
                FileHandler.UserScannerSettingsStorage.Write();
            }

            this.Close();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            ChbxLastSettingsDefault.Checked = FileHandler.UserSaveSettingsCurrent.aut_save; //here the event "click" will be trigged
        }
    }
}
