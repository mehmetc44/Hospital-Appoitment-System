using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernMonthCalendar : Control
{
    public Color HeaderBackgroundColor { get; set; } = Color.DarkSlateBlue;
    public Color HeaderForeColor { get; set; } = Color.White;
    public Color DaysForeColor { get; set; } = Color.Black;
    public Color SelectedDayBorderColor { get; set; } = Color.Red;

    private DateTime _currentDate = DateTime.Today;
    private Button _prevMonthButton;
    private Button _nextMonthButton;

    public ModernMonthCalendar()
    {
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.UserPaint, true);
        this.Size = new Size(300, 250);

        // Önceki ay butonu
        _prevMonthButton = new Button
        {
            Size = new Size(30, 30),
            Text = "<",
            FlatStyle = FlatStyle.Flat,
            BackColor = HeaderBackgroundColor,
            ForeColor = HeaderForeColor
        };
        _prevMonthButton.Click += (sender, e) => ChangeMonth(-1);
        this.Controls.Add(_prevMonthButton);

        // Sonraki ay butonu
        _nextMonthButton = new Button
        {
            Size = new Size(30, 30),
            Text = ">",
            FlatStyle = FlatStyle.Flat,
            BackColor = HeaderBackgroundColor,
            ForeColor = HeaderForeColor
        };
        _nextMonthButton.Click += (sender, e) => ChangeMonth(1);
        this.Controls.Add(_nextMonthButton);

        // Butonların doğru yerleşimini sağlamak için ayarları güncelle
        UpdateButtonLocations();
    }

    public DateTime CurrentDate
    {
        get => _currentDate;
        set
        {
            _currentDate = value;
            Invalidate();
        }
    }

    private void ChangeMonth(int direction)
    {
        _currentDate = _currentDate.AddMonths(direction);
        Invalidate();
        UpdateButtonLocations();
    }

    private void UpdateButtonLocations()
    {
        if (_prevMonthButton != null && _nextMonthButton != null)
        {
            int headerHeight = 30;
            int buttonSize = headerHeight;

            _prevMonthButton.Size = new Size(buttonSize, buttonSize);
            _prevMonthButton.Location = new Point(0, 0);

            _nextMonthButton.Size = new Size(buttonSize, buttonSize);
            _nextMonthButton.Location = new Point(this.Width - buttonSize, 0);
        }
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        UpdateButtonLocations();
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;

        // Başlık kısmı
        int headerHeight = 30;
        Rectangle headerRect = new Rectangle(_prevMonthButton.Width, 0, this.Width - 2 * _prevMonthButton.Width, headerHeight);
        using (SolidBrush headerBrush = new SolidBrush(HeaderBackgroundColor))
        {
            g.FillRectangle(headerBrush, headerRect);
        }

        // Ay başlığı
        string title = _currentDate.ToString("MMMM yyyy");
        TextRenderer.DrawText(g, title, this.Font, headerRect, HeaderForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

        // Günlerin çizimi
        DateTime firstDayOfMonth = new DateTime(_currentDate.Year, _currentDate.Month, 1);
        int daysInMonth = DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month);
        int firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

        int cellWidth = this.Width / 7;
        int cellHeight = (this.Height - headerHeight) / 6;

        for (int day = 1; day <= daysInMonth; day++)
        {
            DateTime currentDay = new DateTime(_currentDate.Year, _currentDate.Month, day);
            int dayOfWeek = (firstDayOfWeek + day - 1) % 7;
            int weekOfMonth = (firstDayOfWeek + day - 1) / 7;

            Rectangle dayRect = new Rectangle(
                dayOfWeek * cellWidth,
                headerHeight + weekOfMonth * cellHeight,
                cellWidth,
                cellHeight
            );

            // Günlerin arka plan rengi
            using (SolidBrush dayBackgroundBrush = new SolidBrush(Color.White))
            {
                g.FillRectangle(dayBackgroundBrush, dayRect);
            }

            // Gün numarası
            string dayText = day.ToString();
            using (SolidBrush textBrush = new SolidBrush(DaysForeColor))
            {
                TextRenderer.DrawText(g, dayText, this.Font, dayRect, DaysForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

            // Seçili günün çerçevesi
            if (currentDay.Date == DateTime.Today.Date)
            {
                using (Pen pen = new Pen(SelectedDayBorderColor, 2))
                {
                    g.DrawRectangle(pen, dayRect);
                }
            }
        }
    }
}