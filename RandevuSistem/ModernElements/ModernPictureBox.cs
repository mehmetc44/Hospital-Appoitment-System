using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernPictureBox : PictureBox
{ 
    public  ModernPictureBox()
    {
        this.DoubleBuffered = true;
    }

    private int borderRadius = 20;  // Köşe yarıçapı
    private int borderWidth = 2;    // Kenarlık kalınlığı
    private Color borderColor = Color.Transparent; // Kenarlık rengi

    public int BorderRadius
    {
        get { return borderRadius; }
        set { borderRadius = value; this.Invalidate(); }
    }

    public int BorderWidth
    {
        get { return borderWidth; }
        set { borderWidth = value; this.Invalidate(); }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; this.Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        Graphics graphics = pe.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

        // Yuvarlatılmış köşeler için bir GraphicsPath oluştur
        GraphicsPath path = GetRoundedRectanglePath(rect, borderRadius);
        graphics.SetClip(path);

        // Resmi çiz
        base.OnPaint(pe);

        // Kenarlığı çiz
        using (Pen pen = new Pen(borderColor, borderWidth))
        {
            graphics.DrawPath(pen, path);
        }
    }

    private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
    {
        int diameter = radius * 2;
        GraphicsPath path = new GraphicsPath();

        path.StartFigure();
        path.AddArc(rect.Left, rect.Top, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Top, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }
}
