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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "MedikApp";
            this.AutoSize = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(10, 22); // Formun alabileceği en küçük boyut
            this.MaximumSize = new Size(2800, 2600); // Formun alabileceği en büyük boyut

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1Main menu = new Form1Main();
            menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            menu.Size = new System.Drawing.Size(1200, 750); // Boyutu belirleyin
            menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
          
            this.Controls.Add(menu);

        }
    }
}
