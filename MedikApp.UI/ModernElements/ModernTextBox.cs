using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernTextBox : TextBox
{
    private int borderRadius = 15;
    private Color borderColor = Color.Gray;
    private int borderSize = 2;
    private Color backgroundColor = Color.White;

    // Özellikler
    public int BorderRadius
    {
        get => borderRadius;
        set
        {
            borderRadius = value;
            this.Invalidate(); // BorderRadius değiştiğinde yeniden çizim
        }
    }

    public Color BorderColor
    {
        get => borderColor;
        set
        {
            borderColor = value;
            this.Invalidate(); // BorderColor değiştiğinde yeniden çizim
        }
    }

    public int BorderSize
    {
        get => borderSize;
        set
        {
            borderSize = value;
            this.Invalidate(); // BorderSize değiştiğinde yeniden çizim
        }
    }

    public Color BackgroundColor
    {
        get => backgroundColor;
        set
        {
            backgroundColor = value;
            this.BackColor = value; // Arka plan rengini ayarla
            this.Invalidate(); // BackgroundColor değiştiğinde yeniden çizim
        }
    }

    public ModernTextBox()
    {
        this.BorderStyle = BorderStyle.None; // Varsayılan çerçeveyi kaldırıyoruz
        this.Multiline = true; // Yüksekliği değiştirmek için multiline yapıyoruz
        this.BackColor = backgroundColor; // Arkaplan rengini ayarlıyoruz
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Yuvarlatılmış dikdörtgen çizim yolu
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();

        // Yuvarlatılmış köşeler ekleme
        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
        path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
        path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
        path.CloseFigure();

        // Çerçeve çizimi
        using (Pen pen = new Pen(borderColor, borderSize))
        {
            e.Graphics.DrawPath(pen, path);
        }

        // Köşeleri yuvarlatılmış dikdörtgenin arkaplan rengini ayarlama
        this.Region = new Region(path);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Invalidate(); // Yeniden boyutlandırıldığında yeniden çizim yapıyoruz
    }

    // Size özelliğini override ediyoruz
    public new Size Size
    {
        get { return base.Size; }
        set
        {
            base.Size = value;
            this.Invalidate(); // Boyut değiştiğinde yeniden çizim
        }
    }
}