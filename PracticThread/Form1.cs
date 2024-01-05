using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticThread
{
    public partial class Form1 : Form
    {
        Form FileForm = null;
        Form DirectoryForm = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void CopyFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileForm == null)
            {
                FileForm = new FileForm();
                FileForm.Show();
            }
            else
            {
                if (MessageBox.Show(
                    "Закрыть окно ?", "Окно уже открыто",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FileForm.Close();
                    FileForm = null;
                }
            }
        }

        private void CopyDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DirectoryForm == null)
            {
                DirectoryForm = new DirectoryForm();
                DirectoryForm.Show();
            }
            else
            {
                if (MessageBox.Show(
                    "Закрыть окно ?", "Окно уже открыто",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DirectoryForm.Close();
                    DirectoryForm = null;
                }
            }
        }
    }
}
