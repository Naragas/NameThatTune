using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatTune
{
    public partial class mainForm : Form
    {
        fParam fp = new fParam();
        fGame fg = new fGame();

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            
            fp.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fg.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadMusic();
        }
    }
}
