using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChiecNonKyDieu.DTO;
using ChiecNonKyDieu.DAO;
using ChiecNonKyDieu.BUS;
using System.Text.RegularExpressions;
using System.Media;

namespace ChiecNonKyDieu.GUI
{
    public partial class Option : Form
    {
        Form parent;
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");

        public Option(Form x)
        {
            InitializeComponent();
            parent = x;

            RuleBUS ruleBus = new RuleBUS();
            QuyDinhTroChoi quyDinh = ruleBus.GetGuideLine();
            labelGuide.Text = quyDinh.Rule;
            textBoxRound.Text = quyDinh.NumberRound.ToString();
            textBoxTimeAnswer.Text = quyDinh.TimeForAnswer.ToString();
            DoubleBuffered = true;
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

        private void rectangleShapeBack_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            this.Close();
            parent.Show();            
        }

        private void rectangleShapeModify_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeModify.BackColor = Color.White;
            rectangleShapeModify.BorderColor = Color.DodgerBlue;
            labelModify.BackColor = Color.White;
            labelModify.ForeColor = Color.DodgerBlue;
        }

        private void rectangleShapeModify_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeModify.BackColor = Color.DodgerBlue;
            labelModify.BackColor = Color.DodgerBlue;
            labelModify.ForeColor = Color.Yellow;
            rectangleShapeModify.BorderColor = Color.Yellow;
        }

   
        private void rectangleShapeModify_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            textBoxRound.Enabled = true;
            textBoxTimeAnswer.Enabled = true;
        }

        private void rectangleShapeSave_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeSave.BackColor = Color.White;
            rectangleShapeSave.BorderColor = Color.DodgerBlue;
            labelSave.BackColor = Color.White;
            labelSave.ForeColor = Color.DodgerBlue;
        }

        private void rectangleShapeSave_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeSave.BackColor = Color.DodgerBlue;
            labelSave.BackColor = Color.DodgerBlue;
            labelSave.ForeColor = Color.Yellow;
            rectangleShapeSave.BorderColor = Color.Yellow;
        }

        private void rectangleShapeSave_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            Regex reg = new Regex("^[0-9]+$", RegexOptions.IgnoreCase);
            if (!reg.IsMatch(textBoxRound.Text) || !reg.IsMatch(textBoxTimeAnswer.Text))
                MessageBox.Show("Hãy nhập vào giá trị là số!");
            else
            {
                QuyDinhTroChoi qd = new QuyDinhTroChoi();
                qd.NumberRound = Int32.Parse(textBoxRound.Text);
                qd.TimeForAnswer = Int32.Parse(textBoxTimeAnswer.Text);
                RuleBUS ruleBus = new RuleBUS();
                ruleBus.SetThongSo(qd);


                textBoxRound.Enabled = false;
                textBoxTimeAnswer.Enabled = false;
                MessageBox.Show("Lưu Thành Công!");
            }
        }
    }
}