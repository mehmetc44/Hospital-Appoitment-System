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
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandevuSistem 
{


    public partial class Profil : UserControl
    {
        private Size OriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recBut3;
        private Rectangle recBut4;
        private Rectangle recTxt1;
        private Rectangle recTxt2;
        private Rectangle recTxt4;
        private Rectangle recTxt5;
        private Rectangle recCombo1;
        private Rectangle recPic;
        private Rectangle recLbl1;
        private Rectangle recLbl2;
        private Rectangle recLbl5;
        private Rectangle recLbl6;
        private Rectangle recLbl7;
        public Rectangle recPanel;
        private Size originalParentSize;
        private Size originalPanelSize;
        private Person person;
        private SifreniziGirin sg;

        public Profil(SifreniziGirin sg)
        {
            this.sg = sg;
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Resize += Profil_Resize;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            OriginalSize = this.Size;
            originalPanelSize = panel1.Size;
            button3.Visible = false;
            button4.Visible = false;
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recBut2 = new Rectangle(button2.Location, button2.Size);
            recBut3 = new Rectangle(button3.Location, button3.Size);
            recBut4 = new Rectangle(button4.Location, button4.Size);
            recTxt1 = new Rectangle(textBox1.Location, textBox1.Size);
            recTxt2 = new Rectangle(textBox2.Location, textBox2.Size);
            recTxt4 = new Rectangle(textBox4.Location, textBox4.Size);
            recTxt5 = new Rectangle(textBox5.Location, textBox5.Size);
            recCombo1 = new Rectangle(comboBox1.Location, comboBox1.Size);
            recLbl1 = new Rectangle(label1.Location, label1.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recLbl5 = new Rectangle(label5.Location, label5.Size);
            recLbl6 = new Rectangle(label6.Location, label6.Size);
            recLbl7 = new Rectangle(label7.Location, label7.Size);
            recPanel = new Rectangle(panel1.Location, panel1.Size);
        }
        private void Profil_Resize(object sender, EventArgs e)
        {
            resize_Control(button1, recBut1);
            resize_Control(button2, recBut2);
            resize_Control(button3, recBut3);
            resize_Control(button4, recBut4);
            resize_Control(textBox1, recTxt1);
            resize_Control(textBox2, recTxt2);
            resize_Control(textBox4, recTxt4);
            resize_Control(textBox5, recTxt5);
            resize_Control(comboBox1, recCombo1);
            resize_Control_nosize(label1, recLbl1);
            resize_Control_nosize(label2, recLbl2);
            resize_Control_nosize(label5, recLbl5);
            resize_Control_nosize(label6, recLbl6);
            resize_Control_nosize(label7, recLbl7);
            resize_Control_noLocation(panel1, recPanel);


        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * Math.Sqrt(xRatio));
            int newHeight = (int)(r.Height * Math.Sqrt(yRatio) * 1.3);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        public void resize_Control_noLocation(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(OriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(OriginalSize.Height);
            int newHeight = (int)(r.Height * yRatio);
            c.Size = new Size(this.Width, newHeight);

        }
        private void resize_Control_Parent(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Parent.Width) / (float)(originalParentSize.Width);
            float yRatio = (float)(this.Parent.Height) / (float)(originalParentSize.Height);
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



        // Profil formunu yükleme metodu
        private string kan;
        private async void Profil_Load(object sender, EventArgs e)
        {
            this.Size = this.Parent.Size;
            string tcNo = Form1Main.UserInfo.tc; // Kullanıcının TC numarasını al
            person = await GetApiDataAsync(tcNo);
            int yas = Hesaplamalar.YasHesapla(person.DogumTarihi);
            textBox1.Text = person.Isim.ToString();
            textBox2.Text = person.KisiId.ToString();
            textBox4.Text = person.TelNo.ToString();
            textBox5.Text = (person.Cinsiyet == "1" ? "Erkek" : "Kadın");
            kan = Hesaplamalar.GetKanGurubuById(Int32.Parse(person.KanGurubu));
            comboBox1.Text = kan;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sg.Show();
        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Text = kan;
                comboBox1.SelectionStart = comboBox1.Text.Length; // İmleci sona taşı
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
            textBox4.BorderStyle = BorderStyle.Fixed3D;
            for (int i = 0; i <= 8; i++)
            {
                comboBox1.Items.Add(Hesaplamalar.GetKanGurubuById(i));
            }
            button3.Visible = true;
            button4.Visible = true;
            button3.Location = button2.Location;
            button4.Location = button1.Location;
            this.button1.Visible = false;
            this.button2.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
            textBox4.BorderStyle = BorderStyle.None;
            comboBox1.Items.Clear();
            textBox4.Text = person.TelNo.ToString();
            kan = Hesaplamalar.GetKanGurubuById(Int32.Parse(person.KanGurubu));
            comboBox1.Text = kan;
            button3.Visible = false;
            button4.Visible = false;
            button2.Location = button3.Location;
            button1.Location = button4.Location;
            this.button1.Visible = true;
            this.button2.Visible = true;
            MessageBox.Show("İşlem iptal edildi.");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int boy = Int32.Parse(person.Boy);
            int kilo = Int32.Parse(person.Kilo);
            string telno = textBox4.Text;
            int kanId = Hesaplamalar.GetKanGurubuId(comboBox1.Text);
            MessageBox.Show(telno+kanId);
            string tc = Form1Main.UserInfo.tc;
            DialogResult result = MessageBox.Show(
                "Bilgiler güncellensin mi?",
                "Onay Gerekli",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                
                if ((textBox4.Text == person.TelNo) && (comboBox1.Text == kan))
                {
                    MessageBox.Show("Hiçbir değişiklik yapılmadı.");
                }
                else
                {
                    User user1 = new User(tc, kanId, boy, kilo, telno);
                    await UpdateUserAsync(user1);
                }
                
            }
            else
            {
                // Kullanıcı 'Hayır' dedi, işlemi iptal et
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            this.Size = this.Parent.Size;
        }
    }
}

