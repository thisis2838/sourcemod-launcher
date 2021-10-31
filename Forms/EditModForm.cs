using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sourcemod_launcher.Forms
{
    public partial class EditModForm : Form
    {
        public SourceMod Mod;
        public bool Modified = false;
        public EditModForm(SourceMod mod)
        {
            InitializeComponent();

            Mod = mod;
            boxModName.Text = mod.Title;
            boxDisplayedName.Text = mod.DisplayedTitle;
            boxDisplayedNameSecond.Text = mod.DisplayedTitle2;
            boxGamePath.Text = mod.LauncherPath.Trim('s');
            boxLaunchParams.Text = mod.LaunchOptions;
            chkSteamAppID.Checked = mod.UsesSteamId;

            this.ShowDialog();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Mod.Title = boxModName.Text;
            Mod.DisplayedTitle = boxDisplayedName.Text;
            Mod.DisplayedTitle2 = boxDisplayedNameSecond.Text;
            Mod.LauncherPath = (chkSteamAppID.Checked) ? "s" + boxGamePath.Text : boxGamePath.Text;
            Mod.LaunchOptions = boxLaunchParams.Text;

            Mod.WriteSettings();
            Modified = true;
            this.Close();
        }
    }
}
