using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedikApp.UI
{
    public partial class ForgotPassword : UserControl
    {
        private Size OriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recTxt1;
        private Rectangle recLbl1;
        private Rectangle recLbl2;
        public ForgotPassword()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Resize += ForgotPassword_Resize;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            OriginalSize = this.Size;
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recBut2 = new Rectangle(button2.Location, button2.Size);
            recTxt1 = new Rectangle(textBox1.Location, textBox1.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recLbl1 = new Rectangle(label1.Location, label1.Size);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void resize_Control_nosize(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
        }
        private void ForgotPassword_Resize(object sender, EventArgs e)
        {
            resize_Control(textBox1, recTxt1);
            resize_Control(button2, recBut2);
            resize_Control(label1, recLbl1);
            resize_Control(label2, recLbl2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            VerifySMSCode sy = new VerifySMSCode();
            sy.Location = new System.Drawing.Point(0, 0);
            sy.Size = this.Parent.Size;
            this.Controls.Add(sy);
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            LogIn menu = new LogIn();
            menu.Location = new System.Drawing.Point(0, 0);
            menu.Size = this.Parent.Size;
            this.Controls.Add(menu);
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
