using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ChiecNonKyDieu.GUI
{
    public partial class NumberPlayer : Form
    {
        Form parent;
        private int Numplayer = 0;
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");
        private WindowsMediaPlayer wplayer;

        public NumberPlayer(Form x, WindowsMediaPlayer y)
        {
            InitializeComponent();
            parent = x;                  
            DoubleBuffered = true;
            wplayer = y;            
        }

        private void rectangleShape2Player_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            Numplayer = 2;
            labelNext.Enabled = true;
            rectangleShapeNext.Enabled = true;

            rectangleShape2Player.BackColor = Color.White;
            rectangleShape2Player.BorderColor = Color.DodgerBlue;
            label2Player.BackColor = Color.White;
            label2Player.ForeColor = Color.DodgerBlue;

            rectangleShape3Player.BackColor = Color.DodgerBlue;
            label3Player.BackColor = Color.DodgerBlue;
            label3Player.ForeColor = Color.Yellow;
            rectangleShape3Player.BorderColor = Color.Yellow;

            rectangleShape4Player.BackColor = Color.DodgerBlue;
            label4Player.BackColor = Color.DodgerBlue;
            label4Player.ForeColor = Color.Yellow;
            rectangleShape4Player.BorderColor = Color.Yellow;
        }

        private void rectangleShape3Player_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            Numplayer = 3;
            labelNext.Enabled = true;
            rectangleShapeNext.Enabled = true;

            rectangleShape3Player.BackColor = Color.White;
            rectangleShape3Player.BorderColor = Color.DodgerBlue;
            label3Player.BackColor = Color.White;
            label3Player.ForeColor = Color.DodgerBlue;

            rectangleShape2Player.BackColor = Color.DodgerBlue;
            label2Player.BackColor = Color.DodgerBlue;
            label2Player.ForeColor = Color.Yellow;
            rectangleShape2Player.BorderColor = Color.Yellow;

            rectangleShape4Player.BackColor = Color.DodgerBlue;
            label4Player.BackColor = Color.DodgerBlue;
            label4Player.ForeColor = Color.Yellow;
            rectangleShape4Player.BorderColor = Color.Yellow;
        }

        private void rectangleShape4Player_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            Numplayer = 4;
            labelNext.Enabled = true;
            rectangleShapeNext.Enabled = true;

            rectangleShape4Player.BackColor = Color.White;
            rectangleShape4Player.BorderColor = Color.DodgerBlue;
            label4Player.BackColor = Color.White;
            label4Player.ForeColor = Color.DodgerBlue;

            rectangleShape3Player.BackColor = Color.DodgerBlue;
            label3Player.BackColor = Color.DodgerBlue;
            label3Player.ForeColor = Color.Yellow;
            rectangleShape3Player.BorderColor = Color.Yellow;

            rectangleShape2Player.BackColor = Color.DodgerBlue;
            label2Player.BackColor = Color.DodgerBlue;
            label2Player.ForeColor = Color.Yellow;
            rectangleShape2Player.BorderColor = Color.Yellow;
        }

        private void rectangleShapeBack_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            this.Close();
            parent.Show();
        }

        private void rectangleShapeBack_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeBack.BackColor = Color.White;
            rectangleShapeBack.BorderColor = Color.DodgerBlue;
            labelBack.BackColor = Color.White;
            labelBack.ForeColor = Color.DodgerBlue;
        }

        private void rectangleShapeBack_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeBack.BackColor = Color.DodgerBlue;
            labelBack.BackColor = Color.DodgerBlue;
            labelBack.ForeColor = Color.Yellow;
            rectangleShapeBack.BorderColor = Color.Yellow;
        }

        private void rectangleShapeNext_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeNext.BackColor = Color.White;
            rectangleShapeNext.BorderColor = Color.DodgerBlue;
            labelNext.BackColor = Color.White;
            labelNext.ForeColor = Color.DodgerBlue;
        }

        private void rectangleShapeNext_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeNext.BackColor = Color.DodgerBlue;
            labelNext.BackColor = Color.DodgerBlue;
            labelNext.ForeColor = Color.Yellow;
            rectangleShapeNext.BorderColor = Color.Yellow;
        }

        private void rectangleShapeNext_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            NickName nick = new NickName(parent, Numplayer, wplayer);
            nick.Show();
            this.Close();
        }
    }
}
