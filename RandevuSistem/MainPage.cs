using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RandevuSistem.Classes.DataClasses;
using RandevuSistem.Classes.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandevuSistem
{
    public partial class MainPage : UserControl
    {
        private Size OriginalSize;
        private Rectangle recPanel1;
        private Rectangle recPanel2;
        private Rectangle recPanel3;
        private Rectangle recPanel4;
        private Rectangle recPanel5;
        private Rectangle recPanel6;

        private Rectangle recLbl1;
        private Rectangle recLbl2;
        private Rectangle recLbl3;
        private Rectangle recLbl4;
        private Rectangle recLbl5;
        private Rectangle recLbl6;
        private Rectangle recLbl7;
        private Rectangle recLbl8;
        private Rectangle recLbl9;
        private Rectangle recLbl10;
        private Rectangle recLbl11;
        private Rectangle recLbl12;
        private Rectangle recLink;

        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recPic1;
        private Rectangle recCal;
        private Size OriginalPanel1;
        private Size OriginalPanel3;
        private Person person;
        public MainPage()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            OriginalSize = this.Size;
            OriginalPanel1 = modernPanel1.Size;
            OriginalPanel3 = modernPanel3.Size;
            recPanel1 = new Rectangle(modernPanel1.Location, modernPanel1.Size);
            recPanel6 = new Rectangle(modernPanel3.Location, modernPanel3.Size);
            recLbl1 = new Rectangle(label1.Location, label1.Size);
            recLbl2 = new Rectangle(label10.Location, label10.Size);
            recPanel2 = new Rectangle(panel1.Location, panel1.Size);
            recPanel3 = new Rectangle(panel2.Location, panel2.Size);
            recPanel4 = new Rectangle(panel3.Location, panel3.Size);
            recPanel5 = new Rectangle(panel4.Location, panel4.Size);
            recLink = new Rectangle(linkLabel1.Location, linkLabel1.Size);
            recLbl3 = new Rectangle(Yas.Location, Yas.Size);
            recLbl4 = new Rectangle(Yastxt.Location, Yastxt.Size);
            recLbl5 = new Rectangle(label2.Location, label2.Size);
            recLbl6 = new Rectangle(label3.Location, label3.Size);
            recLbl7 = new Rectangle(label4.Location, label4.Size);
            recLbl8 = new Rectangle(label5.Location, label5.Size);
            recLbl9 = new Rectangle(label6.Location, label6.Size);
            recLbl10 = new Rectangle(label7.Location, label7.Size);
            recLbl11 = new Rectangle(label14.Location, label14.Size);
            recLbl12 = new Rectangle(label15.Location, label15.Size);
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recBut2 = new Rectangle(button3.Location, button3.Size);
            recBut3 = new Rectangle(button4.Location, button4.Size);
            recPic1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recCal = new Rectangle(monthCalendar1.Location, monthCalendar1.Size);

        }
        private void MainPage_Resize(object sender, EventArgs e)
        {
            int x = Math.Abs(this.Width - OriginalSize.Width);
            int y = Math.Abs(this.Height - OriginalSize.Height);

            if ((x + y) > 10)
            {
                textBox2.Location = label7.Location;
                textBox3.Location = label5.Location;
                textBox4.Location = label3.Location;
                textBox2.Size = label7.Size;
                textBox3.Size = label5.Size;
                textBox4.Size = label3.Size;
                resize_Panel1(modernPanel1, recPanel1);
                resize_Control_nosize(label1, recLbl1);
                resize_elements_Panel1_nosize(label10, recLbl2);
                resize_elements_Panel1_nosize(linkLabel1, recLink);

                resize_elements_Panel1(panel1, recPanel2);
                resize_elements_Panel1(panel2, recPanel3);
                resize_elements_Panel1(panel3, recPanel4);
                resize_elements_Panel1(panel4, recPanel5);
                resize_elements_Panel1_panels(Yas, recLbl3);
                resize_elements_Panel1_panels(Yastxt, recLbl4);
                resize_elements_Panel1_panels(label2, recLbl5);
                resize_elements_Panel1_panels(label3, recLbl6);
                resize_elements_Panel1_panels(label4, recLbl7);
                resize_elements_Panel1_panels(label5, recLbl8);
                resize_elements_Panel1_panels(label6, recLbl9);
                resize_elements_Panel1_panels(label7, recLbl10);
                resize_Panel2(modernPanel3, recPanel6);
                resize_elements_Panel2_nosize(label14, recLbl11);
                resize_elements_Panel2_nosize(label15, recLbl12);
                resize_elements_Panel2(button1, recBut1);
                resize_elements_Panel2(pictureBox1, recPic1);
                resize_Panel1(monthCalendar1, recCal);
            }
        }
        private void resize_elements_Panel1(Control c, Rectangle r)
        {
            float xRatio = (float)(modernPanel1.Width) / (float)(OriginalPanel1.Width);
            float yRatio = (float)(modernPanel1.Height) / (float)(OriginalPanel1.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void resize_elements_Panel2(Control c, Rectangle r)
        {
            float xRatio = (float)(modernPanel3.Width) / (float)(OriginalPanel3.Width);
            float yRatio = (float)(modernPanel3.Height) / (float)(OriginalPanel3.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void resize_Panel2(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newX = (int)(modernPanel1.Width + modernPanel1.Location.X + (20 * xRatio));
            int newY = (int)modernPanel1.Location.Y;
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void resize_elements_Panel2_nosize(Label c, Rectangle r)
        {
            float yRatio = (float)(modernPanel3.Height) / (float)(OriginalPanel3.Height);
            c.Font = new Font(c.Font.FontFamily, c.Font.Size * yRatio, FontStyle.Bold);
            int newX = (modernPanel3.Width - c.Width) / 2;
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
            c.AutoSize = true;

            // Ekran boyutlarına bağlı olarak minimum ve maksimum font boyutları belirle
            if (c.Font.Size < 8)
                c.Font = new Font(c.Font.FontFamily, 8, FontStyle.Bold);
            else if (c.Font.Size > 24)
                c.Font = new Font(c.Font.FontFamily, 24, FontStyle.Bold);
        }
        private void resize_elements_Panel1_nosize(Control c, Rectangle r)
        {
            float yRatio = (float)(modernPanel1.Height) / (float)(OriginalPanel1.Height);
            int newX = (modernPanel1.Width - c.Width) / 2;
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
        }
        private void resize_elements_Panel1_panels(Control c, Rectangle r)
        {
            float yRatio = (float)(modernPanel1.Height) / (float)(OriginalPanel1.Height);
            c.Font = new Font(c.Font.FontFamily, c.Font.Size * yRatio, FontStyle.Bold);

            int newX = (panel1.Width - c.Width) / 2;
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
        }

        private void resize_Control_nosize(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
        }
        private void resize_Panel1(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private async void MainPage_Load(object sender, EventArgs e)
        {
            person = new Person();
            person = await GetApiDataAsync(Form1Main.UserInfo.tc);
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            Yas.Text = Hesaplamalar.YasHesapla(person.DogumTarihi).ToString();
            label5.Text = person.Kilo;
            label7.Text = Hesaplamalar.GetKanGurubuById(Int32.Parse(person.KanGurubu));
            label3.Text = person.Boy;
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox2.Location = label7.Location;
            textBox3.Location = label5.Location;
            textBox4.Location = label3.Location;
            textBox2.Size = new Size(105, 60);
            textBox3.Size = new Size(105, 60);
            textBox4.Size = new Size(105, 60);
            button3.Visible = true;
            button4.Visible = true;
            linkLabel1.Visible = false;

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
        private async void button3_Click(object sender, EventArgs e)
        {
            person = new Person();
            person = await GetApiDataAsync(Form1Main.UserInfo.tc);
            int boy = Int32.Parse(textBox4.Text);
            int kilo = Int32.Parse(textBox3.Text);
            string telno = person.TelNo;
            int kanId = Hesaplamalar.GetKanGurubuId(textBox2.Text);
            MessageBox.Show(telno + kanId.ToString());
            string tc = Form1Main.UserInfo.tc;
            DialogResult result = MessageBox.Show(
                "Bilgiler güncellensin mi?",
                "Onay Gerekli",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                if ((boy < 300) && (boy > 0) && (kilo > 0) && (kilo < 400))
                {
                    if ((textBox4.Text == person.Boy) && (textBox2.Text == Hesaplamalar.GetKanGurubuById(kanId)) && (textBox3.Text == person.Kilo))
                    {
                        MessageBox.Show("Hiçbir değişiklik yapılmadı.");
                    }
                    else
                    {
                        User user1 = new User(tc, kanId, boy, kilo, telno);
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            linkLabel1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double indeks = double.Parse(label5.Text) / (double.Parse(label3.Text) * double.Parse(label3.Text)*0.0001);
            
            label15.Text = indeks.ToString("0.#");
        }
    }
}
