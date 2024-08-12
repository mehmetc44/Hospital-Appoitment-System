using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RandevuSistem.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RandevuSistem.Form1Main;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandevuSistem
{
    public partial class RandevuAL : UserControl
    {
        private static readonly HttpClient client = new HttpClient();

        public RandevuAL()
        {
            InitializeComponent();

            this.Load += new EventHandler(RandevuAL_Load);
        }

        List<Klinikler> klinikler = null;
        List<Sehirler> sehirler = null;
        List<Hastaneler> hastaneler = null;
        List<Doktorlar> doktorlar = null;
        Klinikler secilenKlinik;
        Doktorlar secilenDoktor;
        Hastaneler secilenHastane;
        Sehirler secilenSehir;
        string tarih;
        RandevuBilgileri randevuBilgileri;


        private async Task<List<Sehirler>> GetSehirler()
        {

            string url = "http://localhost:5294/RandevuControllers/Iller";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    List<Sehirler> iller;
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        iller = new List<Sehirler>();
                        iller = JsonConvert.DeserializeObject<List<Sehirler>>(res);

                        return iller;
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

        private async Task<List<Hastaneler>> GetHastaneler(string sehirAdi)
        {
            string url = $"http://localhost:5294/RandevuControllers/Hastaneler?SehirIsmi={sehirAdi}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    List<Hastaneler> hastaneler;
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        hastaneler = new List<Hastaneler>();
                        hastaneler = JsonConvert.DeserializeObject<List<Hastaneler>>(res);

                        return hastaneler;
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

        private async Task<List<Klinikler>> GetKlinik()
        {
            string url = "http://localhost:5294/RandevuControllers/Klinikler";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    List<Klinikler> klinikler;
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        klinikler = new List<Klinikler>();
                        klinikler = JsonConvert.DeserializeObject<List<Klinikler>>(res);

                        return klinikler;
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
        private async Task<List<Doktorlar>> GetDoktor(string hastaneId, string klinikId)
        {
            string url = $"http://localhost:5294/RandevuControllers/Doktorlar?hastaneId={hastaneId}&bolumId={klinikId}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    List<Doktorlar> doktorlar;
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();
                        doktorlar = new List<Doktorlar>();
                        doktorlar = JsonConvert.DeserializeObject<List<Doktorlar>>(res);

                        return doktorlar;
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






        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void ILGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private async void RandevuAL_Load(object sender, EventArgs e)
        {

            sehirler = await GetSehirler();
            foreach (Sehirler il in sehirler)
            {
                ILcomboBox.Items.Add(il.sehirAd);
            }

        }

        private void panel1_Paint_3(object sender, PaintEventArgs e)
        {

        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenSehir = sehirler[ILcomboBox.SelectedIndex];
            HastaneCombobox.Items.Clear();
            KlinikcomboBox.Items.Clear();
            DRcomboBox.Items.Clear();
            HastaneCombobox.Text = "";
            KlinikcomboBox.Text = "";
            DRcomboBox.Text = "";
            hastaneler = await GetHastaneler(ILcomboBox.Text);
            foreach (Hastaneler hastane in hastaneler)
            {
                HastaneCombobox.Items.Add(hastane.hastane); ;
            }

        }

        private async void HastaneCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenHastane = hastaneler[HastaneCombobox.SelectedIndex];
            klinikler = await GetKlinik();
            KlinikcomboBox.Items.Clear();
            DRcomboBox.Items.Clear();
            KlinikcomboBox.Text = "";
            DRcomboBox.Text = "";
            foreach (Klinikler klinik in klinikler)
            {
                KlinikcomboBox.Items.Add(klinik.klinikAdi);
            }
        }

        private async void KlinikcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKlinik = klinikler[KlinikcomboBox.SelectedIndex];
            doktorlar = await GetDoktor(secilenHastane.id.ToString(), secilenKlinik.id.ToString());
            DRcomboBox.Items.Clear();
            DRcomboBox.Text = "";
            foreach (Doktorlar dr in doktorlar)
            {
                DRcomboBox.Items.Add(dr.doktorIsim);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Value.Date.ToString();
            MessageBox.Show(tarih);
        }

        private void DRcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenDoktor = doktorlar[DRcomboBox.SelectedIndex];
            secilenDoktor.hastaneId = secilenHastane.id;
            secilenDoktor.bolumId = secilenKlinik.id;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if ((tarih == null) || (secilenSehir == null) || (secilenDoktor == null) || (secilenHastane == null) || (secilenKlinik == null))
            {
                MessageBox.Show("Eksik Bilgi girdiniz.");
            }
            else
            {
                string apiUrl = "http://localhost:5294/RandevuControllers/RandevuOluştur";

                var jsonContent = new StringContent(
                        $"{{\"tcNumarası\": \"{Form1Main.UserInfo.tc}\", \"doktorId\": \"{secilenDoktor.id}\",\"tarih\": \"{this.tarih.Split(" ")[0]}\"}}",
                        Encoding.UTF8,
                        "application/json"
                    );
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(apiUrl, jsonContent);
                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(responseData);
                            if (responseData == "true")
                            {
                                MessageBox.Show("Randevunuz başarıyla oluşturuldu.");
                                randevuBilgileri = new RandevuBilgileri(secilenDoktor, secilenHastane, secilenKlinik, secilenSehir);
                            }
                            else
                            {
                                MessageBox.Show("Bilgilerinizi kontrol edin.");
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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
    }
}