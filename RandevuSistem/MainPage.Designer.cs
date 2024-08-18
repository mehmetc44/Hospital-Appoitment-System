using RandevuSistem.ModernElements;
namespace RandevuSistem
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            Yas = new Label();
            Yastxt = new Label();
            panel1 = new ModernPanel();
            label3 = new Label();
            label2 = new Label();
            panel2 = new ModernPanel();
            label5 = new Label();
            label4 = new Label();
            panel3 = new ModernPanel();
            label7 = new Label();
            label6 = new Label();
            panel4 = new ModernPanel();
            label1 = new Label();
            modernPanel3 = new ModernPanel();
            pictureBox1 = new PictureBox();
            button1 = new ModernButton();
            label14 = new Label();
            label15 = new Label();
            linkLabel1 = new LinkLabel();
            modernPanel1 = new ModernPanel();
            label10 = new Label();
            monthCalendar1 = new ModernMonthCalendar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            modernPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            modernPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Yas
            // 
            Yas.AutoSize = true;
            Yas.BackColor = Color.Transparent;
            Yas.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Yas.ForeColor = Color.FromArgb(0, 126, 249);
            Yas.Location = new Point(56, 13);
            Yas.Name = "Yas";
            Yas.Size = new Size(75, 60);
            Yas.TabIndex = 0;
            Yas.Text = "30";
            // 
            // Yastxt
            // 
            Yastxt.Anchor = AnchorStyles.None;
            Yastxt.AutoSize = true;
            Yastxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Yastxt.ForeColor = Color.Azure;
            Yastxt.Location = new Point(70, 73);
            Yastxt.Name = "Yastxt";
            Yastxt.Size = new Size(42, 28);
            Yastxt.TabIndex = 1;
            Yastxt.Text = "Yaş";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(18, 48, 70);
            panel1.BorderRadius = 30;
            panel1.Controls.Add(Yastxt);
            panel1.Controls.Add(Yas);
            panel1.Location = new Point(36, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 120);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(50, 13);
            label3.Name = "label3";
            label3.Size = new Size(100, 60);
            label3.TabIndex = 0;
            label3.Text = "180";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(72, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 1;
            label2.Text = "Boy";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(18, 48, 70);
            panel2.BorderRadius = 30;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(226, 350);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 120);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(56, 13);
            label5.Name = "label5";
            label5.Size = new Size(75, 60);
            label5.TabIndex = 0;
            label5.Text = "90";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Azure;
            label4.Location = new Point(65, 73);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 1;
            label4.Text = "Kilo";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.FromArgb(18, 48, 70);
            panel3.BorderRadius = 30;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(36, 350);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 120);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 126, 249);
            label7.Location = new Point(56, 13);
            label7.Name = "label7";
            label7.Size = new Size(87, 60);
            label7.TabIndex = 0;
            label7.Text = "A+";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Azure;
            label6.Location = new Point(48, 75);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 1;
            label6.Text = "Kan grubu";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.FromArgb(18, 48, 70);
            panel4.BorderRadius = 30;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(226, 224);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 120);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(61, 23);
            label1.Name = "label1";
            label1.Size = new Size(267, 50);
            label1.TabIndex = 4;
            label1.Text = "Kişisel Bilgiler";
            // 
            // modernPanel3
            // 
            modernPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            modernPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            modernPanel3.BackColor = Color.FromArgb(39, 39, 58);
            modernPanel3.BorderRadius = 50;
            modernPanel3.Controls.Add(pictureBox1);
            modernPanel3.Controls.Add(button1);
            modernPanel3.Controls.Add(label14);
            modernPanel3.Controls.Add(label15);
            modernPanel3.Location = new Point(444, 126);
            modernPanel3.Name = "modernPanel3";
            modernPanel3.Size = new Size(419, 126);
            modernPanel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 98;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.SeaGreen;
            button1.BorderColor = Color.Transparent;
            button1.BorderRadius = 30;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(270, 46);
            button1.Name = "button1";
            button1.SelectionColor = Color.Red;
            button1.Size = new Size(125, 40);
            button1.TabIndex = 97;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Azure;
            label14.Location = new Point(158, 67);
            label14.Name = "label14";
            label14.Size = new Size(89, 40);
            label14.TabIndex = 1;
            label14.Text = "Vücut-kitle \r\nendeksi";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Nirmala UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 126, 249);
            label15.Location = new Point(152, 17);
            label15.Name = "label15";
            label15.Size = new Size(95, 50);
            label15.TabIndex = 0;
            label15.Text = "35.1";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.BackColor = Color.FromArgb(48, 78, 100);
            linkLabel1.LinkArea = new LinkArea(0, 18);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Turquoise;
            linkLabel1.Location = new Point(158, 498);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bilgileri Güncelle";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modernPanel1
            // 
            modernPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            modernPanel1.BackColor = Color.FromArgb(48, 78, 100);
            modernPanel1.BorderRadius = 50;
            modernPanel1.Controls.Add(label10);
            modernPanel1.Location = new Point(22, 126);
            modernPanel1.Name = "modernPanel1";
            modernPanel1.Size = new Size(402, 413);
            modernPanel1.TabIndex = 10;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(49, 24);
            label10.Name = "label10";
            label10.Size = new Size(316, 50);
            label10.TabIndex = 0;
            label10.Text = "Mehmet Çakmak";
            label10.TextAlign = ContentAlignment.TopCenter;
            label10.Click += label10_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.White;
            monthCalendar1.CurrentDate = new DateTime(2024, 8, 18, 0, 0, 0, 0);
            monthCalendar1.DaysForeColor = Color.Black;
            monthCalendar1.HeaderBackgroundColor = Color.DarkSlateBlue;
            monthCalendar1.HeaderForeColor = Color.White;
            monthCalendar1.Location = new Point(444, 269);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.SelectedDayBorderColor = Color.Red;
            monthCalendar1.Size = new Size(419, 270);
            monthCalendar1.TabIndex = 11;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(monthCalendar1);
            Controls.Add(panel2);
            Controls.Add(linkLabel1);
            Controls.Add(panel3);
            Controls.Add(modernPanel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(modernPanel1);
            Name = "MainPage";
            Size = new Size(910, 640);
            Load += MainPage_Load;
            Resize += MainPage_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            modernPanel3.ResumeLayout(false);
            modernPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            modernPanel1.ResumeLayout(false);
            modernPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Yas;
        private Label Yastxt;
        private ModernPanel panel1;
        private Label label3;
        private Label label2;
        private ModernPanel panel2;
        private Label label5;
        private Label label4;
        private ModernPanel panel3;
        private Label label7;
        private Label label6;
        private ModernPanel panel4;
        private Label label1;
        private ModernPanel modernPanel3;
        private Label label14;
        private Label label15;
        private LinkLabel linkLabel1;
        private ModernPanel modernPanel1;
        private Label label10;
        private ModernButton button1;
        private ModernMonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
    }
}
