using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatTune
{
    public partial class fParam : Form
    {
        public fParam()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = cbAllDirectories.Checked;
            Victorina.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Victorina.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Victorina.randomStart = cbRandomStart.Checked;
            Victorina.WriteParam();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetOptions();
            listBox1.Items.Clear();
            this.Hide();
        }

        private void SetOptions()
        {
            cbAllDirectories.Checked = Victorina.allDirectories;
            cbGameDuration.Text = Victorina.gameDuration.ToString();
            cbMusicDuration.Text = Victorina.musicDuration.ToString();
            cbRandomStart.Checked = Victorina.randomStart;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] musicList = Directory.GetFiles
                    (
                    fbd.SelectedPath,
                    "*.flac",
                    cbAllDirectories.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly
                    );
                Victorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(musicList);
                Victorina.list.Clear();
                Victorina.list.AddRange(musicList);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fParam_Load(object sender, EventArgs e)
        {
            SetOptions();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
