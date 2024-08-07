namespace RandevuSistem
{
    partial class Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt));
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0-", "0+" });
            comboBox2.Location = new Point(100, 383);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(348, 28);
            comboBox2.TabIndex = 50;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(114, 332);
            label6.Name = "label6";
            label6.Size = new Size(140, 35);
            label6.TabIndex = 49;
            label6.Text = "Kan Grubu";
            label6.Click += label6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kadın", "Erkek" });
            comboBox1.Location = new Point(100, 274);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 28);
            comboBox1.TabIndex = 48;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(100, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 47;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(114, 224);
            label5.Name = "label5";
            label5.Size = new Size(108, 35);
            label5.TabIndex = 46;
            label5.Text = "Cinsiyet";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(114, 130);
            label3.Name = "label3";
            label3.Size = new Size(173, 35);
            label3.TabIndex = 45;
            label3.Text = "Doğum Tarihi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(100, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(348, 27);
            textBox3.TabIndex = 44;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(114, 19);
            label2.Name = "label2";
            label2.Size = new Size(128, 35);
            label2.TabIndex = 43;
            label2.Text = "Ad-Soyad";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(383, 450);
            button1.Name = "button1";
            button1.Size = new Size(136, 38);
            button1.TabIndex = 42;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(64, 55);
            button2.TabIndex = 52;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(499, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 27);
            textBox1.TabIndex = 54;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(499, 23);
            label1.Name = "label1";
            label1.Size = new Size(168, 35);
            label1.TabIndex = 53;
            label1.Text = "TC Kimlik No";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(499, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 27);
            textBox2.TabIndex = 56;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(499, 130);
            label4.Name = "label4";
            label4.Size = new Size(175, 35);
            label4.TabIndex = 55;
            label4.Text = "Tel. Numarası";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(499, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(365, 27);
            textBox4.TabIndex = 58;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(499, 224);
            label8.Name = "label8";
            label8.Size = new Size(70, 35);
            label8.TabIndex = 57;
            label8.Text = "Şifre";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(499, 383);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(365, 27);
            textBox5.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(499, 332);
            label9.Name = "label9";
            label9.Size = new Size(162, 35);
            label9.TabIndex = 59;
            label9.Text = "Şifre(Tekrar)";
            // 
            // Kayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Kayıt";
            Size = new Size(900, 550);
            Load += Kayıt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
    }
}
