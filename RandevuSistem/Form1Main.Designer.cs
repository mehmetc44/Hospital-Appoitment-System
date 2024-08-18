using RandevuSistem.ModernElements;
namespace RandevuSistem
{
    partial class Form1Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Main));
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            textBox1 = new ModernTextBox();
            button1 = new ModernButton();
            textBox2 = new ModernTextBox();
            panel1 = new ModernPanel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Transparent;
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.DisabledLinkColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.ForeColor = SystemColors.Control;
            linkLabel2.LinkColor = Color.Gainsboro;
            linkLabel2.Location = new Point(53, 503);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(64, 20);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Kayıt Ol";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.LightGray;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.DisabledLinkColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Gray;
            linkLabel1.LinkColor = Color.Gainsboro;
            linkLabel1.Location = new Point(363, 503);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.BackgroundColor = Color.White;
            textBox1.BorderColor = Color.Black;
            textBox1.BorderRadius = 30;
            textBox1.BorderSize = 2;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(84, 286);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "TC Kimlik No";
            textBox1.Size = new Size(338, 36);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.RoyalBlue;
            button1.BorderColor = Color.Transparent;
            button1.BorderRadius = 20;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(181, 427);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.SelectionColor = Color.Red;
            button1.Size = new Size(165, 36);
            button1.TabIndex = 8;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.White;
            textBox2.BackgroundColor = Color.White;
            textBox2.BorderColor = Color.Gray;
            textBox2.BorderRadius = 15;
            textBox2.BorderSize = 2;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(84, 339);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Şifre";
            textBox2.Size = new Size(338, 36);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(50, 52, 77);
            panel1.BorderRadius = 30;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 750);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(123, 54);
            label2.Name = "label2";
            label2.Size = new Size(246, 106);
            label2.TabIndex = 11;
            label2.Text = "MedikApp";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(503, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(694, 750);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 52, 77);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1Main";
            Size = new Size(1200, 750);
            Load += Form1Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private ModernTextBox textBox1;
        private ModernButton button1;
        private ModernTextBox textBox2;
        private ModernPanel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
