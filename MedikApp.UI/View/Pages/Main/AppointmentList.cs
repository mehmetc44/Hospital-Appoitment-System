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
using MedikApp.UI.View.Shared;
using MedikApp.UI.Models;
using MedikApp.UI.Helpers;
namespace MedikApp.UI
{
    public partial class AppointmentList : UserControl
    {
        public AppointmentList()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
        List<MedikApp.UI.Models.Randevu> randevular;
        private async Task<List<MedikApp.UI.Models.Randevu>> GetRandevular(string tc)
        {

            string url = $"http://localhost:5294/RandevuControllers/RandevularıGetir?TcNumara={tc}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    List<MedikApp.UI.Models.Randevu> rndv;
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        rndv = new List<MedikApp.UI.Models.Randevu>();
                        rndv = JsonConvert.DeserializeObject<List<MedikApp.UI.Models.Randevu>>(res);

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
        private void Randevularım_Resize(object sender, EventArgs e)
        {
            if (this.Height > panel1.Height)
            {
                panel1.Height = this.Height;
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
        List<AppointmentDetail> rndvGbs;
        private async void Randevularım_Load(object sender, EventArgs e)
        {
            randevular = await GetRandevular(LogIn.UserInfo.tc);
            int sayi = 1;
            int y = 230;
            foreach (MedikApp.UI.Models.Randevu randevu in randevular)
            {
                int sonuc = Helper.TarihKarsilastir(randevu.tarih, DateTime.Now.ToString());
                if (sonuc >= 0)
                {

                    AppointmentDetail randevularımgb1 = new AppointmentDetail();
                    randevularımgb1.Location = new Point(90, y);
                    randevularımgb1.Name = $"randevularımgb1";
                    panel1.Controls.Add(randevularımgb1);
                    randevularımgb1.RandevuIptalButon.Tag = randevu.id;
                    randevularımgb1.label5.Text = randevu.doktorIsim;
                    randevularımgb1.label6.Text = Helper.GetBolumDescription(randevu.bolumId);
                    randevularımgb1.label7.Text = randevu.tarih;
                    randevularımgb1.label8.Text = randevu.il;
                    randevularımgb1.groupBox1.Text = randevu.hastane;
                    y += 180;
                    if ((y + randevularımgb1.Height) > panel1.Height)
                    {
                        panel1.Height = y + randevularımgb1.Height + 20;
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
                Size = new System.Drawing.Size(1200, 750)
            };
            this.AutoScroll = false;
            menu.AutoScroll = false;
            this.Controls.Add(menu);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        
    }
}
