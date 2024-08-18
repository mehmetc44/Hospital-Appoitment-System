using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace RandevuSistem
{
    public partial class SifreniziGirin : UserControl
    {
        private Size OriginalSize;
        private Rectangle recBut3;
        private Rectangle recBut4;
        private Rectangle recTxt1;
        private Rectangle recTxt2;
        private Rectangle recTxt3;
        private Rectangle recLbl1;
        private Rectangle recLbl2;
        private Rectangle recLbl3;

        public SifreniziGirin()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            this.DoubleBuffered = true;
            this.Resize += SifreniziGirin_Resize;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.Show();
            OriginalSize = this.Size;
            recBut3 = new Rectangle(button3.Location, button3.Size);
            recBut4 = new Rectangle(button4.Location, button4.Size);
            recTxt1 = new Rectangle(textBox1.Location, textBox1.Size);
            recTxt2 = new Rectangle(textBox2.Location, textBox2.Size);
            recTxt3 = new Rectangle(textBox3.Location, textBox3.Size); ;
            recLbl1 = new Rectangle(label1.Location, label1.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recLbl3 = new Rectangle(label3.Location, label3.Size);

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
        private void SifreniziGirin_Resize(object sender, EventArgs e)
        {
            resize_Control(button3, recBut3);
            resize_Control(button4, recBut4);
            resize_Control(textBox1, recTxt1);
            resize_Control(textBox2, recTxt2);
            resize_Control(textBox3, recTxt3);
            resize_Control_nosize(label1, recLbl1);
            resize_Control_nosize(label2, recLbl2);
            resize_Control_nosize(label3, recLbl3);

        }
        public class User
        {
            public User(string tcNumara, string oldPassword, string newPassword)
            {
                this.tcNumara = tcNumara;
                this.oldPassword = oldPassword;
                this.newPassword = newPassword;
            }

            public string tcNumara { get; set; }
            public string oldPassword { get; set; }
            public string newPassword { get; set; }
        }
        public static async Task ChangePassword(User user)
        {
            var url = "http://localhost:5294/api/PersonControllers/Kullanici/SifreDegistir"; // Kullanıcı ID'sini URL'e eklemiyoruz
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Kullanıcı güncellendi");
                }
                else
                {
                    MessageBox.Show("Hata: " + response.StatusCode);
                }
            }
        }
        private void SifreniziGirin_Load(object sender, EventArgs e)
        {

        }
        private async void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                if ((textBox1.Text == null) || (textBox2.Text == null) || (textBox3.Text == null))
                {
                    MessageBox.Show("Bilgileri tam doldurun.");
                }
                else
                {
                    await ChangePassword(new User(Form1Main.UserInfo.tc, textBox1.Text, textBox2.Text));
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls[0].Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
