using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Globalization;
using sourcemod_launcher.src;

namespace sourcemod_launcher
{
    class Program
    {
        static public string SteamExe = "";
        static public string SourceModFolder = "";
        static public SettingsFile GeneralSettings;
        static public SettingsFile OmittedSettings;
        static public SettingsFile IncludedSettings;

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                SourceModFolder = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SourceModInstallPath", "");
                SteamExe = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamExe", "");
                
                RegistryKey steamAppsKey = Registry.CurrentUser?.OpenSubKey(@"SOFTWARE\Valve\Steam\Apps") ?? null;
                if (steamAppsKey != null)
                {
                    SourceMod.SteamAppIDNames = new List<Tuple<int, string>>();
                    foreach (var ID in steamAppsKey.GetSubKeyNames())
                    {
                        var key = steamAppsKey.OpenSubKey(ID);

                        if (key == null)
                            continue;
                        try
                        {
                            if ((int)key.GetValue("Installed") == 0)
                                continue;

                            int id = int.Parse(Path.GetFileName(key.Name));
                            string name = (string)(key.GetValue("Name") ?? "");
                            if (name == "")
                                continue;

                            SourceMod.SteamAppIDNames.Add(new Tuple<int, string>(id, name));
                        }
                        catch { continue; }
                    }
                }

                GeneralSettings = new SettingsFile("settings.txt");
                OmittedSettings = new SettingsFile("omitted.txt");
                IncludedSettings = new SettingsFile("included.txt");

                Application.EnableVisualStyles();
                CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Catastrophic disaster of epic proportion!" + "\r\n\r\n" +
                    ex.ToString() + "\r\n\r\n" + 
                    ("Tell 2838 all that and that he's bad at code!"), 
                    "Error!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
    }
}
