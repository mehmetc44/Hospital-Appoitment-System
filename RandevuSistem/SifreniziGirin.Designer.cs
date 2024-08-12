namespace RandevuSistem
{
    partial class SifreniziGirin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreniziGirin));
            panel1 = new Panel();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 750);
            panel1.TabIndex = 60;
            panel1.Paint += panel1_Paint;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(240, 301);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(381, 27);
            textBox3.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(240, 265);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 62;
            label2.Text = "Yeni şifreniz(Tekrar)\n";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(240, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 27);
            textBox2.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(240, 188);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 60;
            label3.Text = "Yeni şifreniz:\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(16, 26);
            button1.Name = "button1";
            button1.Size = new Size(62, 63);
            button1.TabIndex = 58;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(240, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 27);
            textBox1.TabIndex = 54;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(342, 394);
            button2.Name = "button2";
            button2.Size = new Size(176, 61);
            button2.TabIndex = 57;
            button2.Text = "Onayla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(240, 94);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 55;
            label1.Text = "Şu anki şifreniz:\r\n";
            // 
            // SifreniziGirin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SifreniziGirin";
            Size = new Size(1200, 750);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
    }
}
