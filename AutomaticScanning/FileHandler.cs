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
        //Path + (Folder) + ...
        public static string PathFolderUser = AppContext.BaseDirectory + @"User\";

        public static string PathUserScannerSettings = PathFolderUser + "ScannerSettings.json";
        public static UserScannerSettings UserScannerSettingsStorage; //for default, if aut_save is on then update when closing the program
        public static UserScannerSettings UserScannerSettingsCurrent; //for changed settings or communication with devices

        public static string PathUserSaveSettings = PathFolderUser + "SaveSettings.json";
        public static UserSaveSettings UserSaveSettingsStorage;
        public static UserSaveSettings UserSaveSettingsCurrent;

        public static void StartupProgram()
        {
            if (!Directory.Exists(PathFolderUser))
            {
                Directory.CreateDirectory(PathFolderUser);
            }
            UserScannerSettingsStorage = new UserScannerSettings();
            UserScannerSettingsStorage.NewFile();
            UserScannerSettingsCurrent = UserScannerSettingsStorage;

            UserSaveSettingsStorage = new UserSaveSettings();
            UserSaveSettingsStorage.NewFile();
            UserSaveSettingsCurrent = UserSaveSettingsStorage;
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
        }

        public void NewFile()
        {
            if (FileHandler.CheckJsonFileHasContent(FileHandler.PathUserScannerSettings))
            {
                scanner = string.Empty;
                dpi = 600;

                Write();
            }
        }

        public void Read()
        {
            string json = File.ReadAllText(FileHandler.PathUserScannerSettings);
            UserScannerSettings obj = JsonSerializer.Deserialize<UserScannerSettings>(json);
            scanner = obj.scanner;
            dpi = obj.dpi;
            obj = null;
        }

        public void Write()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(this, options);

            using (FileStream fs = new FileStream(FileHandler.PathUserScannerSettings, FileMode.OpenOrCreate))
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
        }

        public void NewFile()
        {
            if (FileHandler.CheckJsonFileHasContent(FileHandler.PathUserScannerSettings))
            {
                aut_save = true;
                make_parent_folder = true;
                path_save = string.Empty;
                file_extension = "pdf";
                override_file = true;

                Write();
            }
        }

        public void Read()
        {
            string json = File.ReadAllText(FileHandler.PathUserSaveSettings);
            UserSaveSettings obj = JsonSerializer.Deserialize<UserSaveSettings>(json);
            aut_save = obj.aut_save;
            make_parent_folder = obj.make_parent_folder;
            path_save = obj.path_save;
            file_extension = obj.file_extension;
            override_file = obj.override_file;
            obj = null;
        }

        public void Write()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(this, options);

            using (FileStream fs = new FileStream(FileHandler.PathUserSaveSettings, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(json);
                }
            }
        }
    }
}
