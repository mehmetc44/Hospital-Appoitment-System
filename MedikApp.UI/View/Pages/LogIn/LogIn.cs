using System.Text;
using System.Windows.Forms;
using MedikApp.UI.View.Shared;
namespace MedikApp.UI
{
    public partial class LogIn : UserControl
    {

        public LogIn()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.Resize += LogIn_Resize;
            this.Dock = DockStyle.Fill;
            this.panel1.Width = (this.Width * 4) / 10;
        }



        private void LogIn_Resize(object sender, EventArgs e)
        {

        }

        public class UserInfo
        {
            public static string tc { get; set; }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text != "") && (this.textBox2.Text != ""))
            {
                string url = "http://localhost:5294/api/PersonControllers/Kullanici/Login";
                var jsonContent = new StringContent(
                    $"{{\"tcNumara\": \"{textBox1.Text}\", \"sifre\": \"{textBox2.Text}\"}}",
                    Encoding.UTF8,
                    "application/json"
                );

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(url, jsonContent);
                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(responseData);
                            if (responseData == "true")
                            {
                                UserInfo.tc = textBox1.Text;
                                this.Controls.Clear();
                                MainMenu menu = new MainMenu();
                                menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
                                menu.Size = this.Parent.Size; // Boyutu belirleyin
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
            else { MessageBox.Show("Eksik bilgi girdiniz."); }
        }
        private void Form1Main_Load(object sender, EventArgs e)
        {
            this.Size = this.Parent.Size;

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            ForgotPassword sd = new ForgotPassword();
            sd.Location = new System.Drawing.Point(0, 0);
            sd.Size = this.Parent.Size;
            this.Controls.Add(sd);
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            Register kayıt = new Register();
            kayıt.Location = new System.Drawing.Point(0, 0);
            kayıt.Size = this.Parent.Size;
            kayıt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(kayıt);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
