using MedikApp.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MedikApp.UI;
using MedikApp.UI.View.Components.ModernElements;

namespace MedikApp.UI.View.Shared
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();

            selectedBut = profilButton;
            BorderStyle = BorderStyle.None;
            Resize += MainMenu_Resize;
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            formOriginalSize = Size;
            panelOriginal = panel2.Size;
            recPanel2 = new Rectangle(panel2.Location, panel2.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recpanel4 = new Rectangle(panel4.Location, panel4.Size);

            profil = new Profile(sg);
            recProfil = new Rectangle(profil.Location, profil.Size);

        }
        private int height;
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 52, 77);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 730);
            panel1.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 39, 58);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 223);
            panel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(99, 150);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 13;
            label1.Text = "Profil";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(287, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 90);
            panel2.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(176, 15);
            label2.Name = "label2";
            label2.Size = new Size(486, 50);
            label2.TabIndex = 0;
            label2.Text = "Sağlıklı Günler Mehmet Çakmak!";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.BackColor = Color.Aqua;
            panel4.Location = new Point(287, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(912, 640);
            panel4.TabIndex = 16;
            panel4.Paint += panel4_Paint;
            // 
            // MainMenu
            // 
            BackColor = Color.Black;
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainMenu";
            Size = new Size(1200, 730);
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private ResetPassword sg = new ResetPassword()
        {
            Location = new Point(0, 0),
            Size = new Size(913, 640),
            AutoScroll = false
        };
        private ModernButton talepbuton;
        private Panel panel1;
        private ModernButton profilButton;
        private Panel panel2;
        private ModernButton randevularımbuton;
        private ModernButton talepButton;
        private Panel panel3;
        private Label label1;
        private ModernButton randevularımbut;
        private Label label2;
        private ModernButton randevubuton;
        private ModernButton AnaMenubut;
        private Size formOriginalSize;
        private Size panelOriginal;
        private Rectangle recPanel2;
        private Panel panel4;
        private Rectangle recLbl2;
        private Rectangle recpanel4;
        private Rectangle recProfil;
        private SendRequest talep;
        private Appointment randevuAl;
        private ModernButton selectedBut;
        private AppointmentList randevu;
        private Profile profil;
        private MainPage mainPage;
        private Control selectedControl;
        private void resize_Panel4(Control c, Rectangle r)
        {
            float xRatio = Width / (float)formOriginalSize.Width;
            float yRatio = Height / (float)formOriginalSize.Height;
            int newY = panel2.Size.Height;
            int newHeight = (int)(r.Height * yRatio);
            c.Size = new Size(Width - 287, newHeight);
            c.Location = new Point(288, panel2.Height);

        }
        private void resize_UserController(Control c, Rectangle r)
        {
            float xRatio = Width / (float)formOriginalSize.Width;
            float yRatio = Height / (float)formOriginalSize.Height;
            int newY = panel2.Size.Height;
            int newHeight = (int)(r.Height * yRatio);
            c.Size = new Size(Width - 287, newHeight);
            c.Location = new Point(288, panel2.Height);
        }
        private void resize_Panel(Control c, Rectangle r)
        {
            float xRatio = Width / (float)formOriginalSize.Width;
            float yRatio = Height / (float)formOriginalSize.Height;
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newHeight = (int)(r.Height * yRatio);
            c.Size = new Size(Width - 287, newHeight);

        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = panel2.Width / (float)panelOriginal.Width;
            float yRatio = panel2.Height / (float)panelOriginal.Height;
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void resize_Control_nosize(Control c, Rectangle r)
        {
            float xRatio = panel2.Width / (float)panelOriginal.Width;
            float yRatio = panel2.Height / (float)panelOriginal.Height;
            int newY = (int)(r.Y * yRatio);

            int newX = panel2.Width - 544;

            c.Location = new Point((int)(newX * 0.5), newY);
        }



        private void resetThema()
        {
            talepButton.BackColor = Color.FromArgb(50, 52, 77);
            randevubuton.BackColor = Color.FromArgb(50, 52, 77);
            randevularımbut.BackColor = Color.FromArgb(50, 52, 77);
            profilButton.BackColor = Color.FromArgb(50, 52, 77);
            AnaMenubut.BackColor = Color.FromArgb(50, 52, 77);
        }
        private void changeThema(ModernButton selectedButton)
        {
            if (selectedButton.Tag == "Talep")
            {
                talepButton.BackColor = Color.FromArgb(30, 215, 96);
            }
            else if (selectedButton.Tag == "Randevu")
            {
                randevubuton.BackColor = Color.FromArgb(43, 163, 200);
            }
            else if (selectedButton.Tag == "Randevularım")
            {
                randevularımbut.BackColor = Color.FromArgb(230, 125, 60);
            }
            else if (selectedButton.Tag == "Profil")
            {
                profilButton.BackColor = Color.FromArgb(222, 1, 50);
            }
            else if (selectedButton.Tag == "Ana")
            {
                AnaMenubut.BackColor = Color.FromArgb(60, 60, 60);
            }
        }
        private void talepButton_Click(object sender, EventArgs e)
        {
            selectedBut = talepbuton;
            resetThema();
            changeThema(talepButton);
            panel4.Controls.Clear();
            talep = new SendRequest();
            talep.Location = new Point(0, 0); // Konumu belirleyin
            talep.Size = panel4.Size; // Boyutu belirleyin
            talep.AutoScroll = true;
            AutoScroll = false;
            panel4.Controls.Add(talep);

        }

        private void randevularımbut_Click(object sender, EventArgs e)
        {
            randevularımbut.Tag = "Randevularım";
            selectedBut = randevularımbut;
            resetThema();
            changeThema(randevularımbut);
            panel4.Controls.Clear();
            randevu = new AppointmentList();

            randevu.Location = new Point(0, 0); // Konumu belirleyin
            randevu.Size = panel4.Size; // Boyutu belirleyin
            randevu.panel1.Width = panel4.Width;
            panel4.Controls.Add(randevu);
        }
        private void randevubuton_Click(object sender, EventArgs e)
        {
            selectedBut = randevubuton;
            resetThema();
            changeThema(randevubuton);
            panel4.Controls.Clear();
            randevuAl = new Appointment();
            randevuAl.Location = new Point(0, 0); // Konumu belirleyin
            randevuAl.Size = panel4.Size; // Boyutu belirleyin
            randevuAl.AutoScroll = true;
            AutoScroll = false;
            panel4.Controls.Add(randevuAl);

        }
        private void profilbutton_Click(object sender, EventArgs e)
        {
            resetThema();
            changeThema(profilButton);
            panel4.Controls.Clear();
            profil = new Profile(sg);
            profil.Size = panel4.Size;
            profil.resize_Control_noLocation(profil.panel1, profil.recPanel);
            selectedBut = profilButton;
            panel4.Controls.Add(profil);
            panel4.Controls.Add(sg);

            sg.Hide();

        }
        private void AnaMenuBut_Click(object sender, EventArgs e)
        {
            selectedBut = AnaMenubut;
            resetThema();
            changeThema(AnaMenubut);
            panel4.Controls.Clear();
            mainPage = new MainPage();
            mainPage.Location = new Point(0, 0); // Konumu belirleyin
            mainPage.Size = panel4.Size; // Boyutu belirleyin
            panel4.Controls.Add(mainPage);

        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            Invalidate();
            this.AnaMenubut.BackColor = Color.FromArgb(60, 60, 60);
            panel4.Controls.Clear();
            mainPage = new MainPage();
            mainPage.Location = new Point(0, 0); // Konumu belirleyin
            mainPage.Size = panel4.Size; // Boyutu belirleyin
            panel4.Controls.Add(mainPage);
            label2.Text = "Sağlıklı Günler Mehmet Çakmak!";
            label2.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectedControl = mainPage;
        }
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            resize_Panel(panel2, recPanel2);
            resize_Control_nosize(label2, recLbl2);
            resize_Panel4(panel4, recpanel4);
            panel1.Height = Height;
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
