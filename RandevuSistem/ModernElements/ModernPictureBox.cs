using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal class ModernPictureBox : PictureBox
{
    public int BorderRadius { get; set; } = 20; // Varsayılan köşe yuvarlama

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // PictureBox'ın dikdörtgenini al
        Rectangle pictureBoxRect = new Rectangle(0, 0, this.Width, this.Height);
        GraphicsPath path = new GraphicsPath();

        int radius = BorderRadius;
        path.AddArc(pictureBoxRect.X, pictureBoxRect.Y, radius, radius, 180, 90); // Sol üst köşe
        path.AddArc(pictureBoxRect.X + pictureBoxRect.Width - radius, pictureBoxRect.Y, radius, radius, 270, 90); // Sağ üst köşe
        path.AddArc(pictureBoxRect.X + pictureBoxRect.Width - radius, pictureBoxRect.Y + pictureBoxRect.Height - radius, radius, radius, 0, 90); // Sağ alt köşe
        path.AddArc(pictureBoxRect.X, pictureBoxRect.Y + pictureBoxRect.Height - radius, radius, radius, 90, 90); // Sol alt köşe
        path.CloseAllFigures();

        // PictureBox'ın bölgesini ayarla
        this.Region = new Region(path);
    }
}
