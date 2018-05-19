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
using ChiecNonKyDieu.BUS;
using System.Media;
using WMPLib;

namespace ChiecNonKyDieu.GUI
{
    public partial class Stage : Form
    {
        public const int DIS = 131;
        private WindowsMediaPlayer wplayer;
        Form parent;
        PictureBox pictureBoxPodium3, pictureBoxPodium4, pictureBoxPlayer3, pictureBoxPlayer4;
        TextBox textBoxPointPlayer3, textBoxPointPlayer4;
        Label labelPlayer3, labelPlayer4;
        private SoundPlayer soundButton = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button.wav");
        private SoundPlayer soundStart = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/gamestart.wav");
        private SoundPlayer soundAlphabet = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/button-29.wav");
        private SoundPlayer soundSuccess = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/Success.wav");    
        private SoundPlayer soundFail = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/Fail.wav");
        private SoundPlayer soundYay = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/Yay.wav");
        private SoundPlayer soundWow = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/wow.wav");
        private SoundPlayer soundSpin = new SoundPlayer(System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "/spin.wav");
        private int Round = 1;
        private int Turn = 1;
        private int Numplayer;
        private bool GuessCharacter = false;
        private bool IsSpin = false;
        private bool FinishGame = false;
        private bool IsExtra = false;
        private string Point = "";
        private int TimeCountDown;

        Bitmap ChiecNonBitmap = new Bitmap(ChiecNonKyDieu.Properties.Resources.CNKD);
        Image hinhChiecNon;
        ChuDe cd;
        CauHoi ques;

        HeThong QLCH = new HeThongQuanLyCauHoi();
        HeThong QLTD = new HeThongTinhDiem();
        HeThong QLQN = new HeThongQuayNon();
        List<TextBox> Answer = new List<TextBox>();
        QuyDinhTroChoi qd = new QuyDinhTroChoi();
        Timer timer = new Timer();
        Timer timer1 = new Timer();
        Timer timerWin = new Timer();
        Timer timerFinishRound = new Timer();
        Timer timerCountDown = new Timer();
        GuessAnswer guess;

        public float Start = 0F;
        public float Stop = 1500F;
        private bool IsDeal = false;
        private bool MoreTurn = false;
        private string Inform = "";
        private char buttonText;
        private int Count = 0;
        public float Start1 = 0F;
        public float Stop1 = 2000F;

        public Stage(Playerlist l, Form x, WindowsMediaPlayer y)
        {                       
            InitializeComponent();
            QLTD.SetPlayerlist(l);
            Numplayer = QLTD.PlayerList().ListPLayer.Count;
            parent = x;
            hinhChiecNon = ChiecNonBitmap;
            DoubleBuffered = true;
            wplayer = y;

            TopicBUS topic = new TopicBUS();
            QLQN.GetListPoint();
            List<ChuDe> list = topic.GetAllTopics();

            for (int i = 0; i < list.Count; i++)
                comboBoxTopic.Items.Add(list[i].NameTopic);

            RuleBUS data = new RuleBUS();
            qd = data.GetGuideLine();
            TimeCountDown = qd.TimeForAnswer;

            timer1.Interval = 500;
            timer1.Tick += Timer1_Tick;
            timerWin.Interval = 500;
            timerWin.Tick += TimerWin_Tick;
            timerFinishRound.Interval = 500;
            timerFinishRound.Tick += TimerFinishRound_Tick;
            timerCountDown.Interval = 1000;
            timerCountDown.Tick += TimerCountDown_Tick;
            labelRound.Text = "Vòng " + Round;
            labelCountDown.Text = TimeCountDown.ToString();
           // qd.NumberRound = 1;
        }

        private void Stage_Load(object sender, EventArgs e)
        {
            Image image = cropImage(ChiecNonKyDieu.Properties.Resources.img, new Rectangle(0, 0, 90, 230));
            Image image2 = cropImage(ChiecNonKyDieu.Properties.Resources.img, new Rectangle(90, 0, 90, 230));
            pictureBoxPlayer1.Image = image;
            pictureBoxPlayer2.Image = image2;
            if (QLTD.PlayerList().ListPLayer.Count == 3)
                AddPlayer3();
            else if (QLTD.PlayerList().ListPLayer.Count == 4)
            {
                AddPlayer3();
                AddPlayer4();
            }

            DisappearMain();
        }

