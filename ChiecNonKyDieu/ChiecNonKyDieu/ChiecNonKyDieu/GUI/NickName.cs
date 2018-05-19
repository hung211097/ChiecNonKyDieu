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
using ChiecNonKyDieu.DTO;
using WMPLib;

namespace ChiecNonKyDieu.GUI
{
    public partial class NickName : Form
    {
        Form parent;
        int Numplayer;
        Label labelPlayer3, labelPlayer4;
        TextBox textBoxPlayer3, textBoxPlayer4;
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");
        private WindowsMediaPlayer wplayer;

        public NickName(Form menu, int num, WindowsMediaPlayer y)
        {
            InitializeComponent();
            parent = menu;
            Numplayer = num;
            wplayer = y;
            DoubleBuffered = true;
        }

        void AddNickname3()
        {
            this.labelPlayer3 = new Label();
            this.labelPlayer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer3.ForeColor = System.Drawing.Color.Yellow;
            this.labelPlayer3.Location = new System.Drawing.Point(273, 165);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(314, 55);
            this.labelPlayer3.TabIndex = 3;
            this.labelPlayer3.Text = "Người Chơi 3";
            this.labelPlayer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer3.Location = new Point(labelPlayer2.Location.X, labelPlayer2.Location.Y + 133);
            this.Controls.Add(labelPlayer3);

            textBoxPlayer3 = new TextBox();
            this.textBoxPlayer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer3.Location = new System.Drawing.Point(textBoxPlayer2.Location.X, textBoxPlayer2.Location.Y + 133);
            this.textBoxPlayer3.Name = "textBoxPlayer3";
            this.textBoxPlayer3.Size = new System.Drawing.Size(438, 49);
            this.textBoxPlayer3.TabIndex = 13;
            this.Controls.Add(textBoxPlayer3);
        }

        void AddNickname4()
        {
            this.labelPlayer4 = new Label();
            this.labelPlayer4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayer4.AutoSize = true;
            this.labelPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer4.ForeColor = System.Drawing.Color.Yellow;
            this.labelPlayer4.Location = new System.Drawing.Point(273, 165);
            this.labelPlayer4.Name = "labelPlayer4";
            this.labelPlayer4.Size = new System.Drawing.Size(314, 55);
            this.labelPlayer4.TabIndex = 4;
            this.labelPlayer4.Text = "Người Chơi 4";
            this.labelPlayer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlayer4.Location = new Point(labelPlayer3.Location.X, labelPlayer3.Location.Y + 133);
            this.Controls.Add(labelPlayer4);

            textBoxPlayer4 = new TextBox();
            this.textBoxPlayer4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer4.Location = new System.Drawing.Point(textBoxPlayer3.Location.X, textBoxPlayer3.Location.Y + 133);
            this.textBoxPlayer4.Name = "textBoxPlayer4";
            this.textBoxPlayer4.Size = new System.Drawing.Size(438, 49);
            this.textBoxPlayer4.TabIndex = 13;
            this.Controls.Add(textBoxPlayer4);
        }

        private void NickName_Load(object sender, EventArgs e)
        {
            labelAlert.Visible = false;
            if (Numplayer == 3)
            {
                AddNickname3();  
            }
            else if (Numplayer == 4)
            {
                AddNickname3();
                AddNickname4();
            }
        }

        private void rectangleShapeBack_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            NumberPlayer prevWinform = new NumberPlayer(parent, wplayer);
            this.Close();
            prevWinform.Show();
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

        private void rectangleShapeNext_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();

            bool isSame = false;
            bool isEmpty = false;
            bool isOK = true;
            List<string> l = new List<string>();
            Regex reg = new Regex("^[A-Za-z0-9]+$", RegexOptions.IgnoreCase);
    
            if (Numplayer == 2)
            {
                if (textBoxPlayer1.Text == "" || textBoxPlayer2.Text == "")
                    isEmpty = true;
                else
                    if (!reg.IsMatch(textBoxPlayer1.Text) || !reg.IsMatch(textBoxPlayer2.Text))
                        isOK = false;
                else
                    if (textBoxPlayer1.Text != "" && textBoxPlayer2.Text != "")
                    {
                        l.Add(textBoxPlayer1.Text);
                        l.Add(textBoxPlayer2.Text);
                    }
            }
            else if (Numplayer == 3)
            {
                if (textBoxPlayer1.Text == "" || textBoxPlayer2.Text == "" || textBoxPlayer3.Text == "")
                    isEmpty = true;
                else
                    if (!reg.IsMatch(textBoxPlayer1.Text) || !reg.IsMatch(textBoxPlayer2.Text) || !reg.IsMatch(textBoxPlayer3.Text))
                        isOK = false;
                else
                    if (textBoxPlayer1.Text != "" && textBoxPlayer2.Text != "" && textBoxPlayer3.Text != "")
                    {
                        l.Add(textBoxPlayer1.Text);
                        l.Add(textBoxPlayer2.Text);
                        l.Add(textBoxPlayer3.Text);
                    }
            }
            else if (Numplayer == 4)
            {
                if (textBoxPlayer1.Text == "" || textBoxPlayer2.Text == "" || textBoxPlayer3.Text == "" || textBoxPlayer4.Text
                     == "")
                    isEmpty = true;
                else
                    if (!reg.IsMatch(textBoxPlayer1.Text) || !reg.IsMatch(textBoxPlayer2.Text) || !reg.IsMatch(textBoxPlayer3.Text) || !reg.IsMatch(textBoxPlayer4.Text))
                        isOK = false;
                else
                    if (textBoxPlayer1.Text != "" && textBoxPlayer2.Text != "" && textBoxPlayer3.Text != "" && textBoxPlayer4.Text != "")
                    {
                        l.Add(textBoxPlayer1.Text);
                        l.Add(textBoxPlayer2.Text);
                        l.Add(textBoxPlayer3.Text);
                        l.Add(textBoxPlayer4.Text);
                    }
            }

            if (isEmpty)
            {
                labelAlert.Visible = true;
                labelAlert.Text = "Nickname Không Được Để Trống!";
            }
            else
                if(!isOK)
                {
                    labelAlert.Visible = true;
                    labelAlert.Text = "Nickname gồm các kí tự hoa, thường và chữ số!";
                }
            else
            {
                for (int i = 0; i < l.Count; i++)
                    for (int j = 0; j < l.Count; j++)
                        if (j != i)
                            if (l[i] == l[j])
                            {
                                isSame = true;
                                break;
                            }
                if(isSame)
                {
                    labelAlert.Visible = true;
                    labelAlert.Text = "Hãy Nhập Nickname Khác Nhau!";
                }      
                else
                {
                    
                    labelAlert.Visible = false;
                    Playerlist listPlayer = new Playerlist();
                    string date = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
                    for(int i = 0; i < l.Count; i++)
                    {
                        listPlayer.AddPlayer(new Player(l[i], 0, date));
                    }

                    Stage stg = new Stage(listPlayer, parent, wplayer);
                    wplayer.controls.stop();
                    this.Close();
                    stg.Show();
                }
            }

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
      
    }
}
