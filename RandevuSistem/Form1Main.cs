﻿using RandevuSistem.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace RandevuSistem
{
    public partial class Form1Main : UserControl
    {

        private Size formOriginalSize;
        private Size panelOriginal;
        private Rectangle recBut1;
        private Rectangle recTxt1;
        private Rectangle recTxt2;
        private Rectangle recLink1;
        private Rectangle recLink2;
        private Rectangle recPanel1;
        private Rectangle recPanel2;
        private Rectangle recLbl1;
        private Rectangle recLbl2;
        private Rectangle recPic1;
        public Form1Main()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;

            this.DoubleBuffered = true;
            this.Resize += Form1Main_Resize;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            formOriginalSize = this.Size;
            panelOriginal = panel1.Size;
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recTxt1 = new Rectangle(textBox1.Location, textBox1.Size);
            recTxt2 = new Rectangle(textBox2.Location, textBox2.Size);
            recLink1 = new Rectangle(linkLabel1.Location, linkLabel1.Size);
            recLink2 = new Rectangle(linkLabel2.Location, linkLabel2.Size);
            recPanel1 = new Rectangle(panel1.Location, panel1.Size);
            recLbl2 = new Rectangle(label2.Location, label2.Size);
            recPic1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
        }



        private void Form1Main_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
            resize_Control(button1, recBut1);
            resize_Control(textBox1, recTxt1);
            resize_Control(textBox2, recTxt2);
            resize_Control(linkLabel1, recLink1);
            resize_Control(linkLabel2, recLink2);
            resize_Control_nosize(label2, recLbl2);
            resize_Panel(panel1, recPanel1);
            this.pictureBox1.Size = new Size((this.Width) - (panel1.Size.Width), this.Size.Height);
            this.pictureBox1.Location = new Point(panel1.Size.Width, 0);
        }
        private void resize_Panel(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            int newHeight = (int)(r.Height * yRatio);
            int newWidth = (int)(r.Width * xRatio);
            c.Size = new Size(newWidth, newHeight);

        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(panel1.Width) / (float)(panelOriginal.Width);
            float yRatio = (float)(panel1.Height) / (float)(panelOriginal.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void resize_Control_nosize(Control c, Rectangle r)
        {
            float xRatio = (float)(panel1.Width) / (float)(panelOriginal.Width);
            float yRatio = (float)(panel1.Height) / (float)(panelOriginal.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            c.Location = new Point(newX, newY);
        }
        public class UserInfo
        {
            public static string tc { get; set; }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text != "") && (this.textBox2.Text != ""))
            {
                string url = "http://localhost:5294/api/PersonControllers/Kullanici/Login";
                var jsonContent = new StringContent(
                    $"{{\"tcNumara\": \"{textBox1.Text}\", \"sifre\": \"{textBox2.Text}\"}}",
                    Encoding.UTF8,
                    "application/json"
                );

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(url, jsonContent);
                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(responseData);
                            if (responseData == "true")
                            {
                                UserInfo.tc = textBox1.Text;
                                this.Controls.Clear();
                                MainMenu menu = new MainMenu();
                                menu.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
                                menu.Size = this.Parent.Size; // Boyutu belirleyin
                                this.Controls.Add(menu);
                            }
                            else
                            {
                                MessageBox.Show("Yanlış Tc veya şifre girildi");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Hata: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}");
                    }
                }
            }
            else{MessageBox.Show("Eksik bilgi girdiniz.");}
        }
        private void Form1Main_Load(object sender, EventArgs e)
        {
            this.Size = this.Parent.Size;

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            SifreDegistirme sd = new SifreDegistirme();
            sd.Location = new System.Drawing.Point(0, 0); // Konumu belirleyin
            sd.Size = this.Parent.Size; // Boyutu belirleyin
            this.Controls.Add(sd);
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            Kayıt kayıt = new Kayıt();
            kayıt.Location = new System.Drawing.Point(0, 0);
            kayıt.Size = this.Parent.Size;
            kayıt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(kayıt);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
