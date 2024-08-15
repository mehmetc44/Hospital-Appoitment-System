using RandevuSistem.ModernElements;
namespace RandevuSistem
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            panel1 = new Panel();
            button3 = new ModernButton();
            button4 = new ModernButton();
            label7 = new Label();
            textBox5 = new ModernTextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            textBox4 = new ModernTextBox();
            label2 = new Label();
            textBox2 = new ModernTextBox();
            label1 = new Label();
            textBox1 = new ModernTextBox();
            button1 = new ModernButton();
            button2 = new ModernButton();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(50, 52, 77);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 663);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.BorderColor = Color.Transparent;
            button3.BorderRadius = 20;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(710, 602);
            button3.Name = "button3";
            button3.SelectionColor = Color.Red;
            button3.Size = new Size(183, 57);
            button3.TabIndex = 72;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.BorderColor = Color.Transparent;
            button4.BorderRadius = 20;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(510, 605);
            button4.Name = "button4";
            button4.SelectionColor = Color.Red;
            button4.Size = new Size(183, 57);
            button4.TabIndex = 71;
            button4.Text = "İptal";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(455, 391);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 70;
            label7.Text = "Cinsiyet:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(39, 39, 58);
            textBox5.BackgroundColor = Color.FromArgb(39, 39, 58);
            textBox5.BorderColor = Color.Gray;
            textBox5.BorderRadius = 15;
            textBox5.BorderSize = 2;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = Color.FromArgb(0, 126, 249);
            textBox5.Location = new Point(455, 432);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(342, 39);
            textBox5.TabIndex = 69;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(39, 39, 58);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.FromArgb(0, 126, 249);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(53, 432);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(342, 39);
            comboBox1.TabIndex = 68;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(53, 391);
            label6.Name = "label6";
            label6.Size = new Size(117, 28);
            label6.TabIndex = 67;
            label6.Text = "Kan Grubu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(455, 282);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 64;
            label5.Text = "Telefon No:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(39, 39, 58);
            textBox4.BackgroundColor = Color.FromArgb(39, 39, 58);
            textBox4.BorderColor = Color.Gray;
            textBox4.BorderRadius = 15;
            textBox4.BorderSize = 2;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.FromArgb(0, 126, 249);
            textBox4.Location = new Point(455, 325);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(342, 39);
            textBox4.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(455, 182);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 62;
            label2.Text = "TC Kimlik No:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(39, 39, 58);
            textBox2.BackgroundColor = Color.FromArgb(39, 39, 58);
            textBox2.BorderColor = Color.White;
            textBox2.BorderRadius = 15;
            textBox2.BorderSize = 2;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(0, 126, 249);
            textBox2.Location = new Point(455, 225);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(342, 39);
            textBox2.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(455, 84);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 60;
            label1.Text = "Ad-Soyad:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(39, 39, 58);
            textBox1.BackgroundColor = Color.FromArgb(39, 39, 58);
            textBox1.BorderColor = Color.White;
            textBox1.BorderRadius = 15;
            textBox1.BorderSize = 10;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 126, 249);
            textBox1.Location = new Point(455, 127);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(342, 39);
            textBox1.TabIndex = 59;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.BorderColor = Color.Transparent;
            button1.BorderRadius = 20;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(510, 530);
            button1.Name = "button1";
            button1.SelectionColor = Color.Red;
            button1.Size = new Size(183, 57);
            button1.TabIndex = 58;
            button1.Text = "Şifre Yenile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.BorderColor = Color.Transparent;
            button2.BorderRadius = 20;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(120, 530);
            button2.Name = "button2";
            button2.SelectionColor = Color.Red;
            button2.Size = new Size(188, 57);
            button2.TabIndex = 55;
            button2.Text = "Bilgileri Güncelle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Profil
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "Profil";
            Size = new Size(917, 573);
            Load += Profil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private ModernButton button1;
        private ModernButton button2;
        private PictureBox pictureBox1;
        private Label label1;
        private ModernTextBox textBox1;
        private Label label5;
        private ModernTextBox textBox4;
        private Label label2;
        private ModernTextBox textBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private ModernTextBox textBox5;
        private VScrollBar vScrollBar1;
        private ModernButton button3;
        private ModernButton button4;
    }
}
