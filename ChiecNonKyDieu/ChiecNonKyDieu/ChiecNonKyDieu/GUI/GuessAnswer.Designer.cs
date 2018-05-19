namespace ChiecNonKyDieu.GUI
{
    partial class GuessAnswer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessAnswer));
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.rectangleShapeAccept = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.labelAccept = new System.Windows.Forms.Label();
            this.labelTalk = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(241, 345);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(291, 31);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnswer_KeyPress);
            // 
            // rectangleShapeAccept
            // 
            this.rectangleShapeAccept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rectangleShapeAccept.BackColor = System.Drawing.Color.Khaki;
            this.rectangleShapeAccept.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShapeAccept.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rectangleShapeAccept.BorderWidth = 4;
            this.rectangleShapeAccept.CornerRadius = 17;
            this.rectangleShapeAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShapeAccept.Location = new System.Drawing.Point(310, 390);
            this.rectangleShapeAccept.Name = "rectangleShapeAccept";
            this.rectangleShapeAccept.Size = new System.Drawing.Size(146, 37);
            this.rectangleShapeAccept.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeAccept_MouseClick);
            this.rectangleShapeAccept.MouseEnter += new System.EventHandler(this.rectangleShapeAccept_MouseEnter);
            this.rectangleShapeAccept.MouseLeave += new System.EventHandler(this.rectangleShapeAccept_MouseLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShapeAccept});
            this.shapeContainer1.Size = new System.Drawing.Size(763, 453);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // labelAccept
            // 
            this.labelAccept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAccept.AutoSize = true;
            this.labelAccept.BackColor = System.Drawing.Color.Khaki;
            this.labelAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAccept.Location = new System.Drawing.Point(343, 396);
            this.labelAccept.Name = "labelAccept";
            this.labelAccept.Size = new System.Drawing.Size(86, 25);
            this.labelAccept.TabIndex = 6;
            this.labelAccept.Text = "Đồng ý";
            this.labelAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAccept.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeAccept_MouseClick);
            // 
            // labelTalk
            // 
            this.labelTalk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTalk.BackColor = System.Drawing.Color.White;
            this.labelTalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTalk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTalk.Location = new System.Drawing.Point(220, 36);
            this.labelTalk.Name = "labelTalk";
            this.labelTalk.Size = new System.Drawing.Size(413, 100);
            this.labelTalk.TabIndex = 7;
            this.labelTalk.Text = resources.GetString("labelTalk.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ChiecNonKyDieu.Properties.Resources.talk2;
            this.pictureBox2.Location = new System.Drawing.Point(153, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(568, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChiecNonKyDieu.Properties.Resources.cool;
            this.pictureBox1.Location = new System.Drawing.Point(3, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GuessAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(763, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTalk);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelAccept);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuessAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessAnswer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnswer;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapeAccept;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label labelAccept;
        private System.Windows.Forms.Label labelTalk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}