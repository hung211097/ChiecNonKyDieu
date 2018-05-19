using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using WMPLib;
using ChiecNonKyDieu.GUI;
using System.IO;
using System.Reflection;
using ChiecNonKyDieu.DTO;
using ChiecNonKyDieu.DAO;
using ChiecNonKyDieu.BUS;
using System.Media;

namespace ChiecNonKyDieu
{
    public partial class Menu : Form
    {
        private WindowsMediaPlayer wplayer;
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");
        public Menu()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            Image image2 = cropImage(ChiecNonKyDieu.Properties.Resources.img3, new Rectangle(150, 40, 650, 890));
            Image image3 = cropImage(ChiecNonKyDieu.Properties.Resources.img3, new Rectangle(1450, 40, 650, 890));
            pictureBox2.Image = image2;
            pictureBox3.Image = image3;
            DoubleBuffered = true;

            wplayer = new WindowsMediaPlayer();
            string resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources");
            wplayer.settings.setMode("loop", true);
            wplayer.URL = resFolder + "/ThemeSong.mp3";
            wplayer.controls.play();
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }
        

        private void Menu_Load(object sender, EventArgs e)
        {
            wplayer.controls.play();
            //Opacity = 0;      //first the opacity is 0

            timer1.Interval = 15;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            //timer1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }


        private void rectangleShapePlay_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapePlay.BackColor = Color.White;
            rectangleShapePlay.BorderColor = Color.DodgerBlue;
            labelPlay.BackColor = Color.White;
            labelPlay.ForeColor = Color.DodgerBlue;
        }

        private void rectangleShapePlay_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapePlay.BackColor = Color.DodgerBlue;
            labelPlay.BackColor = Color.DodgerBlue;
            labelPlay.ForeColor = Color.Yellow;
            rectangleShapePlay.BorderColor = Color.Yellow;
        }


        private void rectangleShapeRank_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeRank.BackColor = Color.White;
            rectangleShapeRank.BorderColor = Color.DodgerBlue;
            labelRank.BackColor = Color.White;
            labelRank.ForeColor = Color.DodgerBlue;
        }

        private void rectangleShapeRank_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeRank.BackColor = Color.DodgerBlue;
            labelRank.BackColor = Color.DodgerBlue;
            labelRank.ForeColor = Color.Yellow;
            rectangleShapeRank.BorderColor = Color.Yellow;
        }

        private void rectangleShapeOption_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeOption.BackColor = Color.White;
            rectangleShapeOption.BorderColor = Color.DodgerBlue;
            labelOption.BackColor = Color.White;
            labelOption.ForeColor = Color.DodgerBlue;
        }

        private void rectangleShapeOption_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeOption.BackColor = Color.DodgerBlue;
            labelOption.BackColor = Color.DodgerBlue;
            labelOption.ForeColor = Color.Yellow;
            rectangleShapeOption.BorderColor = Color.Yellow;
        }

        private void rectangleShapeExit_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeExit.BackColor = Color.White;
            rectangleShapeExit.BorderColor = Color.DodgerBlue;
            labelExit.BackColor = Color.White;
            labelExit.ForeColor = Color.DodgerBlue;
        }

        private void rectangleShapeExit_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeExit.BackColor = Color.DodgerBlue;
            labelExit.BackColor = Color.DodgerBlue;
            labelExit.ForeColor = Color.Yellow;
            rectangleShapeExit.BorderColor = Color.Yellow;
        }

        private void rectangleShapeExit_Click(object sender, EventArgs e)
        {
            soundButton.Play();
            Application.Exit();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            soundButton.Play();
            Application.Exit();
        }

        private void rectangleShapeOption_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            Option option = new Option(this);
            this.Hide();
            option.Show();
        }
    
        private void rectangleShapeRank_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            Rank rank = new Rank(this);
            this.Hide();
            rank.Show();
        }

        private void rectangleShapePlay_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            NumberPlayer num = new NumberPlayer(this, wplayer);
            this.Hide();
            num.Show();
        }
    }
}
