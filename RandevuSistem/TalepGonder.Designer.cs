using RandevuSistem.ModernElements;
namespace RandevuSistem
{
    partial class TalepGonder
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
            dateTimePicker2 = new DateTimePicker();
            DRcomboBox = new ComboBox();
            label7 = new Label();
            KlinikcomboBox = new ComboBox();
            label3 = new Label();
            HastaneCombobox = new ComboBox();
            label5 = new Label();
            ILcomboBox = new ComboBox();
            label4 = new Label();
            button1 = new ModernButton();
            label2 = new Label();
            label8 = new Label();
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
            label6.TabIndex = 105;
            label6.Text = "Tarih:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = Color.White;
            dateTimePicker2.Location = new Point(517, 180);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(342, 27);
            dateTimePicker2.TabIndex = 93;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
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
            DRcomboBox.TabIndex = 104;
            DRcomboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            label7.TabIndex = 103;
            label7.Text = "Doktor:";
            // 
            // KlinikcomboBox
            // 
            KlinikcomboBox.BackColor = Color.FromArgb(39, 39, 58);
            KlinikcomboBox.DropDownHeight = 200;
            KlinikcomboBox.FlatStyle = FlatStyle.Flat;
            KlinikcomboBox.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            KlinikcomboBox.ForeColor = Color.FromArgb(0, 126, 249);
            KlinikcomboBox.FormattingEnabled = true;
            KlinikcomboBox.IntegralHeight = false;
            KlinikcomboBox.Location = new Point(67, 390);
            KlinikcomboBox.Name = "KlinikcomboBox";
            KlinikcomboBox.Size = new Size(342, 39);
            KlinikcomboBox.TabIndex = 102;
            KlinikcomboBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
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
            label3.TabIndex = 101;
            label3.Text = "Klinik:";
            // 
            // HastaneCombobox
            // 
            HastaneCombobox.BackColor = Color.FromArgb(39, 39, 58);
            HastaneCombobox.DropDownHeight = 200;
            HastaneCombobox.FlatStyle = FlatStyle.Flat;
            HastaneCombobox.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            HastaneCombobox.ForeColor = Color.FromArgb(0, 126, 249);
            HastaneCombobox.FormattingEnabled = true;
            HastaneCombobox.IntegralHeight = false;
            HastaneCombobox.Location = new Point(67, 290);
            HastaneCombobox.Name = "HastaneCombobox";
            HastaneCombobox.Size = new Size(792, 39);
            HastaneCombobox.TabIndex = 100;
            HastaneCombobox.SelectedIndexChanged += HastaneComboBox1_SelectedIndexChanged;
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
            label5.TabIndex = 99;
            label5.Text = "Hastane:";
            // 
            // ILcomboBox
            // 
            ILcomboBox.BackColor = Color.FromArgb(39, 39, 58);
            ILcomboBox.DropDownHeight = 200;
            ILcomboBox.FlatStyle = FlatStyle.Flat;
            ILcomboBox.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ILcomboBox.ForeColor = Color.FromArgb(0, 126, 249);
            ILcomboBox.FormattingEnabled = true;
            ILcomboBox.IntegralHeight = false;
            ILcomboBox.Location = new Point(67, 180);
            ILcomboBox.Name = "ILcomboBox";
            ILcomboBox.Size = new Size(342, 39);
            ILcomboBox.TabIndex = 98;
            ILcomboBox.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
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
            label4.TabIndex = 97;
            label4.Text = "Şehir:";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.BorderColor = Color.Transparent;
            button1.BorderRadius = 30;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(373, 483);
            button1.Name = "button1";
            button1.SelectionColor = Color.Red;
            button1.Size = new Size(161, 60);
            button1.TabIndex = 96;
            button1.Text = "Talep Gönder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(529, 288);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 95;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.AppWorkspace;
            label8.Location = new Point(40, 44);
            label8.Name = "label8";
            label8.Size = new Size(262, 50);
            label8.TabIndex = 94;
            label8.Text = "Talep Bilgileri";
            label8.Click += label8_Click;
            // 
            // TalepGonder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(DRcomboBox);
            Controls.Add(label7);
            Controls.Add(KlinikcomboBox);
            Controls.Add(label3);
            Controls.Add(HastaneCombobox);
            Controls.Add(label5);
            Controls.Add(ILcomboBox);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label8);
            Name = "TalepGonder";
            Size = new Size(912, 640);
            Load += TalepGonder_Load;
            Resize += TalepGonder_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Label label3;
        private ComboBox HastaneCombobox;
        private Label label5;
        private Label label4;
        private ModernButton button1;
        private Label label2;
        private Label label8;
        private ComboBox DRcomboBox;
        private ComboBox KlinikcomboBox;
        private ComboBox ILcomboBox;
    }
}
