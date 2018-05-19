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
using ChiecNonKyDieu.DTO;
using WMPLib;

namespace ChiecNonKyDieu.GUI
{
    public partial class Winner : Form
    {
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");
        private SoundPlayer soundWinner = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/winner.wav");
        private WindowsMediaPlayer wplayer;

        Form parent;
        HeThong Player;
        Player winner;
        public Winner(Form x, HeThong y, Player pl, WindowsMediaPlayer z)
        {
            InitializeComponent();
            DoubleBuffered = true;

            parent = x;
            Player = y;
            wplayer = z;
            winner = pl;
            //DataSet data = new DataSet();
            //DataTable tb = new DataTable();
            //listBox1.DataSource = tb;
            for(int i = 0; i < Player.PlayerList().ListPLayer.Count; i++)
            {
                listBox1.Items.Add(Player.PlayerList().ListPLayer[i].Nickname);
                listBox2.Items.Add(Player.PlayerList().ListPLayer[i].Point);
            }

            labelWinner.Text = winner.Nickname;
        }

        private void rectangleShapeBack_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            this.Close();
            wplayer.controls.play();
            parent.Show();
        }

        private void rectangleShapeBack_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeBack.BackColor = Color.White;
            rectangleShapeBack.BorderColor = Color.Gold;
            labelBack.BackColor = Color.White;
            labelBack.ForeColor = Color.Gold;
        }

        private void rectangleShapeBack_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeBack.BackColor = Color.Gold;
            rectangleShapeBack.BorderColor = Color.White;
            labelBack.BackColor = Color.Gold;
            labelBack.ForeColor = Color.White;
        }

        private void Winner_Load(object sender, EventArgs e)
        {
            soundWinner.Play();
        }
    }
}
