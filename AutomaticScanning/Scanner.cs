using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace AutomaticScanning
{
    public class Scanner
    {
        public List<WIA.DeviceInfo> ScannersList { get; private set; }       
        public int ScannerListCount { get; private set; } //for testing reasons
        public DeviceInfo SelectedScanner {  get; set; }

        public Scanner()
        {
            GetScanners();
            ScannerListCount = ScannersList.Count;
        }

        private void GetScanners()
        {            
            ScannersList = new List<WIA.DeviceInfo>();
            DeviceManager deviceManager = new DeviceManager();
            try
            {


                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) //unknown whether the index starts at 1
                {
                    if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType)
                    {
                        ScannersList.Add(deviceManager.DeviceInfos[i]);
                    }
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.ToString(), "Fehler", MessageBoxButtons.OK);
            }
        }

        public Bitmap Scan(int selectedScannerIndex)
        {
            try
            {
                var device = SelectedScanner.Connect();
                Item scanerItem = device.Items[0];

                Property propertyH = scanerItem.Properties.get_Item(6147); //Horizontal DPI
                propertyH.set_Value(FileHandler.UserScannerSettingsCurrent.dpi);

                Property propertyV = scanerItem.Properties.get_Item(6148); //Vertical DPI
                propertyV.set_Value(FileHandler.UserScannerSettingsCurrent.dpi);

                ImageFile imgFile = (ImageFile)scanerItem.Transfer("{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}"); //{B9...} stands for as Bitmap
                return ConvertImageFileToBitmap(imgFile);
            }
            catch (COMException ex)
            {
                throw ex;
            }
        }

        private Bitmap ConvertImageFileToBitmap(ImageFile imageFile)
        {
            byte[] imageBytes = (byte[])imageFile.FileData.get_BinaryData();

            using (MemoryStream stream = new MemoryStream(imageBytes))
            {
                Bitmap bitmap = new Bitmap(stream);
                return bitmap;
            }
        }
    }
}
