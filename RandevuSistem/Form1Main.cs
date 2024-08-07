using RandevuSistem.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistem
{
    public partial class Form1Main : UserControl
    {
        public Form1Main()
        {
            InitializeComponent();

        }
        public class UserInfo
        {
            public static string tc { get; set; }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            Kayıt kayıt = new Kayıt();

            this.Controls.Add(kayıt);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text != "") && (this.textBox2.Text != ""))
            {
                string url = "http://localhost:5294/api/PersonControllers/Kullanici/Login";

                // JSON içeriği oluşturma
                var jsonContent = new StringContent(
                    $"{{\"tcNumara\": \"{textBox1.Text}\", \"sifre\": \"{textBox2.Text}\"}}",
                    Encoding.UTF8,
                    "application/json"
                );

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        // POST isteği gönderme
                        HttpResponseMessage response = await client.PostAsync(url, jsonContent);

                        // Yanıtı kontrol etme
                        if (response.IsSuccessStatusCode)
                        {
                            // Yanıtın içeriğini okuma
                            string responseData = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(responseData);
                            if (responseData == "true")

                            {

                                UserInfo.tc = textBox1.Text;

                                this.Controls.Clear();
                                MainMenu menu = new MainMenu();
                                menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
                                menu.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
                                this.Controls.Add(menu);

                            }
                            else
                            {
                                MessageBox.Show("Yanlış Tc veya şifre girildi");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Hata: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}");
                    }
                }
            }
            else
            {
                EksikBilgiGirdiniz eb = new EksikBilgiGirdiniz();
                eb.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            SifreDegistirme sd = new SifreDegistirme();
            sd.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            sd.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
            this.Controls.Add(sd);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1Main_Load(object sender, EventArgs e)
        {

        }
    }
}
