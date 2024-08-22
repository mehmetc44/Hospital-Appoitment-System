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
using System.Diagnostics;
namespace RandevuSistem
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();

            this.selectedBut = profilButton;
            this.BorderStyle = BorderStyle.None;
            this.Resize += MainMenu_Resize;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            formOriginalSize = this.Size;
            panelOriginal = panel2.Size;
            recPanel2 = new Rectangle(panel2.Location, panel2.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recpanel4 = new Rectangle(panel4.Location, panel4.Size);

            profil = new Profil(this.sg);
            recProfil = new Rectangle(profil.Location, profil.Size);

        }
        private int height;
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainMenu));
            talepButton = new ModernButton();
            randevubuton = new ModernButton();
            panel1 = new Panel();
            AnaMenubut = new ModernButton();
            randevularımbut = new ModernButton();
            panel3 = new Panel();
            label1 = new Label();
            profilButton = new ModernButton();
            panel2 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // talepButton
            // 
            talepButton.BackColor = Color.FromArgb(50, 52, 77);
            talepButton.BorderColor = Color.Transparent;
            talepButton.BorderRadius = 30;
            talepButton.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            talepButton.FlatAppearance.BorderSize = 0;
            talepButton.FlatStyle = FlatStyle.Flat;
            talepButton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            talepButton.ForeColor = SystemColors.ButtonFace;
            talepButton.Image = (Image)resources.GetObject("talepButton.Image");
            talepButton.ImageAlign = ContentAlignment.MiddleLeft;
            talepButton.Location = new Point(5, 455);
            talepButton.Name = "talepButton";
            talepButton.SelectionColor = Color.FromArgb(44, 196, 208);
            talepButton.Size = new Size(275, 60);
            talepButton.TabIndex = 13;
            talepButton.Tag = "Talep";
            talepButton.Text = "    Talep Oluştur";
            talepButton.TextAlign = ContentAlignment.MiddleLeft;
            talepButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            talepButton.UseVisualStyleBackColor = false;
            talepButton.Click += talepButton_Click;
            // 
            // randevubuton
            // 
            randevubuton.BackColor = Color.FromArgb(50, 52, 77);
            randevubuton.BackgroundImageLayout = ImageLayout.Zoom;
            randevubuton.BorderColor = Color.Transparent;
            randevubuton.BorderRadius = 30;
            randevubuton.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            randevubuton.FlatAppearance.BorderSize = 0;
            randevubuton.FlatStyle = FlatStyle.Flat;
            randevubuton.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            randevubuton.ForeColor = SystemColors.ButtonFace;
            randevubuton.Image = (Image)resources.GetObject("randevubuton.Image");
            randevubuton.ImageAlign = ContentAlignment.MiddleLeft;
            randevubuton.Location = new Point(5, 315);
            randevubuton.Name = "randevubuton";
            randevubuton.SelectionColor = Color.FromArgb(44, 196, 208);
            randevubuton.Size = new Size(275, 60);
            randevubuton.TabIndex = 7;
            randevubuton.Tag = "Randevu";
            randevubuton.Text = "     Randevu Al      ";
            randevubuton.TextAlign = ContentAlignment.MiddleLeft;
            randevubuton.TextImageRelation = TextImageRelation.ImageBeforeText;
            randevubuton.UseVisualStyleBackColor = false;
            randevubuton.Click += randevubuton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 52, 77);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(AnaMenubut);
            panel1.Controls.Add(randevularımbut);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(talepButton);
            panel1.Controls.Add(randevubuton);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 730);
            panel1.TabIndex = 14;
            // 
            // AnaMenubut
            // 
            AnaMenubut.BackColor = Color.FromArgb(50, 52, 77);
            AnaMenubut.BorderColor = Color.Transparent;
            AnaMenubut.BorderRadius = 30;
            AnaMenubut.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            AnaMenubut.FlatAppearance.BorderSize = 0;
            AnaMenubut.FlatStyle = FlatStyle.Flat;
            AnaMenubut.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AnaMenubut.ForeColor = SystemColors.ButtonFace;
            AnaMenubut.Image = (Image)resources.GetObject("AnaMenubut.Image");
            AnaMenubut.ImageAlign = ContentAlignment.MiddleLeft;
            AnaMenubut.Location = new Point(5, 245);
            AnaMenubut.Name = "AnaMenubut";
            AnaMenubut.SelectionColor = Color.FromArgb(44, 196, 208);
            AnaMenubut.Size = new Size(278, 60);
            AnaMenubut.TabIndex = 17;
            AnaMenubut.Tag = "Ana";
            AnaMenubut.Text = "     Ana Menü";
            AnaMenubut.TextAlign = ContentAlignment.MiddleLeft;
            AnaMenubut.TextImageRelation = TextImageRelation.ImageBeforeText;
            AnaMenubut.UseVisualStyleBackColor = false;
            AnaMenubut.Click += AnaMenuBut_Click;
            // 
            // randevularımbut
            // 
            randevularımbut.BackColor = Color.FromArgb(50, 52, 77);
            randevularımbut.BorderColor = Color.Transparent;
            randevularımbut.BorderRadius = 30;
            randevularımbut.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            randevularımbut.FlatAppearance.BorderSize = 0;
            randevularımbut.FlatStyle = FlatStyle.Flat;
            randevularımbut.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            randevularımbut.ForeColor = SystemColors.ButtonFace;
            randevularımbut.Image = (Image)resources.GetObject("randevularımbut.Image");
            randevularımbut.ImageAlign = ContentAlignment.MiddleLeft;
            randevularımbut.Location = new Point(5, 385);
            randevularımbut.Name = "randevularımbut";
            randevularımbut.SelectionColor = Color.FromArgb(44, 196, 208);
            randevularımbut.Size = new Size(275, 60);
            randevularımbut.TabIndex = 16;
            randevularımbut.Tag = "Randevularım";
            randevularımbut.Text = "     Randevularım";
            randevularımbut.TextAlign = ContentAlignment.MiddleLeft;
            randevularımbut.TextImageRelation = TextImageRelation.ImageBeforeText;
            randevularımbut.UseVisualStyleBackColor = false;
            randevularımbut.Click += randevularımbut_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 39, 58);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(profilButton);
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
            // profilButton
            // 
            profilButton.BackColor = Color.FromArgb(39, 39, 52);
            profilButton.BackgroundImage = (Image)resources.GetObject("profilButton.BackgroundImage");
            profilButton.BackgroundImageLayout = ImageLayout.Stretch;
            profilButton.BorderColor = Color.White;
            profilButton.BorderRadius = 100;
            profilButton.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 52);
            profilButton.FlatStyle = FlatStyle.Flat;
            profilButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            profilButton.ImageAlign = ContentAlignment.TopLeft;
            profilButton.Location = new Point(83, 21);
            profilButton.Name = "profilButton";
            profilButton.Padding = new Padding(5);
            profilButton.RightToLeft = RightToLeft.No;
            profilButton.SelectionColor = Color.Red;
            profilButton.Size = new Size(121, 121);
            profilButton.TabIndex = 12;
            profilButton.Tag = "Profil";
            profilButton.TextAlign = ContentAlignment.BottomCenter;
            profilButton.UseVisualStyleBackColor = false;
            profilButton.Click += profilbutton_Click;
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

        private SifreniziGirin sg = new SifreniziGirin()
        {
            Location = new System.Drawing.Point(0, 0),
            Size = new System.Drawing.Size(913, 640),
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
        private TalepGonder talep;
        private RandevuAL randevuAl;
        private ModernButton selectedBut;
        private Randevularım randevu;
        private Profil profil;
        private MainPage mainPage;
        private Control selectedControl;
        private void resize_Panel4(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newY = panel2.Size.Height;
            int newHeight = (int)((r.Height * yRatio));
            c.Size = new Size(this.Width - 287, newHeight);
            c.Location = new Point(288, panel2.Height);

        }
        private void resize_UserController(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newY = panel2.Size.Height;
            int newHeight = (int)((r.Height * yRatio));
            c.Size = new Size(this.Width - 287, newHeight);
            c.Location = new Point(288, panel2.Height);
        }
        private void resize_Panel(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newHeight = (int)(r.Height * yRatio);
            c.Size = new Size(this.Width - 287, newHeight);

        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(panel2.Width) / (float)(panelOriginal.Width);
            float yRatio = (float)(panel2.Height) / (float)(panelOriginal.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void resize_Control_nosize(Control c, Rectangle r)
        {
            float xRatio = (float)(panel2.Width) / (float)(panelOriginal.Width);
            float yRatio = (float)(panel2.Height) / (float)(panelOriginal.Height);
            int newY = (int)(r.Y * yRatio);

            int newX = panel2.Width - 544;

            c.Location = new Point((int)(newX * 0.5), newY);
        }



        private void resetThema()
        {
            this.talepButton.BackColor = Color.FromArgb(50, 52, 77);
            this.randevubuton.BackColor = Color.FromArgb(50, 52, 77);
            this.randevularımbut.BackColor = Color.FromArgb(50, 52, 77);
            this.profilButton.BackColor = Color.FromArgb(50, 52, 77);
            this.AnaMenubut.BackColor = Color.FromArgb(50, 52, 77);
        }
        private void changeThema(ModernButton selectedButton)
        {
            if (selectedButton.Tag == "Talep")
            {
                this.talepButton.BackColor = Color.FromArgb(30, 215, 96);
            }
            else if (selectedButton.Tag == "Randevu")
            {
                this.randevubuton.BackColor = Color.FromArgb(43, 163, 200);
            }
            else if (selectedButton.Tag == "Randevularım")
            {
                this.randevularımbut.BackColor = Color.FromArgb(230, 125, 60);
            }
            else if (selectedButton.Tag == "Profil")
            {
                this.profilButton.BackColor = Color.FromArgb(222, 1, 50);
            }
            else if (selectedButton.Tag == "Ana")
            {
                this.AnaMenubut.BackColor = Color.FromArgb(60, 60, 60);
            }
        }
        private void talepButton_Click(object sender, EventArgs e)
        {
            selectedBut = talepbuton;
            resetThema();
            changeThema(talepButton);
            this.panel4.Controls.Clear();
            talep = new TalepGonder();
            talep.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            talep.Size = this.panel4.Size; // Boyutu belirleyin
            talep.AutoScroll = true;
            this.AutoScroll = false;
            this.panel4.Controls.Add(talep);

        }

        private void randevularımbut_Click(object sender, EventArgs e)
        {
            randevularımbut.Tag = "Randevularım";
            selectedBut = randevularımbut;
            resetThema();
            changeThema(randevularımbut);
            this.panel4.Controls.Clear();
            randevu = new Randevularım();

            randevu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            randevu.Size = this.panel4.Size; // Boyutu belirleyin
            randevu.panel1.Width = this.panel4.Width;
            this.panel4.Controls.Add(randevu);
        }
        private void randevubuton_Click(object sender, EventArgs e)
        {
            selectedBut = randevubuton;
            resetThema();
            changeThema(randevubuton);
            this.panel4.Controls.Clear();
            randevuAl = new RandevuAL();
            randevuAl.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            randevuAl.Size = this.panel4.Size; // Boyutu belirleyin
            randevuAl.AutoScroll = true;
            this.AutoScroll = false;
            this.panel4.Controls.Add(randevuAl);

        }
        private void profilbutton_Click(object sender, EventArgs e)
        {
            resetThema();
            changeThema(profilButton);
            this.panel4.Controls.Clear();
            profil = new Profil(sg);
            this.profil.Size = panel4.Size;
            profil.resize_Control_noLocation(profil.panel1, profil.recPanel);
            selectedBut = profilButton;
            this.panel4.Controls.Add(profil);
            this.panel4.Controls.Add(sg);

            sg.Hide();

        }
        private void AnaMenuBut_Click(object sender, EventArgs e)
        {
            selectedBut = AnaMenubut;
            resetThema();
            changeThema(AnaMenubut);
            this.panel4.Controls.Clear();
            mainPage = new MainPage();
            mainPage.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            mainPage.Size = this.panel4.Size; // Boyutu belirleyin
            this.panel4.Controls.Add(mainPage);

        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Invalidate();
            this.AnaMenubut.BackColor = Color.FromArgb(60, 60, 60);
            this.panel4.Controls.Clear();
            mainPage = new MainPage();
            mainPage.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            mainPage.Size = this.panel4.Size; // Boyutu belirleyin
            this.panel4.Controls.Add(mainPage);
            label2.Text = "Sağlıklı Günler Mehmet Çakmak!";
            label2.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectedControl = mainPage;
        }
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            resize_Panel(panel2, recPanel2);
            resize_Control_nosize(label2, recLbl2);
            resize_Panel4(panel4, recpanel4);
            panel1.Height = this.Height;
            if (selectedBut.Tag == "Randevularım")
            {
                randevu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
                randevu.Size = this.panel4.Size; // Boyutu belirleyin
                randevu.panel1.Width = this.panel4.Width;

            }
            else if (selectedBut.Tag == "Profil")
            {
                this.profil.Size = panel4.Size;
                this.profil.panel1.Location = new Point(0, 0);
                profil.resize_Control_noLocation(panel1, profil.recPanel);

                profil.resize_Control_noLocation(profil.panel1, recProfil);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
