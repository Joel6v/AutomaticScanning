using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticScanning
{
    internal class FileHandler
    {
        public static string UserFolderPath = AppContext.BaseDirectory + @"User\";

        public static string UserScannerSettingsPath = UserFolderPath + "ScannerSettings.json";
        public static UserScannerSettings UserScannerSettings;

        public static string UserSaveSettingsPath = UserFolderPath + "SaveSettings.json";
        public static UserSaveSettings UserSaveSettings;

        public static void StartupProgram()
        {
            UserScannerSettings = ReadScannerSettingsJson();
            UserSaveSettings = ReadSaveSettingsJson();
        }

        public static void StartupProgramFirstTime()
        {

        }

        public static UserScannerSettings ReadScannerSettingsJson()
        {

        }

        public static void WriteScannerSettingsJson()
        {

        }

        public static UserSaveSettings ReadSaveSettingsJson()
        {

        }

        public static void WriteSaveSettingsJson()
        {

        }
    }

    class UserScannerSettings
    {
        public string scanner {  get; set; } //what exactly this contains is known
        public int dpi { get; set; }

    }

    class UserSaveSettings
    {
        public bool aut_save {  get; set; }
        public bool make_parent_folder {  get; set; }
        public string path_save {  get; set; } //not the folder name
        public string file_extension { get; set; } //without .
        public bool override_file {  get; set; } //if the file names are the same. Otherwise the file would be not saved
    }
}
