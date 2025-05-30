using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace RandevuSistem.ModernElements
{


public class ModernButton : Button
    {
        private int borderRadius = 20; // Köşe yuvarlaklık derecesi
        
        public Color SelectionColor { get; set; } = Color.Red; // Seçili renk
        
           

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); } // Değişiklikleri yansıt
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.FillPath(new SolidBrush(this.BackColor), path);
            pevent.Graphics.DrawPath(new Pen(this.BorderColor), path);

            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            base.OnPaint(pevent);
        }

        public Color BorderColor { get; set; } = Color.Transparent;
    }

}

