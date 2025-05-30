using RandevuSistem.ModernElements;

namespace RandevuSistem
{
    partial class RandevularımGB
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevularımGB));
            groupBox1 = new GroupBox();
            RandevuIptalButon = new ModernButton();
            label4 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = Color.FromArgb(39, 39, 58);
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(RandevuIptalButon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 160);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hastane Adı 1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // RandevuIptalButon
            // 
            RandevuIptalButon.BackColor = Color.Red;
            RandevuIptalButon.BorderColor = Color.Transparent;
            RandevuIptalButon.BorderRadius = 20;
            RandevuIptalButon.FlatAppearance.BorderSize = 0;
            RandevuIptalButon.FlatStyle = FlatStyle.Flat;
            RandevuIptalButon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RandevuIptalButon.ForeColor = Color.White;
            RandevuIptalButon.Location = new Point(549, 65);
            RandevuIptalButon.Name = "RandevuIptalButon";
            RandevuIptalButon.SelectionColor = Color.Red;
            RandevuIptalButon.Size = new Size(138, 45);
            RandevuIptalButon.TabIndex = 72;
            RandevuIptalButon.Text = "İptal";
            RandevuIptalButon.UseVisualStyleBackColor = false;
            RandevuIptalButon.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkTurquoise;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(325, 103);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 9;
            label4.Text = "Şehir:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkTurquoise;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(325, 50);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 8;
            label3.Text = "Tarih:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(279, 93);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(279, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(52, 103);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 5;
            label2.Text = "Klinik:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 93);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkTurquoise;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(52, 50);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 2;
            label1.Text = "Doktor:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(122, 52);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 73;
            label5.Text = "Mehmet Çakmak";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(114, 105);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 74;
            label6.Text = "KBB";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.ImageAlign = ContentAlignment.MiddleRight;
            label7.Location = new Point(377, 52);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 75;
            label7.Text = "15/07/2004";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(381, 106);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 76;
            label8.Text = "Malatya";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RandevularımGB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "RandevularımGB";
            Size = new Size(725, 160);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox groupBox1;
        public PictureBox pictureBox1;
        public Label label1;
        public PictureBox pictureBox2;
        public PictureBox pictureBox4;
        public PictureBox pictureBox3;
        public Label label2;
        public Label label4;
        public Label label3;
        public ModernButton RandevuIptalButon;
        public Label label5;
        public Label label8;
        public Label label7;
        public Label label6;
    }
}
