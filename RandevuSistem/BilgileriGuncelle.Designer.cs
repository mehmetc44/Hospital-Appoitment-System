namespace RandevuSistem
{
    partial class BilgileriGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgileriGuncelle));
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            randevubuton = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(randevubuton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 1091);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(432, 883);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 28);
            comboBox2.TabIndex = 62;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(430, 821);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 27);
            textBox3.TabIndex = 60;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(430, 758);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 59;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(430, 695);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 58;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(430, 443);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 57;
            label4.Click += label4_Click;
            // 
            // randevubuton
            // 
            randevubuton.BackColor = Color.MediumTurquoise;
            randevubuton.FlatStyle = FlatStyle.Flat;
            randevubuton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            randevubuton.Location = new Point(351, 986);
            randevubuton.Name = "randevubuton";
            randevubuton.Size = new Size(231, 57);
            randevubuton.TabIndex = 55;
            randevubuton.Text = "Bilgileri Güncelle";
            randevubuton.UseVisualStyleBackColor = false;
            randevubuton.Click += randevubuton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(12, 16);
            button2.Name = "button2";
            button2.Size = new Size(64, 55);
            button2.TabIndex = 53;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Turquoise;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-128, 381);
            label3.Name = "label3";
            label3.Size = new Size(1171, 46);
            label3.TabIndex = 3;
            label3.Text = "                                                   Kişisel Bilgiler                                                    ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(252, 443);
            label2.Name = "label2";
            label2.Size = new Size(160, 465);
            label2.TabIndex = 2;
            label2.Text = "Ad-Soyad:\r\n\r\nTC Kimlik No:\r\n\r\nYaş:\r\n\r\nCinsiyet:\r\n\r\nBoy:\r\n\r\nKilo:\r\n\r\nTel. No:\r\n\r\nKan Grubu:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 44);
            label1.Name = "label1";
            label1.Size = new Size(471, 41);
            label1.TabIndex = 1;
            label1.Text = "Sağlıklı Günler Mehmet Çakmak";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(351, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BilgileriGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Name = "BilgileriGuncelle";
            Size = new Size(879, 529);
            Load += BilgileriGuncelle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button randevubuton;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox2;
    }
}
