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
            label9 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // Yas
            // 
            Yas.AutoSize = true;
            Yas.BackColor = Color.Transparent;
            Yas.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Yas.ForeColor = Color.FromArgb(0, 126, 249);
            Yas.Location = new Point(65, 22);
            Yas.Name = "Yas";
            Yas.Size = new Size(75, 60);
            Yas.TabIndex = 0;
            Yas.Text = "30";
            // 
            // Yastxt
            // 
            Yastxt.AutoSize = true;
            Yastxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Yastxt.ForeColor = Color.Azure;
            Yastxt.Location = new Point(81, 82);
            Yastxt.Name = "Yastxt";
            Yastxt.Size = new Size(42, 28);
            Yastxt.TabIndex = 1;
            Yastxt.Text = "Yaş";
            Yastxt.Click += Yastxt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.BorderRadius = 30;
            panel1.Controls.Add(Yastxt);
            panel1.Controls.Add(Yas);
            panel1.Location = new Point(43, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 124);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(50, 22);
            label3.Name = "label3";
            label3.Size = new Size(100, 60);
            label3.TabIndex = 0;
            label3.Text = "180";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(75, 82);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 1;
            label2.Text = "Boy";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.BorderRadius = 30;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(451, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 124);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(65, 22);
            label5.Name = "label5";
            label5.Size = new Size(75, 60);
            label5.TabIndex = 0;
            label5.Text = "90";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Azure;
            label4.Location = new Point(75, 82);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 1;
            label4.Text = "Kilo";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 39, 58);
            panel3.BorderRadius = 30;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(247, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 124);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 126, 249);
            label7.Location = new Point(50, 22);
            label7.Name = "label7";
            label7.Size = new Size(112, 60);
            label7.TabIndex = 0;
            label7.Text = "20.5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Azure;
            label6.Location = new Point(65, 81);
            label6.Name = "label6";
            label6.Size = new Size(76, 34);
            label6.TabIndex = 1;
            label6.Text = "Vücut-Kitle\r\n  endeksi";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 39, 58);
            panel4.BorderRadius = 30;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(655, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(198, 124);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.AppWorkspace;
            label9.Location = new Point(100, 30);
            label9.Name = "label9";
            label9.Size = new Size(122, 28);
            label9.TabIndex = 6;
            label9.Text = "Aile Hekimi";
            label9.Click += label9_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(39, 39, 58);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel1);
            panel5.Location = new Point(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(910, 189);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(46, 51, 73);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(290, 316);
            panel6.Name = "panel6";
            panel6.Size = new Size(311, 134);
            panel6.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 126, 249);
            label8.Location = new Point(57, 70);
            label8.Name = "label8";
            label8.Size = new Size(207, 31);
            label8.TabIndex = 7;
            label8.Text = "Prof. Dr. Ali Candar";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label1);
            Name = "MainPage";
            Size = new Size(910, 640);
            Load += MainPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Label label9;
        private Panel panel5;
        private Panel panel6;
        private Label label8;
    }
}
