using Newtonsoft.Json;
using RandevuSistem.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace RandevuSistem
{
    public partial class TalepGonder : UserControl
    {
        private Size OriginalSize;
        private Rectangle recBut1;
        private Rectangle recCombo1;
        private Rectangle recCombo2;
        private Rectangle recCombo3;
        private Rectangle recCombo4;
        private Rectangle recDate;
        private Rectangle recLbl8;
        private Rectangle recLbl7;
        private Rectangle recLbl3;
        private Rectangle recLbl4;
        private Rectangle recLbl5;
        private Rectangle recLbl6;
        public TalepGonder()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            OriginalSize = this.Size;
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recCombo1 = new Rectangle(ILcomboBox.Location, ILcomboBox.Size);
            recCombo2 = new Rectangle(HastaneCombobox.Location, HastaneCombobox.Size);
            recCombo3 = new Rectangle(KlinikcomboBox.Location, KlinikcomboBox.Size);
            recCombo4 = new Rectangle(DRcomboBox.Location, DRcomboBox.Size);
            recDate = new Rectangle(dateTimePicker2.Location, dateTimePicker2.Size);
            recLbl8 = new Rectangle(label8.Location, label8.Size);
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
        private void TalepGonder_Resize(object sender, EventArgs e)
        {
            resize_Control(button1, recBut1);
            resize_Control(ILcomboBox, recCombo1);
            resize_Control(HastaneCombobox, recCombo2);
            resize_Control(KlinikcomboBox, recCombo3);
            resize_Control(DRcomboBox, recCombo4);
            resize_Control(dateTimePicker2, recDate);
            resize_Control_nosize(label8, recLbl8);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainMenu menu = new MainMenu();
            menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            menu.Size = new System.Drawing.Size(1200, 750); // Boyutu belirleyin
            this.AutoScroll = false;
            menu.AutoScroll = false;
            this.Controls.Add(menu);
        }

        private async void TalepGonder_Load(object sender, EventArgs e)
        {
            sehirler = await GetSehirler();
            foreach (Sehirler il in sehirler)
            {
                ILcomboBox.Items.Add(il.sehirAd);
            }
        }

        private async void ILcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private async void HastaneCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void KlinikcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DRcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((tarih == null) || (secilenSehir == null) || (secilenDoktor == null) || (secilenHastane == null) || (secilenKlinik == null))
            {
                MessageBox.Show("Eksik Bilgi girdiniz.");
            }
            else
            {
                string apiUrl = "http://localhost:5294/RandevuControllers/RandevuTalep";

                var jsonContent = new StringContent(
                        $"{{\"tcNumarası\": \"{Int32.Parse(Form1Main.UserInfo.tc)}\", \"doktorId\": \"{secilenDoktor.id}\",\"tarih\": \"{this.tarih.Split(" ")[0]}\"}}",
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
                                MessageBox.Show("Randevu talebiniz başarıyla oluşturuldu.");
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
                    string apiUrl = "http://localhost:5294/RandevuControllers/RandevuTalep";

                    var jsonContent = new StringContent(
                            $"{{\"tcNumarası\": \"{Int32.Parse(Form1Main.UserInfo.tc)}\", \"doktorId\": \"{secilenDoktor.id}\",\"tarih\": \"{this.tarih.Split(" ")[0]}\"}}",
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
                                if (responseData == "true")
                                {
                                    MessageBox.Show("Talep başarıyla gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
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

        private async void HastaneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenDoktor = doktorlar[DRcomboBox.SelectedIndex];
            secilenDoktor.hastaneId = secilenHastane.id;
            secilenDoktor.bolumId = secilenKlinik.id;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            tarih = dateTimePicker2.Value.Date.ToString();
            MessageBox.Show(tarih);
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        
    }
}