        private void DisappearMain()
        {
            pictureBoxMC.Visible = false;
            pictureBoxCNKD.Visible = false;
            pictureBoxArrow.Visible = false;
            pictureBoxPlayer1.Visible = false;
            pictureBoxPlayer2.Visible = false;
           
            pictureBoxPodium1.Visible = false;
            pictureBoxPodium2.Visible = false;
           
            textBoxPointPlayer1.Visible = false;
            textBoxPointPlayer2.Visible = false;
           
            labelPlayer1.Visible = false;
            labelPlayer2.Visible = false;
           
            labelAlert.Visible = false;
            labelStart.Visible = false;
            labelCountDown.Visible = false;
            ovalShapeCountDown.Visible = false;
            tableLayoutPanelAlphabet.Visible = false;
            if (QLTD.PlayerList().ListPLayer.Count == 3)
            {
                pictureBoxPlayer3.Visible = false;
                pictureBoxPodium3.Visible = false;
                textBoxPointPlayer3.Visible = false;
                labelPlayer3.Visible = false;
            }
            else if(QLTD.PlayerList().ListPLayer.Count == 4)
            {
                pictureBoxPlayer3.Visible = false;
                pictureBoxPlayer4.Visible = false;
                pictureBoxPodium3.Visible = false;
                pictureBoxPodium4.Visible = false;
                textBoxPointPlayer3.Visible = false;
                textBoxPointPlayer4.Visible = false;
                labelPlayer3.Visible = false;
                labelPlayer4.Visible = false;
            }
            flowLayoutPanelQuestion.Visible = false;
            flowLayoutPanelAnswer.Visible = false;
            labelTalk.Visible = false;
            pictureBoxTalk.Visible = false;

            labelGuessAnswer.Visible = false;
            labelGuessCharacter.Visible = false;
            rectangleShapeGuessAnswer.Visible = false;
            rectangleShapeGuessCharacter.Visible = false;
            DisappearArrow();
        }

        private void AppearMain()
        {
            labelStart.Visible = false;
            pictureBoxMC.Visible = true;
            pictureBoxCNKD.Visible = true;
            pictureBoxArrow.Visible = true;
            pictureBoxPlayer1.Visible = true;
            pictureBoxPlayer2.Visible = true;
            pictureBoxPodium1.Visible = true;
            pictureBoxPodium2.Visible = true;
            textBoxPointPlayer1.Visible = true;
            textBoxPointPlayer2.Visible = true;
            labelPlayer1.Visible = true;
            labelPlayer2.Visible = true;
            tableLayoutPanelAlphabet.Visible = true;
            flowLayoutPanelQuestion.Visible = true;
            flowLayoutPanelAnswer.Visible = true;
            if (QLTD.PlayerList().ListPLayer.Count == 3)
            {
                pictureBoxPlayer3.Visible = true;
                pictureBoxPodium3.Visible = true;
                textBoxPointPlayer3.Visible = true;
                labelPlayer3.Visible = true;
            }
            else if (QLTD.PlayerList().ListPLayer.Count == 4)
            {
                pictureBoxPlayer3.Visible = true;
                pictureBoxPlayer4.Visible = true;
                pictureBoxPodium3.Visible = true;
                pictureBoxPodium4.Visible = true;
                textBoxPointPlayer3.Visible = true;
                textBoxPointPlayer4.Visible = true;
                labelPlayer3.Visible = true;
                labelPlayer4.Visible = true;
            }

            labelTalk.Visible = true;
            pictureBoxTalk.Visible = true;

            labelCountDown.Visible = true;
            ovalShapeCountDown.Visible = true;
            AppearWayToAnswer();
        }

        private void AppearWayToAnswer()
        {
            labelGuessAnswer.Visible = true;
            labelGuessCharacter.Visible = true;
            rectangleShapeGuessAnswer.Visible = true;
            rectangleShapeGuessCharacter.Visible = true;
        }

        private void DisappearWayToAnswer()
        {
            labelGuessAnswer.Visible = false;
            labelGuessCharacter.Visible = false;
            rectangleShapeGuessAnswer.Visible = false;
            rectangleShapeGuessCharacter.Visible = false;
        }

