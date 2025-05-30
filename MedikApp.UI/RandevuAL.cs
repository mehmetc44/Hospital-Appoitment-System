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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace RandevuSistem
{
    public partial class RandevuAL : UserControl
    {
        private Size OriginalSize;
        private Rectangle recBut1;
        private Rectangle recCombo1;
        private Rectangle recCombo2;
        private Rectangle recCombo3;
        private Rectangle recCombo4;
        private Rectangle recDate;
        private Rectangle recLbl1;
        private Rectangle recLbl7;
        private Rectangle recLbl3;
        private Rectangle recLbl4;
        private Rectangle recLbl5;
        private Rectangle recLbl6;

        public RandevuAL()
        {
            InitializeComponent();
            this.Load += new EventHandler(RandevuAL_Load);

            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            OriginalSize = this.Size;
            recBut1 = new Rectangle(button3.Location, button3.Size);
            recCombo1 = new Rectangle(IlcomboBox.Location, IlcomboBox.Size);
            recCombo2 = new Rectangle(HastaneComboBox1.Location, HastaneComboBox1.Size);
            recCombo3 = new Rectangle(KlinikComboBox.Location, KlinikComboBox.Size);
            recCombo4 = new Rectangle(DRcomboBox.Location, DRcomboBox.Size);
            recDate = new Rectangle(dateTimePicker1.Location, dateTimePicker1.Size);
            recLbl1 = new Rectangle(label1.Location, label1.Size);
            recLbl3 = new Rectangle(label3.Location, label3.Size);
            recLbl4 = new Rectangle(label4.Location, label4.Size);
            recLbl5 = new Rectangle(label5.Location, label5.Size);
            recLbl6 = new Rectangle(label6.Location, label6.Size);
            recLbl7 = new Rectangle(label7.Location, label7.Size);
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
        private void RandevuAL_Resize(object sender, EventArgs e)
        {
            resize_Control(button3, recBut1);
            resize_Control(IlcomboBox, recCombo1);
            resize_Control(HastaneComboBox1, recCombo2);
            resize_Control(KlinikComboBox, recCombo3);
            resize_Control(DRcomboBox, recCombo4);
            resize_Control(dateTimePicker1, recDate);
            resize_Control_nosize(label1, recLbl1);
            resize_Control_nosize(label3, recLbl3);
            resize_Control_nosize(label4, recLbl4);
            resize_Control_nosize(label5, recLbl5);
            resize_Control_nosize(label6, recLbl6);
            resize_Control_nosize(label7, recLbl7);
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
        private async void RandevuAL_Load(object sender, EventArgs e)
        {

            sehirler = await GetSehirler();
            foreach (Sehirler il in sehirler)
            {
                IlcomboBox.Items.Add(il.sehirAd);
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Value.Date.ToString();
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu işlemi gerçekleştirmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
                                    MessageBox.Show("Randevu başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (result == DialogResult.No)
            {
                // Kullanıcı "Hayır"ı seçtiğinde yapılacak işlemler
                MessageBox.Show("İşlem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private async void IlcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenSehir = sehirler[IlcomboBox.SelectedIndex];
            HastaneComboBox1.Items.Clear();
            KlinikComboBox.Items.Clear();
            DRcomboBox.Items.Clear();
            HastaneComboBox1.Text = "";
            KlinikComboBox.Text = "";
            DRcomboBox.Text = "";
            hastaneler = await GetHastaneler(IlcomboBox.Text);
            foreach (Hastaneler hastane in hastaneler)
            {
                HastaneComboBox1.Items.Add(hastane.hastane); ;
            }
        }

        private async void HastaneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenHastane = hastaneler[HastaneComboBox1.SelectedIndex];
            klinikler = await GetKlinik();
            KlinikComboBox.Items.Clear();
            DRcomboBox.Items.Clear();
            KlinikComboBox.Text = "";
            DRcomboBox.Text = "";
            foreach (Klinikler klinik in klinikler)
            {
                KlinikComboBox.Items.Add(klinik.klinikAdi);
            }
        }
        private async void KlinikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKlinik = klinikler[KlinikComboBox.SelectedIndex];
            doktorlar = await GetDoktor(secilenHastane.id.ToString(), secilenKlinik.id.ToString());
            DRcomboBox.Items.Clear();
            DRcomboBox.Text = "";
            foreach (Doktorlar dr in doktorlar)
            {
                DRcomboBox.Items.Add(dr.doktorIsim);
            }
        }

        private void DRcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            secilenDoktor = doktorlar[DRcomboBox.SelectedIndex];
            secilenDoktor.hastaneId = secilenHastane.id;
            secilenDoktor.bolumId = secilenKlinik.id;
        }

        
    }
}