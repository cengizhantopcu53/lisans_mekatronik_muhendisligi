using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1_UçakSerbestAtışAnimasyonu
{
    public partial class OyunAlanı : Form
    {
        public OyunAlanı()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Start();

            BtnAtes.BackColor = Color.Red;

            PctUcak.Location = new Point(0, 0);
            PctRoket.Location = new Point(PctUcak.Location.X+90, PctUcak.Location.Y+70);

            LblX_Hedef.Text = PctHedef.Location.X.ToString();
            LblY_Hedef.Text = PctHedef.Location.Y.ToString();
            PctAtes.Location = PctHedef.Location;
            PctFail.Location = PctHedef.Location;
            PctAtes.Visible = false;
            PctFail.Visible = false;
        }

        int sayac;
        int x_ucak = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            LblSayac.Text = sayac.ToString();

            x_ucak = x_ucak + 30;
            PctUcak.Left = x_ucak;
            LblX_Ucak.Text = x_ucak.ToString();
            int y_ucak = PctUcak.Location.Y;
            LblY_Ucak.Text = y_ucak.ToString();

            int a = Convert.ToInt16(LblX_Ucak.Text);
            if (a >= 1700)
            {
                x_ucak = 0;
                //Uçağın yüksekliğin belli aralıkta değişmesi
                Random rnd = new Random();
                int yukseklik;
                yukseklik = rnd.Next(0, 201);
                Point konum = new Point();
                konum.Y = yukseklik;
                PctUcak.Location = konum;
                LblY_Ucak.Text = yukseklik.ToString();
            }
        }

        private void BtnAtes_Click(object sender, EventArgs e)
        {
            BtnAtes.BackColor = Color.Green;
            int x1 = Convert.ToInt16(LblX_Hedef.Text);
            int y1 = Convert.ToInt16(LblY_Hedef.Text);
            int x2 = Convert.ToInt16(LblX_Roket.Text);
            int y2 = Convert.ToInt16(LblY_Roket.Text);
            int R = x1 - x2;
            Lbl_R.Text = R.ToString();
            int H = y1 - y2;
            Lbl_H.Text = H.ToString();            
        }

        int x_roket = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            x_roket = x_roket + 30;
            PctRoket.Left = x_roket;
            LblX_Roket.Text = x_roket.ToString();
            int y_roket = PctRoket.Location.Y;
            LblY_Roket.Text = y_roket.ToString();
            if(BtnAtes.BackColor == Color.Green)
            {
                PctRoket.Top += 30;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (PctRoket.Location.X>=900 && PctRoket.Location.X<=1100 && PctRoket.Location.Y>=475 && PctRoket.Location.Y<=515)
            {
                PctRoket.Visible = false;
                PctHedef.Visible = false;
                PctAtes.Visible = true;
                BtnAtes.BackColor = Color.Red;
                timer3.Stop();
                timer5.Start();
            }
            else if (PctRoket.Location.Y >= 1000 && PctRoket.Location.Y >= 515)
            {
                PctHedef.Visible = false;
                PctFail.Visible = true;
                BtnAtes.BackColor = Color.Red;
                timer3.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            PctRoket.Visible = true;
            x_roket = 0;
            int z = Convert.ToInt16(LblX_Ucak.Text);
            if (z >= 1700)
            {
                Point konum = new Point();
                int a = Convert.ToInt16(LblX_Ucak.Text);
                int b = Convert.ToInt16(LblY_Ucak.Text);
                konum.X = a + 150;
                konum.Y = b + 70;
                PctRoket.Location = konum;
                timer5.Stop();
                timer3.Start();
            }
        }
    }
}
