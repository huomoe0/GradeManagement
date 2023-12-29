using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class DBBackupForm : Form
    {
        private string backupPath;
        public DBBackupForm()
        {
            InitializeComponent();
            backupPath = "";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            sfdlgBackup.FilterIndex = 1;
            sfdlgBackup.FileName = "";
            sfdlgBackup.Filter = "Bak Files(*.bak)|*.bak";
            // 打开文件对话框
            if (sfdlgBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = sfdlgBackup.FileName.ToString();
                txtBackup.ReadOnly = true;
            }
            backupPath = txtBackup.Text.Trim();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
