using RandevuSistem.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistem
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainMenu));
            bildirimbuton = new Button();
            talepbuton = new Button();
            randevularımbuton = new Button();
            randevubuton = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bildirimbuton
            // 
            bildirimbuton.BackColor = Color.Transparent;
            bildirimbuton.BackgroundImage = (Image)resources.GetObject("bildirimbuton.BackgroundImage");
            bildirimbuton.BackgroundImageLayout = ImageLayout.Stretch;
            bildirimbuton.FlatAppearance.BorderSize = 0;
            bildirimbuton.FlatStyle = FlatStyle.Flat;
            bildirimbuton.Location = new Point(455, 31);
            bildirimbuton.Name = "bildirimbuton";
            bildirimbuton.Size = new Size(60, 55);
            bildirimbuton.TabIndex = 10;
            bildirimbuton.TextImageRelation = TextImageRelation.ImageAboveText;
            bildirimbuton.UseVisualStyleBackColor = false;
            bildirimbuton.Click += bildirimbuton_Click;
            // 
            // talepbuton
            // 
            talepbuton.BackColor = Color.MediumTurquoise;
            talepbuton.FlatStyle = FlatStyle.Flat;
            talepbuton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            talepbuton.Location = new Point(134, 260);
            talepbuton.Name = "talepbuton";
            talepbuton.Size = new Size(283, 57);
            talepbuton.TabIndex = 9;
            talepbuton.Text = "Talep Gönder";
            talepbuton.UseVisualStyleBackColor = false;
            talepbuton.Click += talepbuton_Click_1;
            // 
            // randevularımbuton
            // 
            randevularımbuton.BackColor = Color.MediumTurquoise;
            randevularımbuton.FlatStyle = FlatStyle.Flat;
            randevularımbuton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            randevularımbuton.Location = new Point(134, 338);
            randevularımbuton.Name = "randevularımbuton";
            randevularımbuton.Size = new Size(283, 57);
            randevularımbuton.TabIndex = 8;
            randevularımbuton.Text = "Randevularım";
            randevularımbuton.UseVisualStyleBackColor = false;
            randevularımbuton.Click += randevularımbuton_Click;
            // 
            // randevubuton
            // 
            randevubuton.BackColor = Color.MediumTurquoise;
            randevubuton.FlatStyle = FlatStyle.Flat;
            randevubuton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            randevubuton.Location = new Point(134, 190);
            randevubuton.Name = "randevubuton";
            randevubuton.Size = new Size(283, 57);
            randevubuton.TabIndex = 7;
            randevubuton.Text = "Randevu Al";
            randevubuton.UseVisualStyleBackColor = false;
            randevubuton.Click += randevubuton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(38, 13);
            button1.Name = "button1";
            button1.Size = new Size(90, 90);
            button1.TabIndex = 12;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(61, 106);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 13;
            label1.Text = "Profil";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(455, 106);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 14;
            label2.Text = "Bildirim";
            label2.Click += label2_Click;
            // 
            // MainMenu
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(bildirimbuton);
            Controls.Add(talepbuton);
            Controls.Add(randevularımbuton);
            Controls.Add(randevubuton);
            Name = "MainMenu";
            Size = new Size(890, 530);
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private Button bildirimbuton;
        private Button talepbuton;
        private Button randevularımbuton;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button randevubuton;

        private void bildirimbuton_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void randevubuton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            RandevuAL randevu = new RandevuAL();
            randevu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            randevu.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
            randevu.AutoScroll = true;
            this.randevubuton.Text = "ssda";
            this.AutoScroll = false;
            this.Controls.Add(randevu);
        }


        private void randevularımbuton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Randevularım randevu = new Randevularım();
            randevu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            randevu.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
            randevu.AutoScroll = true;
            this.AutoScroll = false;
            this.Controls.Add(randevu);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Profil profil = new Profil();
            profil.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            profil.Size = new System.Drawing.Size(879, 1091); // Boyutu belirleyin
            profil.AutoScroll = false;
            this.AutoScroll = true;
            this.Controls.Add(profil);
        }

        private void talepbuton_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            TalepGonder talep = new TalepGonder();
            talep.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            talep.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
            talep.AutoScroll = true;
            this.AutoScroll = false;
            this.Controls.Add(talep);
        }
    }
}
