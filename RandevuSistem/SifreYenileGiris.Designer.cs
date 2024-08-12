namespace RandevuSistem
{
    partial class SifreYenileGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreYenileGiris));
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 750);
            panel1.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(389, 195);
            label2.Name = "label2";
            label2.Size = new Size(414, 40);
            label2.TabIndex = 56;
            label2.Text = "Telefonunuza SMS ile gelen kodu aşşağıdaki kutucuğa giriniz \r\n ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            textBox1.Location = new Point(422, 430);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 27);
            textBox1.TabIndex = 54;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(529, 502);
            button2.Name = "button2";
            button2.Size = new Size(176, 61);
            button2.TabIndex = 57;
            button2.Text = "Onayla";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(422, 395);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 55;
            label1.Text = "SMS Kodu:";
            // 
            // SifreYenileGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SifreYenileGiris";
            Size = new Size(1200, 750);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
    }
}
