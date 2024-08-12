using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistem
{
    public partial class SifreYenileGiris : UserControl
    {
        public SifreYenileGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            SifreDegistirme sd = new SifreDegistirme();
            sd.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            sd.Size = new System.Drawing.Size(1200, 750); // Boyutu belirleyin
            this.Controls.Add(sd);
        }
    }
}
