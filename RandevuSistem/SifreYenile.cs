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
    public partial class SifreYenile : UserControl
    {
        public SifreYenile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Profil profil = new Profil();
            profil.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            profil.Size = new System.Drawing.Size(1200, 1750); // Boyutu belirleyin
            profil.AutoScroll = true;
            this.AutoScroll = true;
            this.Controls.Add(profil);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
