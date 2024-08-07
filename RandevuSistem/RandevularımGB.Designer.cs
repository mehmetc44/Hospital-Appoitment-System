namespace RandevuSistem
{
    partial class RandevularımGB
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            RandevuIptalButon = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCyan;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(RandevuIptalButon);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 160);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hastane Adı 1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 45);
            label2.Name = "label2";
            label2.Size = new Size(166, 115);
            label2.TabIndex = 2;
            
            label2.Click += label2_Click;
            // 
            // RandevuIptalButon
            // 
            RandevuIptalButon.BackColor = Color.Crimson;
            RandevuIptalButon.FlatAppearance.BorderColor = Color.Red;
            RandevuIptalButon.FlatAppearance.BorderSize = 0;
            RandevuIptalButon.FlatAppearance.MouseDownBackColor = Color.Red;
            RandevuIptalButon.Location = new Point(244, 69);
            RandevuIptalButon.Margin = new Padding(0);
            RandevuIptalButon.Name = "RandevuIptalButon";
            RandevuIptalButon.Size = new Size(108, 37);
            RandevuIptalButon.TabIndex = 1;
            RandevuIptalButon.Text = "iptal et";
            RandevuIptalButon.UseVisualStyleBackColor = false;
            RandevuIptalButon.Click += RandevuIptalButon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(63, 100);
            label1.TabIndex = 0;
            label1.Text = "Klinik:\r\n\r\nTarih:\r\n\r\nDoktor:\r\n";
            // 
            // RandevularımGB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "RandevularımGB";
            Size = new Size(358, 160);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox groupBox1;
        public Button RandevuIptalButon;
        private Label label1;
        public Label label2;
    }
}
