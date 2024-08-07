using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
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
using System.Windows.Forms;
namespace RandevuSistem
{
    public partial class BilgileriGuncelle : UserControl
    {
        public BilgileriGuncelle()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(900, 500);
        }
        public class User
        {
            public User(string tcNumara, int kangrubu, int boy, int kilo, string telNo)
            {
                this.tcNumara = tcNumara;
                this.kanGurubu = kangrubu;
                this.boy = boy;
                this.kilo = kilo;
                TelNo = telNo;
            }
            public string tcNumara;
            public int kanGurubu;
            public int boy;
            public int kilo;
            public string TelNo;
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
        public static async Task UpdateUserAsync(User user)
        {
            var url = "http://localhost:5294/api/PersonControllers/Kullanici/BilgileriGuncelle"; // Kullanıcı ID'sini URL'e eklemiyoruz
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Profil profil = new Profil();
            profil.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            profil.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
            profil.AutoScroll = true;
            this.AutoScroll = false;
            this.Controls.Add(profil);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void BilgileriGuncelle_Load(object sender, EventArgs e)
        {
            List<string> kan = new List<string> { "0-", "0+", "A-", "A+", "B-", "B+", "AB-", "AB+" };

            foreach (string k in kan)
            {
                comboBox2.Items.Add(k);
            }
            string tcNo = Form1Main.UserInfo.tc; // Kullanıcının TC numarasını al
            Person person = await GetApiDataAsync(tcNo);
            int yas = Hesaplamalar.YasHesapla(person.DogumTarihi);
            label4.Text = $"{person.Isim}\r\n\r\n{person.KisiId}\r\n\r\n{yas}\r\n\r\n{(person.Cinsiyet == "1" ? "Erkek" : "Kadın")}";
            label1.Text = $"Sağlıklı günler {person.Isim}!";
        }

        private async void randevubuton_Click(object sender, EventArgs e)
        {
            int boy = Int32.Parse(textBox1.Text);
            int kilo = Int32.Parse(textBox2.Text);
            string telno = textBox3.Text;
            int kan = Hesaplamalar.GetKanGurubuId(comboBox2.Text);
            string tc = Form1Main.UserInfo.tc;
            DialogResult result = MessageBox.Show(
                "Bilgiler güncellensin mi?",
                "Onay Gerekli",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kullanıcının cevabını kontrol etme
            if (result == DialogResult.Yes)
            {
                if ((boy < 300) && (boy > 0) && (kilo > 0) && (kilo < 400))
                {
                    if ((textBox1.Text == null) && (textBox2.Text == null) && (textBox3.Text == null) && (comboBox2.Text == null))
                    {
                        MessageBox.Show("Hiçbir değişiklik yapılmadı.");
                    }
                    else
                    {
                        User user1 = new User(tc, kan, boy, kilo, telno);
                        await UpdateUserAsync(user1);
                    }
                }
                else MessageBox.Show("Lütfen geçerli veriler girin. ");
            }
            else
            {
                // Kullanıcı 'Hayır' dedi, işlemi iptal et
                MessageBox.Show("İşlem iptal edildi.");
            }
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
