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
            label1 = new Label();
            button2 = new Button();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            button1 = new Button();
            modernButton1 = new ModernElements.ModernButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(691, 119);
            label1.Name = "label1";
            label1.Size = new Size(168, 35);
            label1.TabIndex = 71;
            label1.Text = "TC Kimlik No";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(364, 593);
            button2.Name = "button2";
            button2.Size = new Size(136, 38);
            button2.TabIndex = 70;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0-", "0+" });
            comboBox2.Location = new Point(152, 484);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(348, 28);
            comboBox2.TabIndex = 69;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(691, 479);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(365, 27);
            textBox5.TabIndex = 78;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(166, 433);
            label6.Name = "label6";
            label6.Size = new Size(140, 35);
            label6.TabIndex = 68;
            label6.Text = "Kan Grubu";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(691, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 27);
            textBox1.TabIndex = 72;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kadın", "Erkek" });
            comboBox1.Location = new Point(152, 375);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 28);
            comboBox1.TabIndex = 67;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(691, 428);
            label8.Name = "label8";
            label8.Size = new Size(162, 35);
            label8.TabIndex = 77;
            label8.Text = "Şifre(Tekrar)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(152, 282);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 66;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(691, 226);
            label4.Name = "label4";
            label4.Size = new Size(175, 35);
            label4.TabIndex = 73;
            label4.Text = "Tel. Numarası";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(166, 325);
            label5.Name = "label5";
            label5.Size = new Size(108, 35);
            label5.TabIndex = 65;
            label5.Text = "Cinsiyet";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(691, 371);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(365, 27);
            textBox4.TabIndex = 76;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(166, 231);
            label3.Name = "label3";
            label3.Size = new Size(173, 35);
            label3.TabIndex = 64;
            label3.Text = "Doğum Tarihi";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(691, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 27);
            textBox2.TabIndex = 74;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(152, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(348, 27);
            textBox3.TabIndex = 63;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(691, 320);
            label7.Name = "label7";
            label7.Size = new Size(70, 35);
            label7.TabIndex = 75;
            label7.Text = "Şifre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(166, 120);
            label2.Name = "label2";
            label2.Size = new Size(128, 35);
            label2.TabIndex = 62;
            label2.Text = "Ad-Soyad";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(152, 593);
            button1.Name = "button1";
            button1.Size = new Size(136, 38);
            button1.TabIndex = 61;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // modernButton1
            // 
            modernButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            modernButton1.BackColor = Color.Transparent;
            modernButton1.BackgroundImage = (Image)resources.GetObject("modernButton1.BackgroundImage");
            modernButton1.BackgroundImageLayout = ImageLayout.Stretch;
            modernButton1.BorderColor = Color.Transparent;
            modernButton1.BorderRadius = 30;
            modernButton1.FlatAppearance.BorderColor = Color.Yellow;
            modernButton1.FlatAppearance.BorderSize = 0;
            modernButton1.FlatStyle = FlatStyle.Flat;
            modernButton1.Location = new Point(40, 25);
            modernButton1.Margin = new Padding(0);
            modernButton1.Name = "modernButton1";
            modernButton1.SelectionColor = Color.Red;
            modernButton1.Size = new Size(42, 48);
            modernButton1.TabIndex = 79;
            modernButton1.UseVisualStyleBackColor = false;
            modernButton1.Click += modernButton1_Click;
            modernButton1.MouseEnter += modernButton1_MouseEnter;
            modernButton1.MouseLeave += modernButton1_MouseLeave;
            // 
            // Kayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(modernButton1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Kayıt";
            Size = new Size(1208, 750);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private Label label2;
        private Button button1;
        private ModernElements.ModernButton modernButton1;
    }
}
