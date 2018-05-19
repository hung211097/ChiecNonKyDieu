using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChiecNonKyDieu.BUS;
using ChiecNonKyDieu.DTO;

namespace ChiecNonKyDieu.GUI
{
    public partial class Rank : Form
    {
        Form parent;
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");

        public Rank(Form x)
        {
            InitializeComponent();
            parent = x;
            DoubleBuffered = true;
        }

        private void Rank_Load(object sender, EventArgs e)
        {
            RankBUS rank = new RankBUS();
            BXH bxh = rank.GetTop10();
            for (int i = 0; i < bxh.ListPlayer.ListPLayer.Count; i++)
            {
                listBoxRank.Items.Add(bxh.ListPlayer.ListPLayer[i].Nickname);
                listBoxRank2.Items.Add(bxh.ListPlayer.ListPLayer[i].Point);                                
            }
           
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
            rectangleShapeBack.BorderColor = Color.Yellow;
            labelBack.BackColor = Color.DodgerBlue;
            labelBack.ForeColor = Color.Yellow;
        }

        
    }

    public class RankView
    {
        public string name;
        public int point;
        public RankView() { }
        public RankView(string ten, int diem)
        {
            name = ten;
            point = diem;
        }
    }
}
