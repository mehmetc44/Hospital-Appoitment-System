using Newtonsoft.Json.Linq;
using RandevuSistem.Classes.DataClasses;
using RandevuSistem.Classes.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace RandevuSistem 
{


    public partial class Profil : UserControl
    {
        public Profil()
        {
            InitializeComponent();
        }

        private async Task<Person> GetApiDataAsync(string tc)
        {
            string url = $"http://localhost:5294/api/PersonControllers/Kullanici/KullaniciBilgileri?TcNumara={tc}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Person person = null;
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        JObject Parser = JObject.Parse(res);
                        person = new Person();
                        person.KisiId = tc;
                        person.Isim = (string)Parser["isim"];
                        person.DogumTarihi = (string)Parser["dogumTarihi"];
                        person.KanGurubu = (string)Parser["kanGurubu"];
                        person.Boy = (string)Parser["boy"];
                        person.Kilo = (string)Parser["kilo"];
                        person.Cinsiyet = (string)Parser["cinsiyet"];
                        person.TelNo = (string)Parser["telNo"];
                        return person;
                    }
                    else
                    {
                        MessageBox.Show($"Hata: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                    return null;
                }
            }
        }






        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu menu = new MainMenu
            {
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(1200, 750)
            };
            this.AutoScroll = false;
            menu.AutoScroll = false;
            this.Controls.Add(menu);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Profil formunu yükleme metodu
        private async void Profil_Load(object sender, EventArgs e)
        {
            string tcNo = Form1Main.UserInfo.tc; // Kullanıcının TC numarasını al
            Person person = await GetApiDataAsync(tcNo);
            int yas = Hesaplamalar.YasHesapla(person.DogumTarihi);
            label4.Text = $"{person.Isim}\r\n\r\n{person.KisiId}\r\n\r\n{yas}\r\n\r\n{(person.Cinsiyet == "1" ? "Erkek" : "Kadın")}\r\n\r\n{person.Boy}\r\n\r\n{person.Kilo}\r\n\r\n{person.TelNo}\r\n\r\n{person.KanGurubu}";
            label1.Text = $"Sağlıklı günler {person.Isim}!";
        }

        private void randevubuton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            BilgileriGuncelle BG = new BilgileriGuncelle
            {
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(1200, 750),
                AutoScroll = true
            };
            this.Size = new System.Drawing.Size(1200, 750);
            this.Controls.Add(BG);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            SifreniziGirin sg = new SifreniziGirin
            {
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(1200, 750),
                AutoScroll = false
            };
            this.Size = new System.Drawing.Size(1200, 750);
            this.AutoScroll = false;
            this.Controls.Add(sg);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

