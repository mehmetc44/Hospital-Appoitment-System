using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RandevuSistem.Classes.DataClasses;
using RandevuSistem.Classes.Operations;

namespace RandevuSistem
{
    public partial class Kayıt : UserControl
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kayıt_Load(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form1Main menu = new Form1Main();
            menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            menu.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
            this.Controls.Add(menu);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox1.Text) &&
                !string.IsNullOrEmpty(this.textBox2.Text) &&
                !string.IsNullOrEmpty(this.textBox3.Text) &&
                !string.IsNullOrEmpty(this.textBox4.Text) &&
                !string.IsNullOrEmpty(this.dateTimePicker1.Text))
            {
                string ad = this.textBox3.Text;
                string tc = this.textBox1.Text;
                string tel = this.textBox2.Text;
                string sifree = this.textBox4.Text;
                string datee = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");

                bool cinsiyete = (comboBox1.Text== "Kadın")?false:true;

                int kangrubu = Hesaplamalar.GetKanGurubuId(comboBox2.Text);
                var person = new
                {
                    isim = ad,
                    tcNumara = tc,
                    telefonNo = tel,
                    sifre = sifree,
                    cinsiyet = cinsiyete,
                    dogumTarihi = datee
                };

                string url = "http://localhost:5294/api/PersonControllers/Kullanici/Register";

                var jsonContent = new StringContent(
                    Newtonsoft.Json.JsonConvert.SerializeObject(person),
                    Encoding.UTF8,
                    "application/json"
                );

                // JSON içeriğini kontrol etme
                string jsonString = await jsonContent.ReadAsStringAsync();
                MessageBox.Show($"Gönderilen JSON: {jsonString}");

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(url, jsonContent);

                        if ((response.IsSuccessStatusCode)&&(textBox4.Text == textBox5.Text))
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(responseData);
                            if (responseData.Contains("true"))
                            {
                                this.Controls.Clear();
                                Form1Main menu = new Form1Main();
                                menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
                                menu.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
                                this.Controls.Add(menu);

                            }
                            else
                            {
                                MessageBox.Show("Başarısız: " + responseData);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}");
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
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}