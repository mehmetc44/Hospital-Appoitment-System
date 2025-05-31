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
using static MedikApp.UI.LogIn;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace MedikApp.UI
{
    public partial class AppointmentDetail : UserControl
    {
        public AppointmentDetail()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        class Class
        {
            public string id;
        }
        public async void RandevuIptalButon_Click(object sender, EventArgs e)
        {

            string id = RandevuIptalButon.Tag.ToString();
            string url = $"http://localhost:5294/RandevuControllers/RandevuIptal/{id}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Randevu {id} başarıyla silindi.");
                        this.groupBox1.Controls.Remove(this.groupBox1);
                    }
                    else
                    {
                        MessageBox.Show($"Randevu {id} silinirken bir hata oluştu: {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Randevu {id} silinirken bir hata oluştu: {ex.Message}");
                }
            }
        }
    }
}
