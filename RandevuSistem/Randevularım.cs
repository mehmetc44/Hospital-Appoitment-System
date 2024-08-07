using Newtonsoft.Json;
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
using RandevuSistem.Classes.Operations;
namespace RandevuSistem
{
    public partial class Randevularım : UserControl
    {
        public Randevularım()
        {
            InitializeComponent();
        }
        List<Randevular> randevular;
        private async Task<List<Randevular>> GetRandevular(string tc)
        {

            string url = $"http://localhost:5294/RandevuControllers/RandevularıGetir?TcNumara={tc}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    List<Randevular> rndv;
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        rndv = new List<Randevular>();
                        rndv = JsonConvert.DeserializeObject<List<Randevular>>(res);

                        return rndv;
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


        private void kayıt1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }
        List<RandevularımGB> rndvGbs;
        private async void Randevularım_Load(object sender, EventArgs e)
        {
            randevular = await GetRandevular(Form1Main.UserInfo.tc);
            int sayi = 1;
            int x = 80;
            int y = 290;
            foreach (Randevular randevu in randevular)
            {
                int sonuc = Hesaplamalar.TarihKarsilastir(randevu.tarih, DateTime.Now.ToString());
                if (sonuc >= 0)
                {
                    RandevularımGB randevularımgb1 = new RandevularımGB();
                    randevularımgb1.Location = new Point(x, y);
                    randevularımgb1.Name = $"randevularımgb1";
                    randevularımgb1.Size = new Size(358, 160);
                    randevularımgb1.TabIndex = 60;
                    panel1.Controls.Add(randevularımgb1);
                    randevularımgb1.RandevuIptalButon.Tag = randevu.id;
                    randevularımgb1.label2.Text = $"{Hesaplamalar.GetBolumDescription(randevu.bolumId)}\r\n\r\n{randevu.tarih}\r\n\r\n{randevu.doktorIsim}";
                    randevularımgb1.groupBox1.Text = randevu.hastane;
                    if (x > 180)
                    {
                        x = 80;
                        y += 190;
                    }
                    else
                    {
                        x += 380;
                    }

                }


            }
        }

        private void randevularımgb2_Load(object sender, EventArgs e)
        {

        }

        private void randevularımgb1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu menu = new MainMenu
            {
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(900, 550)
            };
            this.AutoScroll = false;
            menu.AutoScroll = false;
            this.Controls.Add(menu);
        }
    }
}
