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
    public enum RemoveModResult
    {
        No,
        Yes,
        YesWithFiles
    }

    public partial class RemoveModForm : Form
    {
        public RemoveModResult Result = RemoveModResult.No;
        public RemoveModForm()
        {
            InitializeComponent();
            ShowDialog();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            Result = chkDeleteFIles.Checked ? RemoveModResult.YesWithFiles : RemoveModResult.Yes;
            this.Close();
        }
    }
}
