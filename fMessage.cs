﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatTune
{
    public partial class fMessage : Form
    {
        int timeAnswer = 10;
        public fMessage()
        {
            InitializeComponent();
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = 10;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timeAnswer--;
            lblTimer.Text = timeAnswer.ToString();
            
            if (timeAnswer == 0)
            {
                timer1.Stop();
                SoundPlayer sp = new SoundPlayer(@"Resources\error.wav");
                sp.Play();
                lblShowAnswer.Visible = true;
            }
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void lblShowAnswer_Click(object sender, EventArgs e)
        {
            lblShowAnswer.Text = Victorina.answer;
        }
    }
}