        private void rectangleShapeBack_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            wplayer.controls.play();
            this.Close();
            parent.Show();
        }
       
        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private void rectangleShapeBack_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeBack.BackColor = Color.White;
            rectangleShapeBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelBack.BackColor = Color.White;
            labelBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void rectangleShapeBack_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelBack.ForeColor = Color.Khaki;
            rectangleShapeBack.BorderColor = Color.Khaki;
        }   

        private void rectangleShapeAccept_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeAccept.BackColor = Color.White;
            rectangleShapeAccept.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelAccept.BackColor = Color.White;
            labelAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void rectangleShapeAccept_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelAccept.ForeColor = Color.White;
            rectangleShapeAccept.BorderColor = Color.White;
        }

        private void rectangleShapeAccept_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxTopic.SelectedIndex != -1)
            {
                cd = CatchTopic(comboBoxTopic.SelectedIndex, comboBoxTopic.SelectedItem.ToString());
                ques = QLCH.GetQuestion(cd);

                if(ques.IDQuestion == "")
                {
                    soundButton.Play();
                    labelAlert.Text = "Xin lỗi bạn! Câu hỏi dành cho chủ đề này không còn, bạn vui lòng chọn chủ đề khác!";
                    labelAlert.Visible = true;
                }
                else
                {
                    soundStart.Play();

                    labelStart.Visible = true;
                    if(IsExtra)
                        labelStart.Text = "TROØ CHÔI BAÉT ÑAÀU\nVOØNG PHUÏ";
                    else
                        labelStart.Text = "TROØ CHÔI BAÉT ÑAÀU";

                    labelAlert.Visible = false;
                    DisappearTopic();

                    timer.Interval = 500;
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
            }
            else
            {
                soundButton.Play();
                labelAlert.Text = "Hãy Chọn Chủ Đề!";
                labelAlert.Visible = true;
            }
        }

        private void DisappearTopic()
        {
            labelTopic.Visible = false;
            comboBoxTopic.Visible = false;
            labelAccept.Visible = false;
            labelAlert.Visible = false;
            rectangleShapeAccept.Visible = false;
        }

        private void AppearTopic()
        {
            timerFinishRound.Stop();
            labelTopic.Visible = true;
            comboBoxTopic.Visible = true;
            comboBoxTopic.SelectedIndex = -1;
            labelAccept.Visible = true;
            labelAlert.Visible = false;
            rectangleShapeAccept.Visible = true;
            labelStart.Visible = false;
            labelRound.Text = "Vòng " + Round;
            Start1 = 0F;
        }

        private void DisappearArrow()
        {
            pictureBoxArrowPlayer1.Visible = false;
            pictureBoxArrowPlayer2.Visible = false;
            pictureBoxArrowPlayer3.Visible = false;
            pictureBoxArrowPlayer4.Visible = false;
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Start < Stop)
            {
                Start += timer.Interval;
            }
            else
            {
                StartGame();
            }
        }

        private void StartGame()
        {
            timer.Stop();
            Start = 0F;
            AppearMain();

            
            labelQuestion.Text = ques.Content;
            for(int i = 0; i < ques.Answer.Length; i++)
            {
                TextBox txt = new TextBox();
                txt.Anchor = System.Windows.Forms.AnchorStyles.None;
                txt.Cursor = System.Windows.Forms.Cursors.Default;
                txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txt.Location = new System.Drawing.Point(3, 3);
                txt.Name = "textBox" + i;
                txt.ReadOnly = true;
                txt.Size = new System.Drawing.Size(44, 40);
                txt.TabStop = false;
                txt.Text = "";
                txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                Answer.Add(txt);
                flowLayoutPanelAnswer.Controls.Add(txt);
            }
            labelTalk.Text = "Lượt của Người chơi " + Turn;
            pictureBoxArrowPlayer1.Visible = true;            
        }

        private bool CheckFinishRound(List<TextBox> l)
        {
            int S = 0;
            bool flag = false;
            for (int i = 0; i < l.Count; i++)
                if (l[i].Text != "")
                    S++;
            if (S == l.Count)
                flag = true;
            return flag;
        }

        private ChuDe CatchTopic(int index, string content)
        {
            ChuDe cd = new ChuDe();
            switch(index)
            {
                case 0:
                    cd.IDTopic = "CayCoi";
                    break;
                case 1:
                    cd.IDTopic = "ConVat";
                    break;
                case 2:
                    cd.IDTopic = "DoVui";
                    break;
                case 3:
                    cd.IDTopic = "LichSu";
                    break;
                case 4:
                    cd.IDTopic = "TheGioi";
                    break;
                case 5:
                    cd.IDTopic = "TheThao";
                    break;
            }
            cd.NameTopic = content;

            return cd;
        }

        private void labelPlayer1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(QLTD.PlayerList().ListPLayer[0].Nickname, "Tên Người Chơi");
        }

        private void labelPlayer2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(QLTD.PlayerList().ListPLayer[1].Nickname, "Tên Người Chơi");
        }

        private void LabelPlayer3_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(QLTD.PlayerList().ListPLayer[2].Nickname, "Tên Người Chơi");
        }

        private void LabelPlayer4_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(QLTD.PlayerList().ListPLayer[3].Nickname, "Tên Người Chơi");
        }

        private void AddPlayer4()
        {
            pictureBoxPlayer4 = new PictureBox();
            pictureBoxPodium4 = new PictureBox();
            textBoxPointPlayer4 = new TextBox();
            labelPlayer4 = new Label();

            this.pictureBoxPlayer4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPlayer4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer4.Location = new System.Drawing.Point(pictureBoxPlayer3.Location.X + DIS + 3, 487);
            this.pictureBoxPlayer4.Name = "pictureBoxPlayer4";
            this.pictureBoxPlayer4.Size = new System.Drawing.Size(100, 230);
            this.pictureBoxPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.pictureBoxPodium4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPodium4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPodium4.Image = global::ChiecNonKyDieu.Properties.Resources.podium;
            this.pictureBoxPodium4.Location = new System.Drawing.Point(pictureBoxPodium3.Location.X + DIS, 622);
            this.pictureBoxPodium4.Name = "pictureBoxPodium4";
            this.pictureBoxPodium4.Size = new System.Drawing.Size(94, 95);

            this.labelPlayer4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayer4.AutoSize = true;
            this.labelPlayer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPlayer4.Location = new System.Drawing.Point(labelPlayer3.Location.X + DIS + 4, 725);
            this.labelPlayer4.Name = "labelPlayer4";
            this.labelPlayer4.Size = new System.Drawing.Size(73, 20);
            this.labelPlayer4.Text = "Người Chơi 4";
            this.labelPlayer4.Cursor = Cursors.Hand;
            this.labelPlayer4.MouseClick += LabelPlayer4_MouseClick;

            this.textBoxPointPlayer4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPointPlayer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPointPlayer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPointPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPointPlayer4.ForeColor = System.Drawing.Color.White;
            this.textBoxPointPlayer4.Location = new System.Drawing.Point(textBoxPointPlayer3.Location.X + DIS, 632);
            this.textBoxPointPlayer4.Name = "textBoxPointPlayer4";
            this.textBoxPointPlayer4.ReadOnly = true;
            this.textBoxPointPlayer4.Size = new System.Drawing.Size(94, 24);
            this.textBoxPointPlayer4.Text = "0";
            this.textBoxPointPlayer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPointPlayer4.TabStop = false;

            Image image4 = cropImage(ChiecNonKyDieu.Properties.Resources.img, new Rectangle(265, 0, 80, 230));
            pictureBoxPlayer4.Image = image4;
            this.Controls.Add(textBoxPointPlayer4);
            this.Controls.Add(pictureBoxPodium4);
            this.Controls.Add(pictureBoxPlayer4);
            this.Controls.Add(labelPlayer4);
        }

        private void AddPlayer3()
        {
            pictureBoxPlayer3 = new PictureBox();
            pictureBoxPodium3 = new PictureBox();
            textBoxPointPlayer3 = new TextBox();
            labelPlayer3 = new Label();

            this.pictureBoxPlayer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPlayer3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer3.Location = new System.Drawing.Point(pictureBoxPlayer2.Location.X + DIS + 5, 487);
            this.pictureBoxPlayer3.Name = "pictureBoxPlayer3";
            this.pictureBoxPlayer3.Size = new System.Drawing.Size(102, 230);
            this.pictureBoxPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.pictureBoxPodium3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPodium3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPodium3.Image = global::ChiecNonKyDieu.Properties.Resources.podium;
            this.pictureBoxPodium3.Location = new System.Drawing.Point(pictureBoxPodium2.Location.X + DIS, 622);
            this.pictureBoxPodium3.Name = "pictureBoxPodium3";
            this.pictureBoxPodium3.Size = new System.Drawing.Size(94, 95);

            this.labelPlayer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPlayer3.Location = new System.Drawing.Point(labelPlayer2.Location.X + DIS + 4, 725);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(73, 20);
            this.labelPlayer3.Text = "Người Chơi 3";
            this.labelPlayer3.Cursor = Cursors.Hand;
            this.labelPlayer3.MouseClick += LabelPlayer3_MouseClick;

            this.textBoxPointPlayer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPointPlayer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPointPlayer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPointPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPointPlayer3.ForeColor = System.Drawing.Color.White;
            this.textBoxPointPlayer3.Location = new System.Drawing.Point(textBoxPointPlayer2.Location.X + DIS, 632);
            this.textBoxPointPlayer3.Name = "textBoxPointPlayer3";
            this.textBoxPointPlayer3.ReadOnly = true;
            this.textBoxPointPlayer3.Size = new System.Drawing.Size(94, 24);
            this.textBoxPointPlayer3.Text = "0";
            this.textBoxPointPlayer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPointPlayer3.TabStop = false;

            Image image3 = cropImage(ChiecNonKyDieu.Properties.Resources.img, new Rectangle(180, 0, 85, 230));
            pictureBoxPlayer3.Image = image3;
            this.Controls.Add(textBoxPointPlayer3);
            this.Controls.Add(pictureBoxPodium3);
            this.Controls.Add(pictureBoxPlayer3);
            this.Controls.Add(labelPlayer3);
        }

        private void rectangleShapeGuessAnswer_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeGuessAnswer.BackColor = Color.White;
            rectangleShapeGuessAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelGuessAnswer.BackColor = Color.White;
            labelGuessAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void rectangleShapeGuessAnswer_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeGuessAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelGuessAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelGuessAnswer.ForeColor = Color.White;
            rectangleShapeGuessAnswer.BorderColor = Color.White;
        }

        private void rectangleShapeGuessAnswer_MouseClick(object sender, MouseEventArgs e)
        {
            soundWow.Play();
            DisappearWayToAnswer();
            guess = new GuessAnswer();
            guess.Show();
            timerCountDown.Start();
            guess.WhatAnswer += Guess_WhatAnswer;            
        }

        private void Guess_WhatAnswer(string output)
        {
            output = output.ToUpper();
            output = output.Replace(" ", string.Empty);

            timerCountDown.Stop();
            TimeCountDown = qd.TimeForAnswer;
            labelCountDown.Text = TimeCountDown.ToString();

            bool isCorrect = true;
            if (output.Length > ques.Answer.Length)
                isCorrect = false;
            else
            {
                for(int i = 0; i < ques.Answer.Length; i++)
                    if(output[i] != ques.Answer[i])
                    {
                        isCorrect = false;
                        break;
                    }
            }

            if(!isCorrect)
            {
                soundFail.Play();

                do
                {
                    Turn++;
                    if (Turn > Numplayer)
                        Turn = 1;
                } while (QLTD.PlayerList().ListPLayer[Turn - 1].IsOut);
                
                DisappearArrow();
                switch (Turn)
                {
                    case 1:
                        pictureBoxArrowPlayer1.Visible = true;
                        break;
                    case 2:
                        pictureBoxArrowPlayer2.Visible = true;
                        break;
                    case 3:
                        pictureBoxArrowPlayer3.Visible = true;
                        break;
                    case 4:
                        pictureBoxArrowPlayer4.Visible = true;
                        break;
                }
                AppearWayToAnswer();

                labelTalk.Text = "Thật tiếc! Đáp án của bạn chưa chính xác, xin mời Người chơi " + Turn;
            }
            else
            {
                timerWin.Start();
                soundSuccess.Play();
                int dem = 0;
                for (int i = 0; i < Answer.Count; i++)
                    if (Answer[i].Text == "")
                        dem++;
                QLTD.MakeDeal(Turn - 1, "correct", dem);
                
                UpdatePoint();
                UpdateWholeAnswer();
            }
        }

        private void TimerWin_Tick(object sender, EventArgs e)
        {
            if(Start1 < Stop1)
            {
                Start1 += timerWin.Interval;
                labelTalk.Text = "Xin chúc mừng! Đáp án của bạn hoàn toàn chính xác, đó chính là " + ques.FullAnswer;
            }
            else
            {
                ContinueRound();
            }
        }

        private void ContinueRound()
        {
            timerWin.Stop();
            Start1 = 0F;
            
            DisappearArrow();
            DisappearMain();
            RecoverCharacter();

            for (int i = 0; i < Answer.Count; i++)
                flowLayoutPanelAnswer.Controls.Remove(Answer[i]);
            Answer.Clear();

            labelStart.Visible = true;
            if (Round == qd.NumberRound)
                labelStart.Text = "KEÁT THUÙC TROØ CHÔI";
            else
                labelStart.Text = "KEÁT THUÙC VOØNG " + Round;
            soundStart.Play();

            TimeCountDown = qd.TimeForAnswer;
            labelCountDown.Text = TimeCountDown.ToString();

            timerFinishRound.Start();
        }

        private void TimerFinishRound_Tick(object sender, EventArgs e)
        {
            if(Start1 < Stop1)
            {
                Start1 += timerFinishRound.Interval;
                labelStart.Visible = true;
                if (Round == qd.NumberRound)
                    labelStart.Text = "KEÁT THUÙC TROØ CHÔI";
                else
                    labelStart.Text = "KEÁT THUÙC VOØNG " + Round;
            }
            else
            {
                Round++;
                if(Round > qd.NumberRound)
                {
                    if(QLTD.ToExtraRound())
                    {
                        IsExtra = true;
                    }
                    else
                    {
                        QLTD.SaveResult();
                        this.Close();
                        Winner win = new Winner(parent, QLTD, QLTD.GetWinner(), wplayer);
                        win.Show();
                        //parent.Show();
                       // wplayer.controls.play();
                    }
                }
                AppearTopic();                
            }
        }

        private void rectangleShapeGuessCharacter_MouseClick(object sender, MouseEventArgs e)
        {
            soundButton.Play();
            DisappearWayToAnswer();
            GuessCharacter = true;
            labelTalk.Text = "Hãy xoay Chiếc Nón Kỳ Diệu!";
        }

        private void rectangleShapeGuessCharacter_MouseEnter(object sender, EventArgs e)
        {
            rectangleShapeGuessCharacter.BackColor = Color.White;
            rectangleShapeGuessCharacter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelGuessCharacter.BackColor = Color.White;
            labelGuessCharacter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void rectangleShapeGuessCharacter_MouseLeave(object sender, EventArgs e)
        {
            rectangleShapeGuessCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelGuessCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            labelGuessCharacter.ForeColor = Color.White;
            rectangleShapeGuessCharacter.BorderColor = Color.White;
        }

        private void pictureBoxCNKD_MouseClick(object sender, MouseEventArgs e)
        {
            if (!GuessCharacter)
                labelTalk.Text = "Hãy chọn cách trả lời câu hỏi là ĐOÁN CHỮ CÁI để xoay Chiếc Nón Kỳ Diệu!";
            else if(GuessCharacter && IsSpin)            
                labelTalk.Text = "Bạn hãy chọn chữ 1 cái để đoán đi nào!";           
            else
            {
                int speed = new Random().Next(30, 80);
                soundSpin.Play();
                while (speed > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int curAngle = Int32.Parse(pictureBoxCNKD.Tag.ToString());
                        pictureBoxCNKD.Image.Clone();
                        pictureBoxCNKD.Image = Spin.RotateImage(hinhChiecNon, new PointF((float)hinhChiecNon.Width / 2, (float)hinhChiecNon.Height / 2), curAngle + speed);

                        int angle = (curAngle + speed) % 360;
                        pictureBoxCNKD.Tag = angle.ToString();
                        pictureBoxCNKD.Refresh();
                    }
                    speed = speed - 1;
                }
                soundSpin.Stop();
                IsSpin = true;
                int check = Int32.Parse(pictureBoxCNKD.Tag.ToString());                
                Point = QLQN.GetPoint(check);
                //Point = "lucky";

                switch(Point)
                {
                    case "x2":
                        labelTalk.Text = "Xin chúc mừng! Bạn được nhân đôi số điểm hiện có! Xin mời bạn đoán chữ cái!";
                        QLTD.MakeDeal(Turn - 1, Point, Count);
                        UpdatePoint();
                        timerCountDown.Start();
                        IsDeal = true;
                        break;
                    case "miss":
                        do
                        {
                            Turn++;
                            if (Turn > Numplayer)
                                Turn = 1;
                        } while (QLTD.PlayerList().ListPLayer[Turn - 1].IsOut);
                       
                        DisappearArrow();
                        switch (Turn)
                        {
                            case 1:
                                pictureBoxArrowPlayer1.Visible = true;
                                break;
                            case 2:
                                pictureBoxArrowPlayer2.Visible = true;
                                break;
                            case 3:
                                pictureBoxArrowPlayer3.Visible = true;
                                break;
                            case 4:
                                pictureBoxArrowPlayer4.Visible = true;
                                break;
                        }
                        AppearWayToAnswer();

                        GuessCharacter = false;
                        IsSpin = false;
                        IsDeal = false;
                        MoreTurn = false;

                        labelTalk.Text = "Bạn mất lượt rồi! Đến lượt Người chơi " + Turn;
                        break;
                    case "lucky":
                        soundYay.Play();
                        Lucky lucky = new Lucky(Answer);
                        lucky.Show();

                        lucky.WhatPosition += Lucky_WhatPosition;
                        labelTalk.Text = "Chúc mừng! Bạn xoay vào ô may mắn, bạn được chọn 1 ô chữ cái để mở!";

                        GuessCharacter = false;
                        IsSpin = false;
                        IsDeal = false;
                        MoreTurn = false;

                        break;
                    case "zero":
                        labelTalk.Text = "Thật tiếc! Bạn đã mất hết số điểm hiện có rồi! Xin mời bạn đoán chữ cái!";
                        QLTD.MakeDeal(Turn - 1, Point, Count);
                        UpdatePoint();
                        timerCountDown.Start();

                        IsDeal = true;
                        break;
                    case "more":
                        labelTalk.Text = "Xin chúc mừng! Bạn có thêm 1 lượt chơi nữa! Xin mời bạn đoán chữ cái!";
                        MoreTurn = true;
                        timerCountDown.Start();
                        break;
                    case "/2":
                        labelTalk.Text = "Thật tiếc! Bạn vừa bị chia đôi số điểm hiện có rồi! Xin mời bạn đoán chữ cái!";
                        QLTD.MakeDeal(Turn - 1, Point, Count);
                        UpdatePoint();
                        timerCountDown.Start();
                        IsDeal = true;
                        break;
                    case "again":
                        IsSpin = false;
                        IsDeal = false;
                        MoreTurn = false;

                        labelTalk.Text = "Bạn vui lòng xoay lại Chiếc Nón Kỳ Diệu, vì chương trình không rõ mũi tên chỉ rõ mục nào trên chiếc nón!";
                        break;
                    default:
                        labelTalk.Text = Point + " Điểm! Hãy chọn chữ cái bạn muốn đoán!";
                        timerCountDown.Start();
                        break;
                }
            }
        }

        private void Lucky_WhatPosition(int index)
        {
            Answer[index].Text = ques.Answer[index].ToString();

            if (CheckFinishRound(Answer))
            {
                timerWin.Start();
                soundSuccess.Play();
                MoreTurn = false;
            }
            else
            {
                labelTalk.Text = "Xin mời Người chơi " + Turn;
                AppearWayToAnswer();
            }
        }

        private void buttonZ_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsSpin)
                labelTalk.Text = "Hãy Xoay Chiếc Nón Kỳ Diệu!";
            else
            {
                ((Button)sender).Enabled = false;
                soundAlphabet.Play();
                buttonText = ((Button)sender).Text[0];
                Count = 0;

                for (int i = 0; i < ques.Answer.Length; i++)
                    if (ques.Answer[i] == buttonText)
                        Count++;
                if (Count > 0)
                {
                    Inform = "Xin chúc mừng bạn! Có " + Count + " chữ " + buttonText + " trong đáp án!";
                    soundSuccess.Play();
                    MoreTurn = true;
                }
                else
                {
                    Inform = "Thật đáng tiếc! Không có chữ " + buttonText + " nào trong đáp án!";
                    soundFail.Play();
                }

                if (!IsDeal)
                {
                    QLTD.MakeDeal(Turn - 1, Point, Count);
                    UpdatePoint();
                }
                UpdateAnswer(buttonText);
                timerCountDown.Stop();
                timer1.Start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Start1 < Stop1)
            {
                Start1 += timer1.Interval;
                labelTalk.Text = Inform;
            }
            else
            {
                ContinueTurn();
            }
        }

        private void ContinueTurn()
        {
            Start1 = 0F;
            timer1.Stop();
           
            GuessCharacter = false;
            IsSpin = false;
            IsDeal = false;

            TimeCountDown = qd.TimeForAnswer;
            labelCountDown.Text = TimeCountDown.ToString();

            if (CheckFinishRound(Answer))
            {
                timerWin.Start();
                soundSuccess.Play();
                MoreTurn = false;
            }
            else
            {
                if (!MoreTurn)
                {
                    do
                    {
                        Turn++;
                        if (Turn > Numplayer)
                            Turn = 1;
                    } while (QLTD.PlayerList().ListPLayer[Turn - 1].IsOut);
                }                  
               
                labelTalk.Text = "Lượt Người Chơi " + Turn;
                DisappearArrow();
                switch (Turn)
                {
                    case 1:
                        pictureBoxArrowPlayer1.Visible = true;
                        break;
                    case 2:
                        pictureBoxArrowPlayer2.Visible = true;
                        break;
                    case 3:
                        pictureBoxArrowPlayer3.Visible = true;
                        break;
                    case 4:
                        pictureBoxArrowPlayer4.Visible = true;
                        break;
                }
                AppearWayToAnswer();
                MoreTurn = false;
            }   
        }

        private void UpdatePoint()
        {
            textBoxPointPlayer1.Text = QLTD.PlayerList().ListPLayer[0].Point.ToString();
            textBoxPointPlayer2.Text = QLTD.PlayerList().ListPLayer[1].Point.ToString();
            switch (Numplayer)
            {
                case 3:
                    textBoxPointPlayer3.Text = QLTD.PlayerList().ListPLayer[2].Point.ToString();
                    break;
                case 4:
                    textBoxPointPlayer3.Text = QLTD.PlayerList().ListPLayer[2].Point.ToString();
                    textBoxPointPlayer4.Text = QLTD.PlayerList().ListPLayer[3].Point.ToString();
                    break;
            }
        }

        private void UpdateAnswer(char x)
        {
            for (int i = 0; i < Answer.Count; i++)
                if (ques.Answer[i] == x)
                    Answer[i].Text = "" + x;
        }

        private void UpdateWholeAnswer()
        {
            for (int i = 0; i < Answer.Count; i++)
                if (Answer[i].Text == "")
                    Answer[i].Text = ques.Answer[i].ToString();
        }

        private void RecoverCharacter()
        {
            buttonA.Enabled= true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;
            buttonI.Enabled = true;
        }

        private void TimerCountDown_Tick(object sender, EventArgs e)
        {
            if(TimeCountDown > 0)
            {
                TimeCountDown--;
                labelCountDown.Text = TimeCountDown.ToString();
            }
            else
            {
                timerCountDown.Stop();
                TimeCountDown = qd.TimeForAnswer;
                labelCountDown.Text = TimeCountDown.ToString();
                soundFail.Play();
                if(guess != null)
                    guess.Close();

                do
                {
                    Turn++;
                    if (Turn > Numplayer)
                        Turn = 1;
                } while (QLTD.PlayerList().ListPLayer[Turn - 1].IsOut);
                
                labelTalk.Text = "Rất tiếc! Bạn đã hết thời gian trả lời, xin mời Người Chơi " + Turn;
                DisappearArrow();
                switch (Turn)
                {
                    case 1:
                        pictureBoxArrowPlayer1.Visible = true;
                        break;
                    case 2:
                        pictureBoxArrowPlayer2.Visible = true;
                        break;
                    case 3:
                        pictureBoxArrowPlayer3.Visible = true;
                        break;
                    case 4:
                        pictureBoxArrowPlayer4.Visible = true;
                        break;
                }
                AppearWayToAnswer();
            }
        }
    }
}
