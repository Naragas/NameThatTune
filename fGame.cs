﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameThatTune
{
    public partial class fGame : Form
    {
        Random rnd = new Random();
        int musicDuration = Victorina.musicDuration;
        bool[] players = new bool[2];
        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {if (Victorina.list.Count == 0) EndGame();
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.answer = Path.GetFileNameWithoutExtension(WMP.URL);
                WMP.Ctlcontrols.play();
                Victorina.list.RemoveAt(n);
                lblTuneCount.Text = Victorina.list.Count.ToString();
                players[0] = false;
                players[1] = false;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblTuneCount.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            lblMusicDuration.Text = musicDuration.ToString();
            players[0] = false;
            players[1] = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0)
            {
                MakeMusic();
            }
        }

        private void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        void GamePause()
        {
            WMP.Ctlcontrols.pause();
            timer1.Stop();
        }

        void GamePlay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        void NextTune()
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled)
            {
                if (players[0] == false &&  e.KeyData == Keys.A)
                {
                    GamePause();
                    fMessage fm = new fMessage();
                    fm.lblMessage.Text = "Player 1";
                    players[0] = true;
                    if (fm.ShowDialog() == DialogResult.Yes)
                    {
                        lblCounterPlayer1.Text = Convert.ToString(Convert.ToInt32(lblCounterPlayer1.Text) + 1);
                        MakeMusic();
                    }
                    GamePlay();
                }
                if (players[1] == false && e.KeyData == Keys.P)
                {
                    GamePause();
                    fMessage fm = new fMessage();
                    fm.lblMessage.Text = "Player 2";
                    players[1] = true;
                    if (fm.ShowDialog() == DialogResult.Yes)
                    {
                        lblCounterPlayer2.Text = Convert.ToString(Convert.ToInt32(lblCounterPlayer2.Text) + 1);
                        MakeMusic();
                    }
                    GamePlay();
                }
            }
            
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
            {
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)(WMP.currentMedia.duration /2));
                }
            }
            
        }

        private void lblCounterPlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            }
            if (e.Button == MouseButtons.Right)
            {
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
            }
        }
    }
}
