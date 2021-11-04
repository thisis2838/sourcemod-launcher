using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using static sourcemod_launcher.Program;
using System.Windows.Forms;

namespace sourcemod_launcher
{
    public class SourceMod
    {
        public string Title;
        public string DisplayedTitle;
        public string DisplayedTitle2;
        public string LaunchOptions;

        public string FilePath;
        public string LauncherPath;
        private GameInfoFile _gameInfoFile;
        public bool UsesSteamId => LauncherPath.Length > 0 ? LauncherPath[0] == 's' : false;

        public SourceMod(string filePath)
        {
            _gameInfoFile = new GameInfoFile(Path.Combine(filePath, "gameinfo.txt"));

            FilePath = filePath;
            Title = _gameInfoFile.GetValue("game").Trim('"');
            DisplayedTitle = _gameInfoFile.GetValue("title").Trim('"');
            DisplayedTitle2 = _gameInfoFile.GetValue("title2").Trim('"');
            LauncherPath = "s" + _gameInfoFile.GetValue("steamappid").Trim('"');
            ReadCustom();
        }

        public SourceMod(params string[] elements)
        {
            FilePath = elements[0];
            _gameInfoFile = new GameInfoFile(Path.Combine(FilePath, "gameinfo.txt"));
            Title = elements[1];
            DisplayedTitle = elements[2];
            DisplayedTitle2 = elements[3];
            LauncherPath = elements[4];
            LaunchOptions = elements[5];
        }

        public SourceMod(SourceMod mod)
        {
            _gameInfoFile = mod._gameInfoFile;
            FilePath = mod.FilePath;
            Title = mod.Title;
            DisplayedTitle = mod.DisplayedTitle;
            DisplayedTitle2 = mod.DisplayedTitle2;
            LauncherPath = mod.LauncherPath;
            LaunchOptions = mod.LaunchOptions;
        }

        public void ReadCustom()
        {
            string path = Path.Combine(FilePath, "slauncher-settings.txt");
            if (File.Exists(path))
            {
                var file = File.OpenText(path);
                LaunchOptions = file.ReadLine();
                LauncherPath = file.ReadLine();
                file.Close();
            }
        }

        public void WriteCustom()
        {
            string path = Path.Combine(FilePath, "slauncher-settings.txt");
            StringBuilder settings = new StringBuilder();
            settings.AppendLine(LaunchOptions);
            settings.AppendLine(LauncherPath);
            File.WriteAllText(path, settings.ToString());
        }

        public override string ToString()
        {
            return $"MOD [{Title}] LANCHER [{LauncherPath}]";
        }

        public void WriteSettings()
        {
            _gameInfoFile.WriteKeys(
                new GameInfoKey("game", $"\"{Title}\""),
                new GameInfoKey("title", $"\"{DisplayedTitle}\""),
                new GameInfoKey("title2", $"\"{DisplayedTitle2}\"")
            );

            if (UsesSteamId)
                _gameInfoFile.WriteKeys(
                new GameInfoKey("steamappid", $"{LauncherPath.Trim('s')}")
            );

            WriteCustom();
        }

        private string GetFullPath(params string[] subfolders)
        {
            return Path.Combine(FilePath, Path.Combine(subfolders));
        }

        public void CopyFile(string path)
        {
            string name = Path.GetFileName(path);
            string dest = "";
            switch (Path.GetExtension(path))
            {
                case ".cfg":
                    dest = GetFullPath("cfg", name);
                    break;
                case ".sav":
                    dest = GetFullPath(File.Exists(GetFullPath("save")) ? GetFullPath("save") : GetFullPath("SAVE"), name);
                    break;
                default:
                    dest = GetFullPath(name);
                    break;
            }

            if (path == dest)
                return;

            if (File.Exists(dest))
            {
                var d = MessageBox.Show($"{dest} already exists! Overwrite?", "Drag and Drop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                    File.Copy(path, dest, true);
            }
            else
                File.Copy(path, dest);
        }

        public void Launch(string launchOptions = "")
        {
            ProcessStartInfo info = null;

            if (launchOptions == "")
                launchOptions = LaunchOptions;

            launchOptions += " " + GeneralSettings.Entries[0];

            if (UsesSteamId)
                info = new ProcessStartInfo()
                {
                    FileName = SteamExe,
                    Arguments = $"-applaunch {LauncherPath.Trim('s')} {launchOptions} -game \"{FilePath}\""
                };
            else if (File.Exists(LauncherPath))
                info = new ProcessStartInfo()
                {
                    FileName = LauncherPath,
                    Arguments = $" {launchOptions} -game \"{FilePath}\""
                };

            if (info != null)
                Process.Start(info);
        }

        public string GetLauncher()
        {
            if (UsesSteamId)
            {
                if (!int.TryParse(LauncherPath.TrimStart('s'), out int appId))
                {
                    LauncherPath = LauncherPath.Substring(1);
                    return LauncherPath;
                }
                return ConvertAppId(appId);
            }
                
            return LauncherPath;
        }

        public string GetFilePath(bool full = false)
        {
            if (!full && Directory.GetParent(FilePath).FullName == SourceModFolder)
                return Path.GetFileName(FilePath);
            return FilePath;
        }

        public string GetDisplayedTitle()
        {
            return (DisplayedTitle + " - " + DisplayedTitle2).Trim('-', ' ');
        }

        public void DeleteFiles()
        {
            Directory.Delete(FilePath, true);
        }

        // defaults
        public static List<Tuple<int, string>> SteamAppIDNames = new List<Tuple<int, string>>()
        {
            new Tuple<int, string>(215, "Source SDK Base 2006"),
            new Tuple<int, string>(218, "Source SDK Base 2007"),
            new Tuple<int, string>(220, "Half-Life 2"),
            new Tuple<int, string>(400, "Portal"),
            new Tuple<int, string>(420, "Half-Life 2: Episode Two"),
            new Tuple<int, string>(380, "Half-Life 2: Episode One"),
            new Tuple<int, string>(620, "Portal 2"),
            new Tuple<int, string>(243730, "Source SDK Base 2013 Singleplayer"),
            new Tuple<int, string>(243750, "Source SDK Base 2013 Multiplayer"),
        };

        public static string ConvertAppId(int id)
        {
            if (SteamAppIDNames.Any(x => x.Item1 == id))
                return SteamAppIDNames.Where(x => x.Item1 == id).First().Item2;
            return "steamappid:" + id;
        }

        public void MakeShortcut(string filePath)
        {
            StringBuilder sb = new StringBuilder();
            string launchOptions = GeneralSettings.Get(0) + " " + LaunchOptions;
            if (UsesSteamId)
                sb.Append($"\"{SteamExe}\" -applaunch {LauncherPath.Trim('s')} {launchOptions}");
            else
                sb.Append($"\"{LauncherPath}\" {launchOptions}");

            sb.AppendLine($" -game \"{FilePath}\"");
            sb.AppendLine("exit");

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
