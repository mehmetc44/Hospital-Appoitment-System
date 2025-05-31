using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedikApp.UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.Text = "MedikApp";
            this.AutoSize = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(10, 22);
            this.MaximumSize = new Size(2800, 2600);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogIn menu = new LogIn();
            menu.Location = new System.Drawing.Point(0, 0);
            menu.Size = new System.Drawing.Size(1200, 750); 
            menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
          
            this.Controls.Add(menu);

        }
    }
}
