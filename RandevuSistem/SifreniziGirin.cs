using Newtonsoft.Json;
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
    public partial class SifreniziGirin : UserControl
    {
        public SifreniziGirin()
        {
            InitializeComponent();
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


        private async void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Profil profil = new Profil();
            profil.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            profil.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
            profil.AutoScroll = true;
            this.AutoScroll = false;
            this.Controls.Add(profil);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
