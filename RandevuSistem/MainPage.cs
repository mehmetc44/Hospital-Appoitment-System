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
    public partial class MainPage : UserControl
    {
        private Size OriginalSize;
        private Rectangle recPanel1;
        private Rectangle recPanel2;
        private Rectangle recPanel3;
        private Rectangle recPanel4;
        private Rectangle recPanel5;
        private Rectangle recPanel6;

        private Rectangle recLbl1;
        private Rectangle recLbl2;
        private Rectangle recLbl3;
        private Rectangle recLbl4;
        private Rectangle recLbl5;
        private Rectangle recLbl6;
        private Rectangle recLbl7;
        private Rectangle recLbl8;
        private Rectangle recLbl9;
        private Rectangle recLbl10;
        private Rectangle recLbl11;
        private Rectangle recLbl12;
        private Rectangle recLink;

        private Rectangle recBut1;
        private Rectangle recPic1;
        private Rectangle recCal;
        private Size OriginalPanel1;
        private Size OriginalPanel3;
        public MainPage()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            OriginalSize = this.Size;
            OriginalPanel1 = modernPanel1.Size;
            OriginalPanel3 = modernPanel3.Size;
            recPanel1 = new Rectangle(modernPanel1.Location, modernPanel1.Size);
            recPanel6 = new Rectangle(modernPanel3.Location, modernPanel3.Size);
            recLbl1 = new Rectangle(label1.Location, label1.Size);
            recLbl2 = new Rectangle(label10.Location, label10.Size);
            recPanel2 = new Rectangle(panel1.Location , panel1.Size);
            recPanel3 = new Rectangle(panel2.Location , panel2.Size);
            recPanel4 = new Rectangle(panel3.Location , panel3.Size);
            recPanel5 = new Rectangle(panel4.Location , panel4.Size);
            recLink = new Rectangle(linkLabel1.Location, linkLabel1.Size);
            recLbl3 = new Rectangle(Yas.Location, Yas.Size);
            recLbl4 = new Rectangle(Yastxt.Location, Yastxt.Size);
            recLbl5 = new Rectangle(label2.Location ,label2.Size);
            recLbl6 = new Rectangle(label3.Location, label3.Size);
            recLbl7 = new Rectangle(label4.Location, label4.Size);
            recLbl8 = new Rectangle(label5.Location, label5.Size);
            recLbl9 = new Rectangle(label6.Location, label6.Size);
            recLbl10 = new Rectangle(label7.Location, label7.Size);
            recLbl11 = new Rectangle(label14.Location, label14.Size);
            recLbl12 = new Rectangle(label15.Location, label15.Size);
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recPic1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recCal = new Rectangle(monthCalendar1.Location, monthCalendar1.Size);
        }
        private void MainPage_Resize(object sender, EventArgs e)
        {
            int x = Math.Abs(this.Width - OriginalSize.Width);
            int y = Math.Abs(this.Height - OriginalSize.Height);
            if ((x + y) > 10)
            {
                resize_Panel1(modernPanel1, recPanel1);
                resize_Control_nosize(label1, recLbl1);
                resize_elements_Panel1_nosize(label10, recLbl2);
                resize_elements_Panel1_nosize(linkLabel1, recLink);
                resize_elements_Panel1(panel1, recPanel2);
                resize_elements_Panel1(panel2, recPanel3);
                resize_elements_Panel1(panel3, recPanel4);
                resize_elements_Panel1(panel4, recPanel5);
                resize_elements_Panel1_panels(Yas, recLbl3);
                resize_elements_Panel1_panels(Yastxt, recLbl4);
                resize_elements_Panel1_panels(label2, recLbl5);
                resize_elements_Panel1_panels(label3, recLbl6);
                resize_elements_Panel1_panels(label4, recLbl7);
                resize_elements_Panel1_panels(label5, recLbl8);
                resize_elements_Panel1_panels(label6, recLbl9);
                resize_elements_Panel1_panels(label7, recLbl10);
                resize_Panel2(modernPanel3, recPanel6);
                resize_elements_Panel2_nosize(label14, recLbl11);
                resize_elements_Panel2_nosize(label15, recLbl12);
                resize_elements_Panel2(button1, recBut1);
                resize_elements_Panel2(pictureBox1, recPic1);
                resize_Panel1(monthCalendar1,recCal);
            }
        }
        private void resize_elements_Panel1(Control c, Rectangle r)
        {
            float xRatio = (float)(modernPanel1.Width) / (float)(OriginalPanel1.Width);
            float yRatio = (float)(modernPanel1.Height) / (float)(OriginalPanel1.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void resize_elements_Panel2(Control c, Rectangle r)
        {
            float xRatio = (float)(modernPanel3.Width) / (float)(OriginalPanel3.Width);
            float yRatio = (float)(modernPanel3.Height) / (float)(OriginalPanel3.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void resize_Panel2(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newX = (int)(modernPanel1.Width+modernPanel1.Location.X+(20*xRatio));
            int newY = (int) modernPanel1.Location.Y;
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void resize_elements_Panel2_nosize(Label c, Rectangle r)
        {
            float yRatio = (float)(modernPanel3.Height) / (float)(OriginalPanel3.Height);
            c.Font = new Font(c.Font.FontFamily, c.Font.Size * yRatio,FontStyle.Bold);
            int newX = (modernPanel3.Width - c.Width) / 2;
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
            c.AutoSize = true;

            // Ekran boyutlarına bağlı olarak minimum ve maksimum font boyutları belirle
            if (c.Font.Size < 8)
                c.Font = new Font(c.Font.FontFamily, 8, FontStyle.Bold);
            else if (c.Font.Size > 24)
                c.Font = new Font(c.Font.FontFamily, 24, FontStyle.Bold);
        }
        private void resize_elements_Panel1_nosize(Control c, Rectangle r)
        {
            float yRatio = (float)(modernPanel1.Height) / (float)(OriginalPanel1.Height);
            int newX = (modernPanel1.Width-c.Width)/2;
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
        }
        private void resize_elements_Panel1_panels(Control c, Rectangle r)
        {
            float yRatio = (float)(modernPanel1.Height) / (float)(OriginalPanel1.Height);
            c.Font = new Font(c.Font.FontFamily, c.Font.Size * yRatio,FontStyle.Bold);
            
            int newX = (panel1.Width - c.Width) / 2;
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
        }

        private void resize_Control_nosize(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
        }
        private void resize_Panel1(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location= new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
