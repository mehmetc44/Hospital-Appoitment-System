using RandevuSistem.ModernElements;
namespace RandevuSistem
{
    partial class RandevuAL
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
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            DRcomboBox = new ComboBox();
            label7 = new Label();
            KlinikComboBox = new ComboBox();
            label3 = new Label();
            HastaneComboBox1 = new ComboBox();
            label5 = new Label();
            IlcomboBox = new ComboBox();
            label4 = new Label();
            button3 = new ModernButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(517, 140);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 92;
            label6.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.Location = new Point(517, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(342, 27);
            dateTimePicker1.TabIndex = 80;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // DRcomboBox
            // 
            DRcomboBox.BackColor = Color.FromArgb(39, 39, 58);
            DRcomboBox.DropDownHeight = 200;
            DRcomboBox.FlatStyle = FlatStyle.Flat;
            DRcomboBox.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DRcomboBox.ForeColor = Color.FromArgb(0, 126, 249);
            DRcomboBox.FormattingEnabled = true;
            DRcomboBox.IntegralHeight = false;
            DRcomboBox.Location = new Point(517, 390);
            DRcomboBox.Name = "DRcomboBox";
            DRcomboBox.Size = new Size(342, 39);
            DRcomboBox.TabIndex = 91;
            DRcomboBox.SelectedIndexChanged += DRcomboBox_SelectedIndexChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(517, 349);
            label7.Name = "label7";
            label7.Size = new Size(84, 28);
            label7.TabIndex = 90;
            label7.Text = "Doktor:";
            // 
            // KlinikComboBox
            // 
            KlinikComboBox.BackColor = Color.FromArgb(39, 39, 58);
            KlinikComboBox.DropDownHeight = 200;
            KlinikComboBox.FlatStyle = FlatStyle.Flat;
            KlinikComboBox.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            KlinikComboBox.ForeColor = Color.FromArgb(0, 126, 249);
            KlinikComboBox.FormattingEnabled = true;
            KlinikComboBox.IntegralHeight = false;
            KlinikComboBox.Location = new Point(67, 390);
            KlinikComboBox.Name = "KlinikComboBox";
            KlinikComboBox.Size = new Size(342, 39);
            KlinikComboBox.TabIndex = 89;
            KlinikComboBox.SelectedIndexChanged += KlinikComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(67, 350);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 88;
            label3.Text = "Klinik:";
            // 
            // HastaneComboBox1
            // 
            HastaneComboBox1.BackColor = Color.FromArgb(39, 39, 58);
            HastaneComboBox1.DropDownHeight = 200;
            HastaneComboBox1.FlatStyle = FlatStyle.Flat;
            HastaneComboBox1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            HastaneComboBox1.ForeColor = Color.FromArgb(0, 126, 249);
            HastaneComboBox1.FormattingEnabled = true;
            HastaneComboBox1.IntegralHeight = false;
            HastaneComboBox1.Location = new Point(67, 290);
            HastaneComboBox1.Name = "HastaneComboBox1";
            HastaneComboBox1.Size = new Size(792, 39);
            HastaneComboBox1.TabIndex = 87;
            HastaneComboBox1.SelectedIndexChanged += HastaneComboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(67, 250);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 86;
            label5.Text = "Hastane:";
            // 
            // IlcomboBox
            // 
            IlcomboBox.BackColor = Color.FromArgb(39, 39, 58);
            IlcomboBox.DropDownHeight = 200;
            IlcomboBox.FlatStyle = FlatStyle.Flat;
            IlcomboBox.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            IlcomboBox.ForeColor = Color.FromArgb(0, 126, 249);
            IlcomboBox.FormattingEnabled = true;
            IlcomboBox.IntegralHeight = false;
            IlcomboBox.Location = new Point(67, 180);
            IlcomboBox.Name = "IlcomboBox";
            IlcomboBox.Size = new Size(342, 39);
            IlcomboBox.TabIndex = 85;
            IlcomboBox.SelectedIndexChanged += IlcomboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(67, 140);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 84;
            label4.Text = "Şehir:";
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.BorderColor = Color.Transparent;
            button3.BorderRadius = 30;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(373, 483);
            button3.Name = "button3";
            button3.SelectionColor = Color.Red;
            button3.Size = new Size(161, 60);
            button3.TabIndex = 83;
            button3.Text = "Randevu Al";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(320, 50);
            label1.TabIndex = 81;
            label1.Text = "Randevu Bilgileri";
            // 
            // RandevuAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(DRcomboBox);
            Controls.Add(label7);
            Controls.Add(KlinikComboBox);
            Controls.Add(label3);
            Controls.Add(HastaneComboBox1);
            Controls.Add(label5);
            Controls.Add(IlcomboBox);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "RandevuAL";
            Size = new Size(912, 640);
            Load += RandevuAL_Load;
            Resize += RandevuAL_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox DRcomboBox;
        private Label label7;
        private ComboBox KlinikComboBox;
        private Label label3;
        private ComboBox HastaneComboBox1;
        private Label label5;
        private ComboBox IlcomboBox;
        private Label label4;
        private ModernButton button3;
        private Label label1;
    }
}
