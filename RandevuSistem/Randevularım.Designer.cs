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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevularım));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button7 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button7);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 1000);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(110, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 204);
            panel2.TabIndex = 65;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(205, 19);
            label2.Name = "label2";
            label2.Size = new Size(270, 50);
            label2.TabIndex = 63;
            label2.Text = "RANDEVULAR";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 98);
            label1.Name = "label1";
            label1.Size = new Size(540, 40);
            label1.TabIndex = 64;
            label1.Text = "Bu sayfada randevularınız gözükmektedir. \r\nIptal etmek istediğiniz randevuları \"iptal et butonuna basarak iptal edebilirsiniz.\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_4;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSeaGreen;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(62, 63);
            button7.TabIndex = 59;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // Randevularım
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panel1);
            Name = "Randevularım";
            Size = new Size(1179, 750);
            Load += Randevularım_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private Panel panel1;
        private Button button7;
        private Label label1;
        private Label label2;
        private Panel panel2;
    }
}
