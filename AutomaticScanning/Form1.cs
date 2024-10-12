using WIA;

namespace AutomaticScanning
{
    public partial class FrmAutomaticScanning : Form
    {
        public FrmAutomaticScanning()
        {
            InitializeComponent();
        }

        private void FrmAutomaticScanning_Load(object sender, EventArgs e)
        {
            FileHandler.StartupProgram();

            LoadScannerCbx();

            string[] dpiToSet = { "300", "450", "600", "900", "1200" };
            CbxResolution.Items.AddRange(dpiToSet);
            CbxResolution.SelectedItem = FileHandler.UserScannerSettings.dpi.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadScannerCbx();
        }

        private void LoadScannerCbx()
        {
            Scanner scanner = new Scanner();
            if (scanner.ScannersList.Count > 0)
            {
                List<string> scannerNames = new List<string>();
                for (int i = 0; i < scanner.ScannersList.Count; i++)
                {
                    scannerNames.Add(scanner.ScannersList[i].Properties["Name"].get_Value());
                    if (scanner.ScannersList[i].Properties["Name"].get_Value() == FileHandler.UserScannerSettings.scanner)
                    {
                        CbxScanner.SelectedItem = FileHandler.UserScannerSettings.scanner;
                    }
                }
                CbxScanner.Items.AddRange(scannerNames.ToArray());

                LbNoScanners.Text = "";
                CbxScanner.Enabled = true;
                BtnScan.Enabled = true;
            }
            else
            {
                LbNoScanners.Text = "Keine Scanner verfügbar";
                CbxScanner.Enabled = false;
                BtnScan.Enabled = false;
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
