namespace ChiecNonKyDieu.GUI
{
    partial class Rank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rank));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRank = new System.Windows.Forms.ListBox();
            this.rectangleShapeBack = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.labelBack = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxRank2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("VNI-Fato", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 108);
            this.label1.TabIndex = 5;
            this.label1.Text = "BAÛNG XEÁP HAÏNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxRank
            // 
            this.listBoxRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRank.BackColor = System.Drawing.Color.DodgerBlue;
            this.listBoxRank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRank.ForeColor = System.Drawing.Color.Yellow;
            this.listBoxRank.FormattingEnabled = true;
            this.listBoxRank.ItemHeight = 39;
            this.listBoxRank.Items.AddRange(new object[] {
            "Tên Người Chơi"});
            this.listBoxRank.Location = new System.Drawing.Point(336, 142);
            this.listBoxRank.Name = "listBoxRank";
            this.listBoxRank.Size = new System.Drawing.Size(443, 468);
            this.listBoxRank.TabIndex = 6;
            // 
            // rectangleShapeBack
            // 
            this.rectangleShapeBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rectangleShapeBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.rectangleShapeBack.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShapeBack.BorderColor = System.Drawing.Color.Yellow;
            this.rectangleShapeBack.BorderWidth = 4;
            this.rectangleShapeBack.CornerRadius = 26;
            this.rectangleShapeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleShapeBack.Location = new System.Drawing.Point(497, 649);
            this.rectangleShapeBack.Name = "rectangleShapeBack";
            this.rectangleShapeBack.Size = new System.Drawing.Size(421, 63);
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
            this.rectangleShapeBack});
            this.shapeContainer1.Size = new System.Drawing.Size(1366, 768);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // labelBack
            // 
            this.labelBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.Yellow;
            this.labelBack.Location = new System.Drawing.Point(634, 660);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(163, 39);
            this.labelBack.TabIndex = 9;
            this.labelBack.Text = "Quay Lại";
            this.labelBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangleShapeBack_MouseClick);
            this.labelBack.MouseEnter += new System.EventHandler(this.rectangleShapeBack_MouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ChiecNonKyDieu.Properties.Resources.imageedit_1_7906187128;
            this.pictureBox3.Location = new System.Drawing.Point(79, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ChiecNonKyDieu.Properties.Resources.d8b43b779e8d4cde4f694ade86b0b65357c10323_hq;
            this.pictureBox1.Location = new System.Drawing.Point(1125, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxRank2
            // 
            this.listBoxRank2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRank2.BackColor = System.Drawing.Color.DodgerBlue;
            this.listBoxRank2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRank2.ForeColor = System.Drawing.Color.Yellow;
            this.listBoxRank2.FormattingEnabled = true;
            this.listBoxRank2.ItemHeight = 39;
            this.listBoxRank2.Items.AddRange(new object[] {
            "Số Điểm"});
            this.listBoxRank2.Location = new System.Drawing.Point(771, 142);
            this.listBoxRank2.Name = "listBoxRank2";
            this.listBoxRank2.Size = new System.Drawing.Size(298, 468);
            this.listBoxRank2.TabIndex = 6;
            // 
            // Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ChiecNonKyDieu.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.listBoxRank2);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rank";
            this.Text = "Rank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRank;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShapeBack;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxRank2;
    }
}