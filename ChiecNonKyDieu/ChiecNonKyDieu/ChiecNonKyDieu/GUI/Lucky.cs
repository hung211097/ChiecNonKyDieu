using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiecNonKyDieu.GUI
{
    public partial class Lucky : Form
    {
        List<TextBox> l;
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");
        public delegate void GetIndexAnswer(int index);
        public event GetIndexAnswer WhatPosition;

        public Lucky(List<TextBox> x)
        {
            InitializeComponent();
            DoubleBuffered = true;
            l = x;
            for (int i = 0; i < x.Count; i++)
            {
                TextBox txt = new TextBox();
                txt.Anchor = System.Windows.Forms.AnchorStyles.None;
                txt.Cursor = System.Windows.Forms.Cursors.Hand;
                txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txt.Location = new System.Drawing.Point(3, 3);
                txt.Name = "textBox" + i;
                txt.Tag = i;
                txt.ReadOnly = true;
                txt.Size = new System.Drawing.Size(44, 40);
                txt.TabStop = false;
                txt.Text = x[i].Text;
                txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                txt.MouseClick += Txt_MouseClick;
                flowLayoutPanel1.Controls.Add(txt);
            }
        }

        private void Txt_MouseClick(object sender, MouseEventArgs e)
        {
            bool flag = true;
            soundButton.Play();
            if (l[(int)((TextBox)sender).Tag].Text != "")
            {
                labelTalk.Text = "Tiếc quá! Ô này đã được mở rồi, bạn nhập vào vị trí khác đi!";
                flag = false;
            }

            if (flag)
            {
                WhatPosition((int)((TextBox)sender).Tag);
                this.Close();
            }
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
    }
}
