using System;
using System.Drawing;
using System.Windows.Forms;

public class ModernLabel : Label
{
    public ModernLabel()
    {
        // Label'ın varsayılan boyutları
        this.Size = new Size(100, 30);
        this.BorderStyle = BorderStyle.FixedSingle;
        this.TextAlign = ContentAlignment.MiddleCenter;

        // Boyut değiştirme işlevi için olayları bağlama
        this.MouseDown += ResizableLabel_MouseDown;
        this.MouseMove += ResizableLabel_MouseMove;
    }

    private bool isResizing = false;
    private Point lastMousePosition;

    private void ResizableLabel_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isResizing = true;
            lastMousePosition = e.Location;
        }
    }

    private void ResizableLabel_MouseMove(object sender, MouseEventArgs e)
    {
        if (isResizing)
        {
            int newWidth = this.Width + (e.X - lastMousePosition.X);
            int newHeight = this.Height + (e.Y - lastMousePosition.Y);

            if (newWidth > 20) // Minimum genişlik
            {
                this.Width = newWidth;
            }

            if (newHeight > 20) // Minimum yükseklik
            {
                this.Height = newHeight;
            }

            lastMousePosition = e.Location;
        }
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        isResizing = false;
    }
}
