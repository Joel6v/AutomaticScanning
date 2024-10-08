using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace AutomaticScanning
{
    internal class Scanner
    {
        public List<WIA.DeviceInfo> ScannersList { get; private set; }

        public Scanner()
        {
            GetScanners();
        }

        private void GetScanners()
        {
            try
            {
                ScannersList = new List<WIA.DeviceInfo>();
                DeviceManager deviceManager = new DeviceManager();

                for(int i = 0; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType)
                    {
                        ScannersList.Add(deviceManager.DeviceInfos[i]);
                    }
                }
            }
            catch(COMException ex) 
            {
                throw ex;
            }
        }

        public Bitmap Scan(WIA.DeviceInfo selectedScanner, int res)
        {
            try
            {
                var device = selectedScanner.Connect();
                var scanerItem = device.Items[0];
                ImageFile imgFile = (ImageFile)scanerItem.Transfer(FormatID.wiaFormatBMP); //the other options must be added
                return Bitmap.FromFile(imgFile);
            }
            catch(COMException ex)
            {
                throw ex;
            }
        }
    }
}
