namespace ChiecNonKyDieu.GUI
{
    partial class NumberPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.rectangleShape2Player = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShapeNext = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShapeBack = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4Player = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3Player = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2Player = new System.Windows.Forms.Label();
            this.label3Player = new System.Windows.Forms.Label();
            this.label4Player = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("VNI-Fato", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 108);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHOÏN SOÁ NGÖÔØI CHÔI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rectangleShape2Player
            // 
            this.rectangleShape2Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rectangleShape2Player.BackColor = System.Drawing.Color.DodgerBlue;
            this.rectangleShape2Player.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2Player.BorderColor = System.Drawing.Color.Yellow;
            this.rectangleShape2Player.BorderWidth = 4;
            this.rectangleShape2Player.CornerRadius = 31;
            this.rectangleShape2Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape2Player.Location = new System.Drawing.Point(485, 160);
            this.rectangleShape2Player.Name = "rectangleShape2Player";
            this.rectangleShape2Player.Size = new System.Drawing.Size(390, 63);
            this.rectangleShape2Player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShape2Player_MouseClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShapeNext,
            this.rectangleShapeBack,
            this.rectangleShape4Player,
            this.rectangleShape3Player,
            this.rectangleShape2Player});
            this.shapeContainer1.Size = new System.Drawing.Size(1350, 729);
            this.shapeContainer1.TabIndex = 7;
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
            this.rectangleShapeNext.Enabled = false;
            this.rectangleShapeNext.Location = new System.Drawing.Point(1100, 643);
            this.rectangleShapeNext.Name = "rectangleShapeNext";
            this.rectangleShapeNext.Size = new System.Drawing.Size(203, 55);
            this.rectangleShapeNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeNext_MouseClick);
            this.rectangleShapeNext.MouseEnter += new System.EventHandler(this.rectangleShapeNext_MouseEnter);
            this.rectangleShapeNext.MouseLeave += new System.EventHandler(this.rectangleShapeNext_MouseLeave);
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
            // rectangleShape4Player
            // 
            this.rectangleShape4Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rectangleShape4Player.BackColor = System.Drawing.Color.DodgerBlue;
            this.rectangleShape4Player.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape4Player.BorderColor = System.Drawing.Color.Yellow;
            this.rectangleShape4Player.BorderWidth = 4;
            this.rectangleShape4Player.CornerRadius = 31;
            this.rectangleShape4Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape4Player.Location = new System.Drawing.Point(485, 516);
            this.rectangleShape4Player.Name = "rectangleShape4Player";
            this.rectangleShape4Player.Size = new System.Drawing.Size(390, 63);
            this.rectangleShape4Player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShape4Player_MouseClick);
            // 
            // rectangleShape3Player
            // 
            this.rectangleShape3Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rectangleShape3Player.BackColor = System.Drawing.Color.DodgerBlue;
            this.rectangleShape3Player.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape3Player.BorderColor = System.Drawing.Color.Yellow;
            this.rectangleShape3Player.BorderWidth = 4;
            this.rectangleShape3Player.CornerRadius = 31;
            this.rectangleShape3Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShape3Player.Location = new System.Drawing.Point(485, 328);
            this.rectangleShape3Player.Name = "rectangleShape3Player";
            this.rectangleShape3Player.Size = new System.Drawing.Size(390, 63);
            this.rectangleShape3Player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShape3Player_MouseClick);
            // 
            // label2Player
            // 
            this.label2Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2Player.AutoSize = true;
            this.label2Player.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Player.ForeColor = System.Drawing.Color.Yellow;
            this.label2Player.Location = new System.Drawing.Point(555, 173);
            this.label2Player.Name = "label2Player";
            this.label2Player.Size = new System.Drawing.Size(265, 39);
            this.label2Player.TabIndex = 8;
            this.label2Player.Text = "2 NGƯỜI CHƠI";
            this.label2Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2Player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShape2Player_MouseClick);
            // 
            // label3Player
            // 
            this.label3Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3Player.AutoSize = true;
            this.label3Player.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Player.ForeColor = System.Drawing.Color.Yellow;
            this.label3Player.Location = new System.Drawing.Point(555, 343);
            this.label3Player.Name = "label3Player";
            this.label3Player.Size = new System.Drawing.Size(265, 39);
            this.label3Player.TabIndex = 8;
            this.label3Player.Text = "3 NGƯỜI CHƠI";
            this.label3Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3Player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShape3Player_MouseClick);
            // 
            // label4Player
            // 
            this.label4Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4Player.AutoSize = true;
            this.label4Player.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4Player.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Player.ForeColor = System.Drawing.Color.Yellow;
            this.label4Player.Location = new System.Drawing.Point(555, 529);
            this.label4Player.Name = "label4Player";
            this.label4Player.Size = new System.Drawing.Size(265, 39);
            this.label4Player.TabIndex = 8;
            this.label4Player.Text = "4 NGƯỜI CHƠI";
            this.label4Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4Player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShape4Player_MouseClick);
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
            this.labelBack.TabIndex = 9;
            this.labelBack.Text = "Quay Lại";
            this.labelBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeBack_MouseClick);
            this.labelBack.MouseEnter += new System.EventHandler(this.rectangleShapeBack_MouseEnter);
            // 
            // labelNext
            // 
            this.labelNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNext.AutoSize = true;
            this.labelNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNext.Enabled = false;
            this.labelNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNext.ForeColor = System.Drawing.Color.Yellow;
            this.labelNext.Location = new System.Drawing.Point(1120, 654);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(155, 33);
            this.labelNext.TabIndex = 9;
            this.labelNext.Text = "Tiếp Theo";
            this.labelNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeNext_MouseClick);
            this.labelNext.MouseEnter += new System.EventHandler(this.rectangleShapeNext_MouseEnter);
            // 
            // NumberPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChiecNonKyDieu.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.labelNext);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.label4Player);
            this.Controls.Add(this.label3Player);
            this.Controls.Add(this.label2Player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumberPlayer";
            this.Text = "NumberPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2Player;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4Player;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3Player;
        private System.Windows.Forms.Label label2Player;
        private System.Windows.Forms.Label label3Player;
        private System.Windows.Forms.Label label4Player;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapeBack;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapeNext;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelNext;
    }
}