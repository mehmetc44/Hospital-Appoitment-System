using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal class ModernPanel : Panel
{
    public int BorderRadius { get; set; } = 20; // Varsayılan köşe yuvarlama

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle panelRect = new Rectangle(0, 0, this.Width, this.Height);
        GraphicsPath path = new GraphicsPath();

        int radius = BorderRadius;
        path.AddArc(panelRect.X, panelRect.Y, radius, radius, 180, 90);
        path.AddArc(panelRect.X + panelRect.Width - radius, panelRect.Y, radius, radius, 270, 90);
        path.AddArc(panelRect.X + panelRect.Width - radius, panelRect.Y + panelRect.Height - radius, radius, radius, 0, 90);
        path.AddArc(panelRect.X, panelRect.Y + panelRect.Height - radius, radius, radius, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);
    }
}
