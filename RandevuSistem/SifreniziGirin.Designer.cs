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
            label1 = new Label();
            textBox1 = new ModernTextBox();
            label7 = new Label();
            textBox2 = new ModernTextBox();
            label8 = new Label();
            textBox3 = new ModernTextBox();
            button3 = new ModernElements.ModernButton();
            button4 = new ModernElements.ModernButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(232, 140);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 67;
            label1.Text = "Şu anki şifre:";
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
            textBox1.Location = new Point(232, 183);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(401, 39);
            textBox1.TabIndex = 66;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(232, 231);
            label7.Name = "label7";
            label7.Size = new Size(135, 28);
            label7.TabIndex = 69;
            label7.Text = "Yeni şifreniz:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(39, 39, 58);
            textBox2.BackgroundColor = Color.FromArgb(39, 39, 58);
            textBox2.BorderColor = Color.White;
            textBox2.BorderRadius = 15;
            textBox2.BorderSize = 10;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(0, 126, 249);
            textBox2.Location = new Point(232, 274);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(401, 39);
            textBox2.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(232, 316);
            label8.Name = "label8";
            label8.Size = new Size(208, 28);
            label8.TabIndex = 71;
            label8.Text = "Yeni şifreniz(Tekrar):";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(39, 39, 58);
            textBox3.BackgroundColor = Color.FromArgb(39, 39, 58);
            textBox3.BorderColor = Color.White;
            textBox3.BorderRadius = 15;
            textBox3.BorderSize = 10;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(0, 126, 249);
            textBox3.Location = new Point(232, 359);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(401, 39);
            textBox3.TabIndex = 70;
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
            button3.Location = new Point(212, 455);
            button3.Name = "button3";
            button3.SelectionColor = Color.Red;
            button3.Size = new Size(183, 57);
            button3.TabIndex = 74;
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
            button4.Location = new Point(501, 455);
            button4.Name = "button4";
            button4.SelectionColor = Color.Red;
            button4.Size = new Size(183, 57);
            button4.TabIndex = 73;
            button4.Text = "İptal";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // SifreniziGirin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(50, 52, 77);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "SifreniziGirin";
            Size = new Size(910, 640);
            Load += SifreniziGirin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ModernTextBox textBox3;
        private Label label1;
        private ModernTextBox textBox1;
        private Label label7;
        private ModernTextBox textBox2;
        private Label label8;
        private ModernElements.ModernButton button3;
        private ModernElements.ModernButton button4;
    }
}
