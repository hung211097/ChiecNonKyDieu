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

namespace ChiecNonKyDieu.GUI
{
    public partial class GuessAnswer : Form
    {
        public delegate void GetIndexAnswer(string output);
        public event GetIndexAnswer WhatAnswer;
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");

        public GuessAnswer()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void rectangleShapeAccept_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            if (textBoxAnswer.Text == "")
            {
                labelTalk.Text = "Chưa nhập gì hết kìa bạn gì đó êi!";
                labelTalk.TextAlign = ContentAlignment.MiddleLeft;                
            }
            else
            {
                WhatAnswer(textBoxAnswer.Text);
                this.Close();
            }
        }

        private void rectangleShapeAccept_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeAccept.BackColor = Color.White;
            rectangleShapeAccept.BorderColor = Color.White;
            labelAccept.BackColor = Color.White;
            labelAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void rectangleShapeAccept_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeAccept.BackColor = Color.Khaki;
            rectangleShapeAccept.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelAccept.BackColor = Color.Khaki;
            labelAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void textBoxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                soundButton.Play();
                if (textBoxAnswer.Text == "")
                {
                    labelTalk.Text = "Chưa nhập gì hết kìa bạn gì đó êi!";
                    labelTalk.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    WhatAnswer(textBoxAnswer.Text);
                    this.Close();
                }
            }
        }
    }
}
