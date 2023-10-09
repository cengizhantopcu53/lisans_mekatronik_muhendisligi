using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme_DersNotlari_Ödev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(ResminYolu);
            }
            catch
            {
                MessageBox.Show("HATA! Resim yüklenmedi");
            }
        }

        private void btnKirp_Click(object sender, EventArgs e)
        {
            int YeniX, YeniY, x, y, x1, x2, y1, y2;  //x1,y1,x2,y2 koordinatları tıklanan noktalardır. bunlar global olduğu için buraya geliyor..

            //100x100 lük Resmi hazırlıyor.****************************
            Bitmap HamResim = new Bitmap(pictureBox1.Image);

            x1 = (HamResim.Width - 100) / 2;
            y1 = (HamResim.Height - 100) / 2;
            x2 = x1 + 100;
            y2 = y1 + 100;

            Bitmap Resim100x100 = new Bitmap(100, 100); //Ham resmin tam ortasından 100x100 px bir alanı çakaracak.

            for (x = x1; x <= x2 - 1; x++)
            {
                for (y = y1; y <= y2 - 1; y++)
                {
                    Color OkunanRenk = HamResim.GetPixel(x, y);
                    YeniX = x - x1;
                    YeniY = y - y1;
                    Resim100x100.SetPixel(YeniX, YeniY, OkunanRenk);
                }
            }
            pictureBox2.Image = Resim100x100; //100x100 lük resim.
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox2.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;

            int x, y; //, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;

            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    Color Renk;
                    int P1, P2, P3, P4, P5, P6, P7, P8, P9;

                    Renk = GirisResmi.GetPixel(x - 1, y - 1);
                    P1 = Renk.R;

                    Renk = GirisResmi.GetPixel(x, y - 1);
                    P2 = Renk.R;

                    Renk = GirisResmi.GetPixel(x + 1, y - 1);
                    P3 = Renk.R;

                    Renk = GirisResmi.GetPixel(x - 1, y);
                    P4 = Renk.R;

                    Renk = GirisResmi.GetPixel(x, y);
                    P5 = Renk.R;

                    Renk = GirisResmi.GetPixel(x + 1, y);
                    P6 = Renk.R;

                    Renk = GirisResmi.GetPixel(x - 1, y + 1);
                    P7 = Renk.R;

                    Renk = GirisResmi.GetPixel(x, y + 1);
                    P8 = Renk.R;

                    Renk = GirisResmi.GetPixel(x + 1, y + 1);
                    P9 = Renk.R;

                    int RenkDegeri = Math.Abs((P1 + 2 * P2 + P3) - (P7 + 2 * P8 + P9)) + Math.Abs((P3 + 2 * P6 + P9) - (P1 + 2 * P4 + P7));

                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (RenkDegeri > 255) RenkDegeri = 255;
                    CikisResmi.SetPixel(x, y, Color.FromArgb(RenkDegeri, RenkDegeri, RenkDegeri));
                }
            }
            pictureBox3.Image = CikisResmi;
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox3.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü yüklendi.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;

                    //int Gri = G;  //Yeşil Ton
                    //int Gri = B;  //Mavi Ton
                    //int Gri = R;  //Kırmızı Ton
                    //int Gri = (R + G + B) / 3;  //Ortalama Gri Ton
                    int Gri = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);   //Gri Ton

                    DonusenRenk = Color.FromArgb(Gri, Gri, Gri);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox4.Image = CikisResmi;
        }
    }
}
