using MedikApp.UI.View.Components.ModernElements;

namespace MedikApp.UI
{
    partial class ForgotPassword
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            textBox1 = new ModernTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.BackgroundColor = Color.White;
            textBox1.BorderColor = Color.Gray;
            textBox1.BorderRadius = 15;
            textBox1.BorderSize = 2;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(396, 412);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "T.C. Kimlik No";
            textBox1.Size = new Size(381, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(396, 377);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "TC Kimlik No:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Microsoft Sans Serif", 12.7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(310, 220);
            label2.Name = "label2";
            label2.Size = new Size(643, 93);
            label2.TabIndex = 3;
            label2.Text = "Lütfen TC kimlik numaranızı giriniz. Sonrasında \"SMS Gönder\" butonuna tıklayıp\r\nsms olarak gelen kodu girerek şifrenizi değiştirebilirsiniz.\r\n ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ForgotPassword";
            Size = new Size(1200, 750);
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        private ModernTextBox textBox1;
        private Label label1;
        private Label label2;
        private ModernButton button2;
        private ModernButton button1;
    }
}
