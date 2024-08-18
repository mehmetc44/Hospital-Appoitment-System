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

        private Size OriginalSize;
        private Rectangle recBut1;
        private Rectangle recBut2;
        private Rectangle recTxt1;
        private Rectangle recTxt2;
        private Rectangle recTxt3;
        private Rectangle recTxt4;
        private Rectangle recTxt5;
        private Rectangle recCombo1;
        private Rectangle recCombo2;
        private Rectangle recDate;
        private Rectangle recLbl1;
        private Rectangle recLbl2;
        private Rectangle recLbl3;
        private Rectangle recLbl4;
        private Rectangle recLbl5;
        private Rectangle recLbl6;
        private Rectangle recLbl7;
        private Rectangle recLbl8;
        public Kayıt()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Resize += Kayıt_Resize;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            OriginalSize = this.Size;
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recBut2 = new Rectangle(button2.Location, button2.Size);
            recTxt1 = new Rectangle(textBox1.Location, textBox1.Size);
            recTxt2 = new Rectangle(textBox2.Location, textBox2.Size);
            recTxt3 = new Rectangle(textBox3.Location, textBox3.Size);
            recTxt4 = new Rectangle(textBox4.Location, textBox4.Size);
            recTxt5 = new Rectangle(textBox5.Location, textBox5.Size);
            recCombo1 = new Rectangle(comboBox1.Location, comboBox1.Size);
            recCombo2 = new Rectangle(comboBox2.Location, comboBox2.Size);
            recDate = new Rectangle(dateTimePicker1.Location, dateTimePicker1.Size);
            recLbl1 = new Rectangle(label1.Location, label1.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recLbl3 = new Rectangle(label3.Location, label3.Size);
            recLbl4 = new Rectangle(label4.Location, label4.Size);
            recLbl5 = new Rectangle(label5.Location, label5.Size);
            recLbl6 = new Rectangle(label6.Location, label6.Size);
            recLbl8 = new Rectangle(label8.Location, label8.Size);
            recLbl7 = new Rectangle(label7.Location, label7.Size);
        }
        private void Kayıt_Resize(object sender, EventArgs e)
        {
            resize_Control(button1, recBut1);
            resize_Control(button2, recBut2);
            resize_Control(textBox1, recTxt1);
            resize_Control(textBox2, recTxt2);
            resize_Control(textBox3, recTxt3);
            resize_Control(textBox4, recTxt4);
            resize_Control(textBox5, recTxt5);
            resize_Control(comboBox1, recCombo1);
            resize_Control(comboBox2, recCombo2);
            resize_Control(dateTimePicker1, recDate);
            resize_Control_nosize(label1, recLbl1);
            resize_Control_nosize(label2, recLbl2);
            resize_Control_nosize(label3, recLbl3);
            resize_Control_nosize(label4, recLbl4);
            resize_Control_nosize(label5, recLbl5);
            resize_Control_nosize(label6, recLbl6);
            resize_Control_nosize(label7, recLbl7);
            resize_Control_nosize(label8, recLbl8);

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
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form1Main menu = new Form1Main();
            menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            menu.Size = new System.Drawing.Size(1200, 750); // Boyutu belirleyin
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

                bool cinsiyete = (comboBox1.Text == "Kadın") ? false : true;

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

                        if ((response.IsSuccessStatusCode) && (textBox4.Text == textBox5.Text))
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
        private void modernButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form1Main menu = new Form1Main();
            menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            menu.Size = this.Parent.Size;// Boyutu belirleyin
            this.Controls.Add(menu);
        }

        private void modernButton1_MouseEnter(object sender, EventArgs e)
        {
            modernButton1.BackColor = Color.FromArgb(148, 148, 137);
        }

        private void modernButton1_MouseLeave(object sender, EventArgs e)
        {
            modernButton1.BackColor = Color.Transparent;
        }

    }
}