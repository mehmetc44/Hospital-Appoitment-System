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
    public partial class SifreDegistirme : UserControl
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form1Main menu = new Form1Main();
            menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            menu.Size = new System.Drawing.Size(900, 550); // Boyutu belirleyin
            this.Controls.Add(menu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            SifreYenileGiris sy = new SifreYenileGiris();
            sy.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            sy.Size = new System.Drawing.Size(900, 500); // Boyutu belirleyin
            this.Size = new System.Drawing.Size(900, 500);
            this.AutoScroll = false;
            sy.AutoScroll = false;
            this.Controls.Add(sy);
        }
    }
}
