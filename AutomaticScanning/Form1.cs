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

            Scanner scanner = new Scanner();
            List<string> scannerNames = new List<string>();
            for (int i = 0; i < scanner.ScannersList.Count; i++)
            {
                scannerNames.Add(scanner.ScannersList[i].Properties["Name"].get_Value());
            }
            CbxScanner.Items.AddRange(scannerNames.ToArray());
            CbxScanner.SelectedItem = FileHandler.UserScannerSettings.scanner;
        }
    }
}
