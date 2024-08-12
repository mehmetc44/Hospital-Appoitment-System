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
using RandevuSistem.ModernElements;
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
            talepbuton = new ModernButton();
            randevularımbuton = new ModernButton();
            randevubuton = new ModernButton();
            panel1 = new Panel();
            button1 = new ModernButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // talepbuton
            // 
            talepbuton.BackColor = Color.FromArgb(50, 52, 77);
            talepbuton.BorderColor = Color.Transparent;
            talepbuton.BorderRadius = 30;
            talepbuton.FlatAppearance.BorderSize = 0;
            talepbuton.FlatStyle = FlatStyle.Flat;
            talepbuton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            talepbuton.Location = new Point(7, 295);
            talepbuton.Name = "talepbuton";
            talepbuton.SelectionColor = Color.FromArgb(44, 196, 208);
            talepbuton.Size = new Size(275, 57);
            talepbuton.TabIndex = 9;
            talepbuton.Text = "Talep Gönder";
            talepbuton.UseVisualStyleBackColor = false;
            talepbuton.Click += talepbuton_Click_1;
            // 
            // randevularımbuton
            // 
            randevularımbuton.BackColor = Color.FromArgb(50, 52, 77);
            randevularımbuton.BorderColor = Color.Transparent;
            randevularımbuton.BorderRadius = 30;
            randevularımbuton.FlatAppearance.BorderSize = 0;
            randevularımbuton.FlatStyle = FlatStyle.Flat;
            randevularımbuton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            randevularımbuton.Location = new Point(7, 370);
            randevularımbuton.Name = "randevularımbuton";
            randevularımbuton.SelectionColor = Color.FromArgb(44, 196, 208);
            randevularımbuton.Size = new Size(275, 57);
            randevularımbuton.TabIndex = 8;
            randevularımbuton.Text = "Randevularım";
            randevularımbuton.UseVisualStyleBackColor = false;
            randevularımbuton.Click += randevularımbuton_Click;
            // 
            // randevubuton
            // 
            randevubuton.BackColor = Color.FromArgb(50, 52, 77);
            randevubuton.BorderColor = Color.Transparent;
            randevubuton.BorderRadius = 30;
            randevubuton.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            randevubuton.FlatAppearance.BorderSize = 0;
            randevubuton.FlatStyle = FlatStyle.Flat;
            randevubuton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            randevubuton.Location = new Point(7, 222);
            randevubuton.Name = "randevubuton";
            randevubuton.SelectionColor = Color.FromArgb(44, 196, 208);
            randevubuton.Size = new Size(275, 57);
            randevubuton.TabIndex = 7;
            randevubuton.Text = "Randevu Al";
            randevubuton.UseVisualStyleBackColor = false;
            randevubuton.Click += randevubuton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 52, 77);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(talepbuton);
            panel1.Controls.Add(randevularımbuton);
            panel1.Controls.Add(randevubuton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 730);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.BorderColor = Color.Transparent;
            button1.BorderRadius = 30;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(7, 33);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.RightToLeft = RightToLeft.No;
            button1.SelectionColor = Color.Red;
            button1.Size = new Size(275, 88);
            button1.TabIndex = 12;
            button1.Text = "         Profil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 52, 77);
            panel2.Location = new Point(287, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(911, 508);
            panel2.TabIndex = 15;
            // 
            // MainMenu
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainMenu";
            Size = new Size(1200, 730);
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ModernButton talepbuton;
        private ModernButton randevularımbuton;
        private Panel panel1;
        private ModernButton button1;
        private Panel panel2;
        private ModernButton randevubuton;

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
            randevu.Size = new System.Drawing.Size(1200, 750); // Boyutu belirleyin
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
            randevu.Size = new System.Drawing.Size(1200, 750); // Boyutu belirleyin
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
            talep.Size = new System.Drawing.Size(1200, 750); // Boyutu belirleyin
            talep.AutoScroll = true;
            this.AutoScroll = false;
            this.Controls.Add(talep);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
