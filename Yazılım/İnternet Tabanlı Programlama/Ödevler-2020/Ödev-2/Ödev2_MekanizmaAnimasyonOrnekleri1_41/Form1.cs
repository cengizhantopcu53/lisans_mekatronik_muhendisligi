using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2_MekanizmaAnimasyonOrnekleri1_41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics CizimAlani;
        Graphics GrafikAlani1;
        Graphics GrafikAlani2;

        Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 3);
        Pen Kalem2 = new Pen(System.Drawing.Color.White, 3);
        Pen Kalem3 = new Pen(System.Drawing.Color.DarkOrange, 3);
        Pen Kalem4 = new Pen(System.Drawing.Color.Aqua, 3);

        private void Form1_Load(object sender, EventArgs e)
        {
            CizimAlani = pictureBox1.CreateGraphics();
            GrafikAlani1 = pictureBox3.CreateGraphics();
            GrafikAlani2 = pictureBox4.CreateGraphics();

            trackBar1.Maximum = 20;
            trackBar1.Minimum = 1;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();

            CizimAlani.DrawLine(Kalem1, Convert.ToInt32(textBox1.Text) - 5, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text) + 5, Convert.ToInt32(textBox2.Text));
            CizimAlani.DrawLine(Kalem1, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text) - 5, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text) + 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CizimAlani.DrawLine(Kalem1, Convert.ToInt32(textBox1.Text) - 5, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text) + 5, Convert.ToInt32(textBox2.Text));
            CizimAlani.DrawLine(Kalem1, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text) - 5, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text) + 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        public void cizim()
        {
            CizimAlani.DrawString("Cengizhan Topçu", new Font("Vineta BT", 20), new SolidBrush(Color.Red), 150, 525);
            CizimAlani.DrawString("2017010225048", new Font("Vineta BT", 20), new SolidBrush(Color.Red), 170, 550);

            CizimAlani.DrawEllipse(Kalem1, 250, 50, 180, 180); //No:1
            CizimAlani.DrawEllipse(Kalem1, 315, 118, 50, 50); //No:2.1
            CizimAlani.DrawEllipse(Kalem4, 315, 243, 50, 50); //No:2.2
            CizimAlani.DrawEllipse(Kalem2, 325, 128, 30, 30); ////No:3.1
            CizimAlani.DrawEllipse(Kalem2, 325, 253, 30, 30); ////No:3.2
            CizimAlani.DrawRectangle(Kalem3, 90, 400, 500, 30); //No:4
            CizimAlani.DrawRectangle(Kalem2, 130, 380, 30, 70); //No:5.1
            CizimAlani.DrawRectangle(Kalem2, 515, 380, 30, 70); //No:5.2
            //CizimAlani.DrawEllipse(Kalem1, 350, 200, 20, 20); //No:6

            //PointF point1 = new PointF(240, 400);
            //PointF point2 = new PointF(247.5F, 380);
            //PointF point3 = new PointF(253.5F, 380);
            //PointF point4 = new PointF(261, 400);
            //PointF[] poligannoktaları = { point1, point2, point3, point4 }; //No:7.1
            PointF[] poligannoktaları1 = { new PointF(240, 400), new PointF(247.5F, 380), new PointF(253.5F, 380), new PointF(261, 400) };
            CizimAlani.DrawPolygon(Kalem3, poligannoktaları1); //No:7.1
            PointF[] poligannoktaları2 = { new PointF(267, 400), new PointF(274.5F, 380), new PointF(280.5F, 380), new PointF(288, 400) };
            CizimAlani.DrawPolygon(Kalem3, poligannoktaları2); //No:7.2
            PointF[] poligannoktaları3 = { new PointF(294, 400), new PointF(301.5F, 380), new PointF(307.5F, 380), new PointF(315, 400) };
            CizimAlani.DrawPolygon(Kalem3, poligannoktaları3); //No:7.3
            PointF[] poligannoktaları4 = { new PointF(321, 400), new PointF(328.5F, 380), new PointF(334.5F, 380), new PointF(342, 400) };
            CizimAlani.DrawPolygon(Kalem3, poligannoktaları4); //No:7.4
            PointF[] poligannoktaları5 = { new PointF(348, 400), new PointF(355.5F, 380), new PointF(361.5F, 380), new PointF(369, 400) };
            CizimAlani.DrawPolygon(Kalem3, poligannoktaları5); //No:7.5
            PointF[] poligannoktaları6 = { new PointF(375, 400), new PointF(382.5F, 380), new PointF(388.5F, 380), new PointF(396, 400) };
            CizimAlani.DrawPolygon(Kalem3, poligannoktaları6); //No:7.6
            PointF[] poligannoktaları7 = { new PointF(402, 400), new PointF(409.5F, 380), new PointF(415.5F, 380), new PointF(423, 400) };
            CizimAlani.DrawPolygon(Kalem3, poligannoktaları7); //No:7.7
            PointF[] poligannoktaları8 = { new PointF(427, 400), new PointF(434.5F, 380), new PointF(440.5F, 380), new PointF(448, 400) };
            CizimAlani.DrawPolygon(Kalem3, poligannoktaları8); //No:7.8
        }

        int saniye = 0, salise = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            salise++;
            label7.Text = salise.ToString();
            if (salise==60)
            {
                saniye++;
                label5.Text = saniye.ToString();
                salise = 0;
                if (saniye==20)
                {
                    saniye = 0;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //int [] degerler = { 5, 10, 15, 20};
            label6.Text = trackBar1.Value.ToString();
            timer1.Interval = Convert.ToInt32(label6.Text);
        }

        int X1, Y1;
        double X2, Y2;
        int Alfa = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            X1 = 330;
            Y1 = 130;
            int L = 74;
            Alfa++;
            textBox3.Text = Alfa.ToString();
            double AlfaRadyan = Alfa * 2 * Math.PI / 360; 
            X2 = X1 + L * Math.Cos(AlfaRadyan);
            Y2 = Y1 + L * Math.Sin(AlfaRadyan);
            CizimAlani.DrawEllipse(Kalem1, Convert.ToInt32(X2), Convert.ToInt32(Y2), 20, 20); //No:6
            //CizimAlani.DrawLine(Kalem4, X1, Y1, Convert.ToInt32(X2), Convert.ToInt32(Y2)); //No:0
            cizim();

            //Dönen Diskin Hız-Zaman Grafiği
            GrafikAlani1.DrawString("Dönen Disk", new Font("Calibri", 14), new SolidBrush(Color.White), 160, 3);
            GrafikAlani1.DrawLine(Kalem3, 40, 20, 40, 195); //Hız Çizgisi
            GrafikAlani1.DrawLine(Kalem3, 40, 170, 345, 170); //Zaman Çizgisi
            GrafikAlani1.DrawString("Hız", new Font("Calibri", 12), new SolidBrush(Color.White), 27, 2);
            GrafikAlani1.DrawString("5", new Font("Calibri", 12), new SolidBrush(Color.White), 23, 140);
            GrafikAlani1.DrawString("10", new Font("Calibri", 12), new SolidBrush(Color.White), 15, 100);
            GrafikAlani1.DrawString("15", new Font("Calibri", 12), new SolidBrush(Color.White), 15, 60);
            GrafikAlani1.DrawString("20", new Font("Calibri", 12), new SolidBrush(Color.White), 15, 20);
            GrafikAlani1.DrawString("Zaman", new Font("Calibri", 12), new SolidBrush(Color.White), 346, 160);
            GrafikAlani1.DrawString("1", new Font("Calibri", 12), new SolidBrush(Color.White), 60, 175);
            GrafikAlani1.DrawString("2", new Font("Calibri", 12), new SolidBrush(Color.White), 90, 175);
            GrafikAlani1.DrawString("3", new Font("Calibri", 12), new SolidBrush(Color.White), 120, 175);
            GrafikAlani1.DrawString("4", new Font("Calibri", 12), new SolidBrush(Color.White), 150, 175);
            GrafikAlani1.DrawString("5", new Font("Calibri", 12), new SolidBrush(Color.White), 180, 175);
            GrafikAlani1.DrawString("6", new Font("Calibri", 12), new SolidBrush(Color.White), 210, 175);
            GrafikAlani1.DrawString("7", new Font("Calibri", 12), new SolidBrush(Color.White), 240, 175);
            GrafikAlani1.DrawString("8", new Font("Calibri", 12), new SolidBrush(Color.White), 270, 175);
            GrafikAlani1.DrawString("9", new Font("Calibri", 12), new SolidBrush(Color.White), 300, 175);
            GrafikAlani1.DrawString("10", new Font("Calibri", 12), new SolidBrush(Color.White), 330, 175);

            //Kramayer Dişlisinin Hız-Zaman Grafiği
            GrafikAlani2.DrawString("Kramayer Dişlisi", new Font("Calibri", 14), new SolidBrush(Color.White), 145, 3);
            GrafikAlani2.DrawLine(Kalem3, 40, 20, 40, 195); //Hız Çizgisi
            GrafikAlani2.DrawLine(Kalem3, 40, 170, 345, 170); //Zaman Çizgisi
            GrafikAlani2.DrawString("Hız", new Font("Calibri", 12), new SolidBrush(Color.White), 27, 2);
            GrafikAlani2.DrawString("5", new Font("Calibri", 12), new SolidBrush(Color.White), 23, 140);
            GrafikAlani2.DrawString("10", new Font("Calibri", 12), new SolidBrush(Color.White), 15, 100);
            GrafikAlani2.DrawString("15", new Font("Calibri", 12), new SolidBrush(Color.White), 15, 60);
            GrafikAlani2.DrawString("20", new Font("Calibri", 12), new SolidBrush(Color.White), 15, 20);
            GrafikAlani2.DrawString("Zaman", new Font("Calibri", 12), new SolidBrush(Color.White), 346, 160);
            GrafikAlani2.DrawString("1", new Font("Calibri", 12), new SolidBrush(Color.White), 60, 175);
            GrafikAlani2.DrawString("2", new Font("Calibri", 12), new SolidBrush(Color.White), 90, 175);
            GrafikAlani2.DrawString("3", new Font("Calibri", 12), new SolidBrush(Color.White), 120, 175);
            GrafikAlani2.DrawString("4", new Font("Calibri", 12), new SolidBrush(Color.White), 150, 175);
            GrafikAlani2.DrawString("5", new Font("Calibri", 12), new SolidBrush(Color.White), 180, 175);
            GrafikAlani2.DrawString("6", new Font("Calibri", 12), new SolidBrush(Color.White), 210, 175);
            GrafikAlani2.DrawString("7", new Font("Calibri", 12), new SolidBrush(Color.White), 240, 175);
            GrafikAlani2.DrawString("8", new Font("Calibri", 12), new SolidBrush(Color.White), 270, 175);
            GrafikAlani2.DrawString("9", new Font("Calibri", 12), new SolidBrush(Color.White), 300, 175);
            GrafikAlani2.DrawString("10", new Font("Calibri", 12), new SolidBrush(Color.White), 330, 175);
        }
    }
}
