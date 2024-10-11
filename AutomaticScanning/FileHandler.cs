using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AutomaticScanning
{
    internal static class FileHandler
    {
        public static string UserFolderPath = AppContext.BaseDirectory + @"User\";

        public static string UserScannerSettingsPath = UserFolderPath + "ScannerSettings.json";
        public static UserScannerSettings UserScannerSettings;

        public static string UserSaveSettingsPath = UserFolderPath + "SaveSettings.json";
        public static UserSaveSettings UserSaveSettings;

        public static void StartupProgram()
        {
            UserScannerSettings = new UserScannerSettings();
            ReadSaveSettingsJson();
        }

        public static void StartupProgramFirstTime()
        {
            UserScannerSettings = new UserScannerSettings();
            UserSaveSettings = new UserSaveSettings();
            WriteScannerSettingsJson();
            WriteSaveSettingsJson();
        }

        public static bool CheckJsonFileHasContent(string path)
        {
            if(!File.Exists(path)) 
                return false;
            string content = File.ReadAllText(path);
            return !string.IsNullOrEmpty(content);
        }
    }

    class UserScannerSettings
    {
        public string scanner {  get; set; } //what exactly this contains is known
        public int dpi { get; set; }

        public UserScannerSettings()
        {
            scanner = string.Empty;
            dpi = 300;
        }

        public void Read()
        {
            string json = File.ReadAllText(FileHandler.UserScannerSettingsPath);
            FileHandler.UserScannerSettings = JsonSerializer.Deserialize<UserScannerSettings>(json);
        }

        public void Write()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(this, options);

            if (!FileHandler.CheckJsonFileHasContent(FileHandler.UserScannerSettingsPath)) //before because the FielStream occupies the resourcces
            {
                scanner = string.Empty;
                dpi = 300;
            }

            using (FileStream fs = new FileStream(FileHandler.UserScannerSettingsPath, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(json);
                }
            }
        }
    }

    class UserSaveSettings
    {
        public bool aut_save {  get; set; }
        public bool make_parent_folder {  get; set; }
        public string path_save {  get; set; } //not the folder name
        public string file_extension { get; set; } //without .
        public bool override_file {  get; set; } //if the file names are the same. Otherwise (if bool == false) the file would be not saved

        public UserSaveSettings()
        {
            Write();
        }

        public void Read()
        {
            string json = File.ReadAllText(FileHandler.UserSaveSettingsPath);
            FileHandler.UserSaveSettings = JsonSerializer.Deserialize<UserSaveSettings>(json);
        }

        public void Write()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(this, options);

            if (!FileHandler.CheckJsonFileHasContent(FileHandler.UserSaveSettingsPath))
            {
                aut_save = true;
                make_parent_folder = true;
                path_save = string.Empty;
                file_extension = "pdf";
                override_file = true;
            }

            using (FileStream fs = new FileStream(FileHandler.UserSaveSettingsPath, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(json);
                }
            }
        }
    }
}
