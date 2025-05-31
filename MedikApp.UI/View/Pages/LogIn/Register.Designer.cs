using MedikApp.UI.View.Components.ModernElements;
using System.Windows.Forms;

namespace MedikApp.UI
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            button2 = new Button();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            button1 = new Button();
            mainLayout = new TableLayoutPanel();
            mainLayout.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(1182, 20);
            label1.TabIndex = 71;
            label1.Text = "TC Kimlik No";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Name = "button2";
            button2.TabIndex = 70;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0-", "0+" });
            comboBox2.Location = new Point(3, 103);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(14, 28);
            comboBox2.TabIndex = 69;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(3, 143);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(14, 27);
            textBox5.TabIndex = 78;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 100);
            label6.Name = "label6";
            label6.Size = new Size(1182, 20);
            label6.TabIndex = 68;
            label6.Text = "Kan Grubu";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(14, 27);
            textBox1.TabIndex = 72;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kadın", "Erkek" });
            comboBox1.Location = new Point(3, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(14, 28);
            comboBox1.TabIndex = 67;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 140);
            label8.Name = "label8";
            label8.Size = new Size(1182, 20);
            label8.TabIndex = 77;
            label8.Text = "Şifre(Tekrar)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(3, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(14, 27);
            dateTimePicker1.TabIndex = 66;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 80);
            label4.Name = "label4";
            label4.Size = new Size(1182, 20);
            label4.TabIndex = 73;
            label4.Text = "Tel. Numarası";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 60);
            label5.Name = "label5";
            label5.Size = new Size(1182, 20);
            label5.TabIndex = 65;
            label5.Text = "Cinsiyet";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(3, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(14, 27);
            textBox4.TabIndex = 76;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 40);
            label3.Name = "label3";
            label3.Size = new Size(1182, 20);
            label3.TabIndex = 64;
            label3.Text = "Doğum Tarihi";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(3, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(14, 27);
            textBox2.TabIndex = 74;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(14, 27);
            textBox3.TabIndex = 63;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(23, 120);
            label7.Name = "label7";
            label7.Size = new Size(1182, 20);
            label7.TabIndex = 75;
            label7.Text = "Şifre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 0);
            label2.Name = "label2";
            label2.Size = new Size(1182, 20);
            label2.TabIndex = 62;
            label2.Text = "Ad-Soyad";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.TabIndex = 61;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.RowCount = 6;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Padding = new Padding(20);
            mainLayout.Name = "mainLayout";
            mainLayout.TabIndex = 0;
            mainLayout.BackColor = Color.Transparent;
            Panel CreateCell(Control label, Control input)
            {
                var panel = new Panel { Dock = DockStyle.Fill };
                label.Dock = DockStyle.Top;
                input.Dock = DockStyle.Top;
                panel.Controls.Add(input);
                panel.Controls.Add(label);
                return panel;
            }

            
            mainLayout.Controls.Add(CreateCell(label2, textBox3), 0, 1);
            mainLayout.Controls.Add(CreateCell(label1, textBox1), 1, 1);

            // Satır 1
            mainLayout.Controls.Add(CreateCell(label3, dateTimePicker1), 0, 2);
            mainLayout.Controls.Add(CreateCell(label5, comboBox1), 1, 2);

            // Satır 2
            mainLayout.Controls.Add(CreateCell(label4, textBox2), 0, 3);
            mainLayout.Controls.Add(CreateCell(label6, comboBox2), 1, 3);

            // Satır 3
            mainLayout.Controls.Add(CreateCell(label7, textBox4), 0, 4);
            mainLayout.Controls.Add(CreateCell(label8, textBox5), 1, 4);

            // Satır 4: Butonlar aynı hücredeyse, yan yana eklenmiş bir panel yapılabilir
            var buttonPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Fill,
                AutoSize = true
            };
            button1.Size = new Size(120, 40);
            button2.Size = new Size(120, 40);

            buttonPanel.Controls.Add(button1);
            buttonPanel.Controls.Add(button2);
            mainLayout.Controls.Add(buttonPanel, 0, 5);
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(mainLayout);
            Name = "Register";
            Size = new Size(1208, 750);
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button2;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private Label label2;
        private Button button1;
        private TableLayoutPanel mainLayout;
    }
}
