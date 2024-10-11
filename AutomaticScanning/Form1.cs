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
            if(!FileHandler.CheckJsonFileHasContent(FileHandler.UserScannerSettingsPath)){
                FileHandler.StartupProgramFirstTime();
            }
            else{
                FileHandler.StartupProgram();
            }
        }
    }
}
