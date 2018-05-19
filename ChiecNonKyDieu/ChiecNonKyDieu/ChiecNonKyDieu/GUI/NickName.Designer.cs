namespace ChiecNonKyDieu.GUI
{
    partial class NickName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NickName));
            this.label1 = new System.Windows.Forms.Label();
            this.rectangleShapeBack = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShapeNext = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.labelAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("VNI-Fato", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(928, 108);
            this.label1.TabIndex = 7;
            this.label1.Text = "NHAÄP TEÂN NGÖÔØI CHÔI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rectangleShapeBack
            // 
            this.rectangleShapeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rectangleShapeBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.rectangleShapeBack.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShapeBack.BorderColor = System.Drawing.Color.Yellow;
            this.rectangleShapeBack.BorderWidth = 4;
            this.rectangleShapeBack.CornerRadius = 26;
            this.rectangleShapeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShapeBack.Location = new System.Drawing.Point(68, 643);
            this.rectangleShapeBack.Name = "rectangleShapeBack";
            this.rectangleShapeBack.Size = new System.Drawing.Size(203, 55);
            this.rectangleShapeBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeBack_MouseClick);
            this.rectangleShapeBack.MouseEnter += new System.EventHandler(this.rectangleShapeBack_MouseEnter);
            this.rectangleShapeBack.MouseLeave += new System.EventHandler(this.rectangleShapeBack_MouseLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShapeNext,
            this.rectangleShapeBack});
            this.shapeContainer1.Size = new System.Drawing.Size(1350, 729);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShapeNext
            // 
            this.rectangleShapeNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rectangleShapeNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.rectangleShapeNext.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShapeNext.BorderColor = System.Drawing.Color.Yellow;
            this.rectangleShapeNext.BorderWidth = 4;
            this.rectangleShapeNext.CornerRadius = 26;
            this.rectangleShapeNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShapeNext.Location = new System.Drawing.Point(1100, 643);
            this.rectangleShapeNext.Name = "rectangleShapeNext";
            this.rectangleShapeNext.Size = new System.Drawing.Size(203, 55);
            this.rectangleShapeNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeNext_MouseClick);
            this.rectangleShapeNext.MouseEnter += new System.EventHandler(this.rectangleShapeNext_MouseEnter);
            this.rectangleShapeNext.MouseLeave += new System.EventHandler(this.rectangleShapeNext_MouseLeave);
            // 
            // labelBack
            // 
            this.labelBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.Yellow;
            this.labelBack.Location = new System.Drawing.Point(102, 654);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(140, 33);
            this.labelBack.TabIndex = 10;
            this.labelBack.Text = "Quay Lại";
            this.labelBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeBack_MouseClick);
            // 
            // labelNext
            // 
            this.labelNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNext.AutoSize = true;
            this.labelNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNext.ForeColor = System.Drawing.Color.Yellow;
            this.labelNext.Location = new System.Drawing.Point(1120, 654);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(155, 33);
            this.labelNext.TabIndex = 11;
            this.labelNext.Text = "Tiếp Theo";
            this.labelNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeNext_MouseClick);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.Color.Yellow;
            this.labelPlayer1.Location = new System.Drawing.Point(273, 155);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(314, 55);
            this.labelPlayer1.TabIndex = 12;
            this.labelPlayer1.Text = "Người Chơi 1";
            this.labelPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer1.Location = new System.Drawing.Point(641, 155);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(438, 49);
            this.textBoxPlayer1.TabIndex = 1;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.ForeColor = System.Drawing.Color.Yellow;
            this.labelPlayer2.Location = new System.Drawing.Point(273, 288);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(314, 55);
            this.labelPlayer2.TabIndex = 12;
            this.labelPlayer2.Text = "Người Chơi 2";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer2.Location = new System.Drawing.Point(641, 288);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(438, 49);
            this.textBoxPlayer2.TabIndex = 2;
            // 
            // labelAlert
            // 
            this.labelAlert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelAlert.BackColor = System.Drawing.Color.Transparent;
            this.labelAlert.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlert.ForeColor = System.Drawing.Color.Yellow;
            this.labelAlert.Location = new System.Drawing.Point(302, 662);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(777, 37);
            this.labelAlert.TabIndex = 14;
            this.labelAlert.Text = "Hãy Nhập Nickname Khác Nhau!";
            this.labelAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NickName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChiecNonKyDieu.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelNext);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NickName";
            this.Text = "NickName";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NickName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapeBack;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label labelBack;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapeNext;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Label labelAlert;
    }
}