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
            GroupBox ILGroupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuAL));
            ILcomboBox = new ComboBox();
            panel1 = new Panel();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            DRcomboBox = new ComboBox();
            groupBox2 = new GroupBox();
            HastaneCombobox = new ComboBox();
            groupBox4 = new GroupBox();
            KlinikcomboBox = new ComboBox();
            groupBox8 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            ILGroupBox = new GroupBox();
            ILGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // ILGroupBox
            // 
            ILGroupBox.Controls.Add(ILcomboBox);
            ILGroupBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ILGroupBox.Location = new Point(51, 149);
            ILGroupBox.Name = "ILGroupBox";
            ILGroupBox.Size = new Size(485, 70);
            ILGroupBox.TabIndex = 1;
            ILGroupBox.TabStop = false;
            ILGroupBox.Text = "İl";
            ILGroupBox.UseCompatibleTextRendering = true;
            ILGroupBox.Enter += ILGroupBox_Enter;
            // 
            // ILcomboBox
            // 
            ILcomboBox.DropDownHeight = 300;
            ILcomboBox.FormattingEnabled = true;
            ILcomboBox.IntegralHeight = false;
            ILcomboBox.Location = new Point(6, 26);
            ILcomboBox.Name = "ILcomboBox";
            ILcomboBox.Size = new Size(321, 33);
            ILcomboBox.TabIndex = 0;
            ILcomboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox8);
            panel1.Controls.Add(ILGroupBox);
            panel1.Location = new Point(164, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 647);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_3;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Location = new Point(203, 538);
            button3.Name = "button3";
            button3.Size = new Size(135, 47);
            button3.TabIndex = 8;
            button3.Text = "Randevu Oluştur";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(357, 551);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 71);
            label1.Name = "label1";
            label1.Size = new Size(288, 38);
            label1.TabIndex = 1;
            label1.Text = "Randevu Bilgileri";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DRcomboBox);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(51, 377);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(485, 70);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Doktor";
            // 
            // DRcomboBox
            // 
            DRcomboBox.DropDownHeight = 300;
            DRcomboBox.FormattingEnabled = true;
            DRcomboBox.IntegralHeight = false;
            DRcomboBox.Location = new Point(6, 26);
            DRcomboBox.Name = "DRcomboBox";
            DRcomboBox.Size = new Size(321, 33);
            DRcomboBox.TabIndex = 0;
            DRcomboBox.SelectedIndexChanged += DRcomboBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(HastaneCombobox);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(51, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 70);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hastane";
            // 
            // HastaneCombobox
            // 
            HastaneCombobox.DropDownHeight = 300;
            HastaneCombobox.FormattingEnabled = true;
            HastaneCombobox.IntegralHeight = false;
            HastaneCombobox.Location = new Point(6, 26);
            HastaneCombobox.Name = "HastaneCombobox";
            HastaneCombobox.Size = new Size(321, 33);
            HastaneCombobox.TabIndex = 0;
            HastaneCombobox.SelectedIndexChanged += HastaneCombobox_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(KlinikcomboBox);
            groupBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(51, 301);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(485, 70);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Klinik";
            // 
            // KlinikcomboBox
            // 
            KlinikcomboBox.DropDownHeight = 300;
            KlinikcomboBox.FormattingEnabled = true;
            KlinikcomboBox.IntegralHeight = false;
            KlinikcomboBox.Location = new Point(6, 26);
            KlinikcomboBox.Name = "KlinikcomboBox";
            KlinikcomboBox.Size = new Size(321, 33);
            KlinikcomboBox.TabIndex = 0;
            KlinikcomboBox.SelectedIndexChanged += KlinikcomboBox_SelectedIndexChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(dateTimePicker1);
            groupBox8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox8.Location = new Point(51, 453);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(485, 70);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 31);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(19, 23);
            button2.Name = "button2";
            button2.Size = new Size(64, 55);
            button2.TabIndex = 54;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // RandevuAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 192, 192);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "RandevuAL";
            Size = new Size(879, 550);
            Load += RandevuAL_Load;
            ILGroupBox.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private VScrollBar vScrollBar1;
        private VScrollBar vScrollBar2;
        private Panel panel1;
        private GroupBox ILGroupBox;
        private ComboBox ILcomboBox;
        private GroupBox groupBox3;
        private ComboBox DRcomboBox;
        private GroupBox groupBox2;
        private ComboBox HastaneCombobox;
        private GroupBox groupBox4;
        private ComboBox KlinikcomboBox;
        private GroupBox groupBox8;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button2;
    }
}
