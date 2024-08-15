using RandevuSistem.ModernElements;
namespace RandevuSistem
{
    partial class SifreDegistirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistirme));
            textBox1 = new ModernTextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new ModernButton();
            button1 = new ModernButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.BackgroundColor = Color.White;
            textBox1.BorderColor = Color.Gray;
            textBox1.BorderRadius = 15;
            textBox1.BorderSize = 2;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(396, 412);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "T.C. Kimlik No";
            textBox1.Size = new Size(381, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(396, 377);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik No:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Microsoft Sans Serif", 12.7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(310, 220);
            label2.Name = "label2";
            label2.Size = new Size(643, 93);
            label2.TabIndex = 3;
            label2.Text = "Lütfen TC kimlik numaranızı giriniz. Sonrasında \"SMS Gönder\" butonuna tıklayıp\r\nsms olarak gelen kodu girerek şifrenizi değiştirebilirsiniz.\r\n ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.RoyalBlue;
            button2.BorderColor = Color.Transparent;
            button2.BorderRadius = 20;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(503, 484);
            button2.Name = "button2";
            button2.SelectionColor = Color.Red;
            button2.Size = new Size(176, 61);
            button2.TabIndex = 4;
            button2.Text = "Giriş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.BorderColor = Color.Transparent;
            button1.BorderRadius = 30;
            button1.FlatAppearance.BorderColor = Color.Yellow;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(40, 25);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.SelectionColor = Color.Red;
            button1.Size = new Size(42, 48);
            button1.TabIndex = 80;
            button1.UseVisualStyleBackColor = false;
            button1.Click += modernButton1_Click;
            // 
            // SifreDegistirme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "SifreDegistirme";
            Size = new Size(1200, 750);
            Load += SifreDegistirme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ModernTextBox textBox1;
        private Label label1;
        private Label label2;
        private ModernButton button2;
        private ModernButton button1;
    }
}
