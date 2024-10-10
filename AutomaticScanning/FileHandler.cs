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
    internal class FileHandler
    {
        public static string UserFolderPath = AppContext.BaseDirectory + @"User\";

        public static string UserScannerSettingsPath = UserFolderPath + "ScannerSettings.json";
        public static UserScannerSettings UserScannerSettings;

        public static string UserSaveSettingsPath = UserFolderPath + "SaveSettings.json";
        public static UserSaveSettings UserSaveSettings;

        public static void StartupProgram()
        {
            ReadScannerSettingsJson();
            ReadSaveSettingsJson();
        }

        public static void StartupProgramFirstTime()
        {

        }

        public static void ReadScannerSettingsJson()
        {
            string json = File.ReadAllText(UserScannerSettingsPath);
            UserScannerSettings = JsonSerializer.Deserialize<UserScannerSettings>(json);
        }

        public static void WriteScannerSettingsJson()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(UserScannerSettings, options);
            File.WriteAllText(UserScannerSettingsPath, json);
        }

        public static void ReadSaveSettingsJson()
        {
            string json = File.ReadAllText(UserSaveSettingsPath);
            UserSaveSettings = JsonSerializer.Deserialize<UserSaveSettings>(json);
        }

        public static void WriteSaveSettingsJson()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(UserSaveSettings, options);
            File.WriteAllText(UserSaveSettingsPath, json);
        }

        public bool CheckJsonFileHasContent(string path)
        {
            string content = File.ReadAllText(path);
            return !string.IsNullOrEmpty(content);
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
