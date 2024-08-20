using RandevuSistem.Classes.DataClasses;

namespace RandevuSistem
{
    partial class Randevularım
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 664);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            panel1.Resize += panel1_Resize;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(162, 155);
            label2.Name = "label2";
            label2.Size = new Size(585, 40);
            label2.TabIndex = 83;
            label2.Text = "Aktif randevularınızı bu sayfadan takip edebilirsiniz. İptal etmek istediğiniz randevunun \r\nsağındaki \"iptal\" butonuna basarak kolayca iptal edebilirsiniz.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(264, 50);
            label1.TabIndex = 82;
            label1.Text = "Randevularım";
            // 
            // Randevularım
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(46, 51, 3);
            Controls.Add(panel1);
            Name = "Randevularım";
            Size = new Size(1065, 640);
            Load += Randevularım_Load;
            Resize += Randevularım_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        public Panel panel1;
        public Label label1;
        public Label label2;
    }
}
