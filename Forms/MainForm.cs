using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sourcemod_launcher.Program;
using System.IO;
using sourcemod_launcher.Forms;
using System.Diagnostics;

namespace sourcemod_launcher
{
    public partial class MainForm : Form
    {
        private List<SourceMod> _mods;
        private int _dgvModsCurrentlySelected => dgvMods.SelectedCells[0].RowIndex;
        private SourceMod _currentSelectedMod =>
            dgvMods.SelectedCells.Count == 0 ?
            _mods.First() :
            _mods.Where(x => x.FilePath == (string)dgvMods.Rows[_dgvModsCurrentlySelected].Cells[5].Value).First();
        private int ModIndexToDGVIndex(int modIndex)
        {
            foreach (DataGridViewRow row in dgvMods.Rows)
            {
                if ((string)row.Cells[5].Value == _mods[modIndex].FilePath)
                    return row.Index;
            }
            return -1;
        }

        private Size _maxStartSize = new Size(900, 600);
        private float Area(Size s)
        {
            return s.Width * s.Height;
        }

        public MainForm()
        {
            _mods = new List<SourceMod>();

            InitializeComponent();

            FillLabels();
            dgvMods.SelectionChanged += DgvMods_SelectionChanged;
            Directory.EnumerateDirectories(SourceModFolder).Concat(IncludedSettings.Entries).ToList()
                .ForEach(x =>
            {
                if (!OmittedSettings.Entries.Contains(x))
                {
                    try 
                    { 
                        var mod = new SourceMod(x);
                        AddMod(mod);
                    }
                    catch {  }
                }
            });
            dgvMods.ClearSelection();
            dgvMods_Highlight(0);

            boxCommonLaunchParams.Text = GeneralSettings.Get(0);

            rboxDragDrop.AllowDrop = true;
            rboxDragDrop.DragDrop += RboxDragDrop_DragDrop;
            rboxDragDrop.KeyPress += RboxDragDrop_KeyPress;
            RboxDragDrop_KeyPress(null, null);

            this.FormClosing += MainForm_FormClosing;

            Size = new Size(int.Parse("0" + GeneralSettings.Get(1)), int.Parse("0" + GeneralSettings.Get(2)));
            Size = Area(Size) > Area(_maxStartSize) ? _maxStartSize : Size;
            SizeChanged += MainForm_SizeChanged;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            GeneralSettings.Set(1, Width.ToString());
            GeneralSettings.Set(2, Height.ToString());

            bool full = Math.Abs(Area(Screen.PrimaryScreen.Bounds.Size - Size) / Area(Screen.PrimaryScreen.Bounds.Size - MinimumSize)) < 0.5f;

            dgvcDisplayedName.Width = full ? 300 : 100;
            dgvcLaunchParams.Width = full ? 500 : 150;
        }

        private void RboxDragDrop_KeyPress(object sender, KeyPressEventArgs e)
        {
            rboxDragDrop.Text = "\n\nDrag and Drop files here to move them into appropriate folders\n(.cfg into cfg folder, .sav into save folder, etc..)";
            if (e != null)
                e.Handled = true;
        }

        private void RboxDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = (e.Data?.GetData(DataFormats.FileDrop) as string[])[0] ?? "";
            _currentSelectedMod.CopyFile(filePath);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeneralSettings.WriteSettings();
            OmittedSettings.WriteSettings();
            IncludedSettings.WriteSettings();
        }

        private void AddMod(SourceMod mod)
        {
            if (_mods.Any(x => x.FilePath == mod.FilePath))
                return;

            _mods.Add(mod);
            dgvMods.Rows.Add(new string[]
            {
                mod.Title,
                mod.GetDisplayedTitle(),
                mod.GetLauncher(),
                mod.GetFilePath(),
                mod.LaunchOptions,
                mod.FilePath
            });

            dgvMods.ClearSelection();
            dgvMods_Highlight(dgvMods.Rows.Count - 1);
        }

        private void UpdateMod(int modIndex, SourceMod mod)
        {
            int dgvIndex = ModIndexToDGVIndex(modIndex);
            dgvMods.Rows[dgvIndex].SetValues( new string[]
            {
                mod.Title,
                mod.GetDisplayedTitle(),
                mod.GetLauncher(),
                mod.GetFilePath(),
                mod.LaunchOptions,
                mod.FilePath
            });
            _mods[modIndex] = new SourceMod(mod);
        }

        private void dgvMods_Highlight(int i)
        {
            if (dgvMods.Rows.Count > 0)
            {
                dgvMods.Rows[i].Cells[0].Selected = true;
                dgvMods.FirstDisplayedScrollingRowIndex = i;
            }
        }

        private void DgvMods_SelectionChanged(object sender, EventArgs e)
        {
            FillLabels(_currentSelectedMod);
        }

        private void FillLabels(SourceMod mod = null)
        {
            labModName.Text = mod?.Title ?? "";
            labDisplayedName.Text = mod?.GetDisplayedTitle() ?? "";
            labGame.Text = mod?.GetLauncher() ?? "";
            labFilePath.Text = mod?.GetFilePath(true) ?? "";
            labLaunchParams.Text = mod?.LaunchOptions ?? "";
        }

        private void butLaunchMod_Click(object sender, EventArgs e)
        {
            _currentSelectedMod.Launch();
        }

        private void boxCommonLaunchParams_TextChanged(object sender, EventArgs e)
        {
            GeneralSettings.Set(0, boxCommonLaunchParams.Text);
        }

        private void butRemoveMod_Click(object sender, EventArgs e)
        {
            RemoveModResult result = new RemoveModForm().Result;
            if (result != RemoveModResult.No)
            {
                List<string> paths = new List<string>();
                foreach (DataGridViewCell cells in dgvMods.SelectedCells)
                {
                    if (!paths.Contains((string)cells.OwningRow.Cells[5].Value))
                        paths.Add((string)cells.OwningRow.Cells[5].Value);
                }

                foreach (string path in paths)
                {
                    foreach (DataGridViewRow row in dgvMods.Rows)
                    {
                        if ((string)row.Cells[5].Value == path)
                        {
                            dgvMods.Rows.Remove(row);
                            break;
                        }
                    }

                    SourceMod mod = _mods.Where(x => x.FilePath == path).First();
                    if (result == RemoveModResult.YesWithFiles)
                        mod.DeleteFiles();

                    OmittedSettings.AddEntry(path);
                    IncludedSettings.RemoveEntry(path);

                    _mods.Remove(mod);
                }

                if (_mods.Count() == 0)
                    FillLabels();
            }
        }

        private void butAddMod_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "gameinfo file|gameinfo.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = Directory.GetParent(openFileDialog.FileName).FullName;
                if (!_mods.Any(x => x.FilePath == path))
                {
                    IncludedSettings.AddEntry(path);
                    OmittedSettings.RemoveEntry(path);
                    AddMod(new SourceMod(path));
                }
                else
                    MessageBox.Show(
                        "A mod with the same file path is already present!", 
                        "Mod already included!", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
            }
        }

        private void butEditMod_Click(object sender, EventArgs e)
        {
            var editForm = new EditModForm(_currentSelectedMod);
            if (editForm.Modified)
            {
                UpdateMod(_mods.IndexOf(_currentSelectedMod), editForm.Mod);
                dgvMods_Highlight(_dgvModsCurrentlySelected);
                FillLabels(_currentSelectedMod);
            }
        }

        private void butExplore_Click(object sender, EventArgs e)
        {
            Process.Start(_currentSelectedMod.FilePath);
        }
    }
}
