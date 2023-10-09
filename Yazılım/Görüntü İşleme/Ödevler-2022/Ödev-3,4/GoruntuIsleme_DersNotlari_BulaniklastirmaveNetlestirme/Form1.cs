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

namespace GoruntuIsleme_DersNotlari_BulaniklastirmaveNetlestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Resim Yükle
        private void BtnAc_Click(object sender, EventArgs e)
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

        //Resim Kaydet
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif";
            saveFileDialog1.Title = "Resmi Kaydet";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "") //Dosya adı boş değilse kaydedecek.
            {
                // FileStream nesnesi ile kayıtı gerçekleştirecek. 
                FileStream DosyaAkisi = (FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                DosyaAkisi.Close();
            }
        }

        //Resim Boyutu Ayarlama
        private void btnBoyutAyarla_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //Resmi Sağa Aktarma
        private void btnSagaAktar_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = pictureBox1.Image;

            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü yüklendi.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.

            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;

                    //if (x>100 && x<200)
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);

                }
            }
            pictureBox2.Image = CikisResmi;
        }

        //Resmi Sola Aktarma
        private void btnSolaAktar_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox2.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü yüklendi.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.

            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);

                }
            }
            pictureBox1.Image = CikisResmi;
        }


        //Mean Filtresi
        public Bitmap MeanFiltresi()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);


            int SablonBoyutu = Convert.ToInt32(textBox1.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;

            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;

                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);

                            toplamR = toplamR + OkunanRenk.R;
                            toplamG = toplamG + OkunanRenk.G;
                            toplamB = toplamB + OkunanRenk.B;

                        }
                    }

                    ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                    ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                    ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);

                    CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                }
            }
            return CikisResmi;
        }

        //MEdyan Fİltresi
        public void MedyanFiltresi()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = Convert.ToInt16(textBox1.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;

            int[] R = new int[ElemanSayisi];
            int[] G = new int[ElemanSayisi];
            int[] B = new int[ElemanSayisi];
            int[] Gri = new int[ElemanSayisi];

            int x, y, i, j;

            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0;
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);

                            R[k] = OkunanRenk.R;
                            G[k] = OkunanRenk.G;
                            B[k] = OkunanRenk.B;

                            Gri[k] = Convert.ToInt16(R[k] * 0.299 + G[k] * 0.587 + B[k] * 0.114); //Gri ton formülü-1

                            k++;
                        }
                    }

                    //Gri tona göre sıralama yapıyor. Aynı anda üç rengide değiştiriyor.
                    int GeciciSayi = 0;

                    for (i = 0; i < ElemanSayisi; i++)
                    {
                        for (j = i + 1; j < ElemanSayisi; j++)
                        {
                            if (Gri[j] < Gri[i])
                            {
                                GeciciSayi = Gri[i];
                                Gri[i] = Gri[j];
                                Gri[j] = GeciciSayi;

                                GeciciSayi = R[i];
                                R[i] = R[j];
                                R[j] = GeciciSayi;

                                GeciciSayi = G[i];
                                G[i] = G[j];
                                G[j] = GeciciSayi;

                                GeciciSayi = B[i];
                                B[i] = B[j];
                                B[j] = GeciciSayi;
                            }
                        }
                    }
                    //Sıralama sonrası ortadaki değeri çıkış resminin piksel değeri olarak atıyor.
                    CikisResmi.SetPixel(x, y, Color.FromArgb(R[(ElemanSayisi - 1) / 2], G[(ElemanSayisi - 1) / 2], B[(ElemanSayisi - 1) / 2]));
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        //Gauss Filtresi
        public Bitmap GaussFiltresi()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = Convert.ToInt16(textBox1.Text); //Convert.ToInt16(textBox1.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;

            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
            //int R, G, B, Gri;
            int[] Matris = { 1, 4, 7, 4, 1, 4, 20, 33, 20, 4, 7, 33, 55, 33, 7, 4, 20, 33, 20, 4, 1, 4, 7, 4, 1 };
            int MatrisToplami = 1 + 4 + 7 + 4 + 1 + 4 + 20 + 33 + 20 + 4 + 7 + 33 + 55 + 33 + 7 + 4 + 20 + 33 + 20 + 4 + 1 + 4 + 7 + 4 + 1;

            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;

                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0; //matris içindeki elemanları sırayla okurken kullanılacak.
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);

                            toplamR = toplamR + OkunanRenk.R * Matris[k];
                            toplamG = toplamG + OkunanRenk.G * Matris[k];
                            toplamB = toplamB + OkunanRenk.B * Matris[k];

                            ortalamaR = toplamR / MatrisToplami;
                            ortalamaG = toplamG / MatrisToplami;
                            ortalamaB = toplamB / MatrisToplami;

                            CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));

                            k++;
                        }
                    }
                }
            }
            return CikisResmi;
        }

        //Fİltreleri Karşılaştırma
        private void button1_Click(object sender, EventArgs e)
        {
            //Mean Filtresi
            if (radioButtonMean.Checked == true)
            {
                pictureBox2.Image = MeanFiltresi();
            }

            //Medyan Filtresi
            if (radioButtonMedyan.Checked == true)
            {
                MedyanFiltresi();
            }

            //Gauss Filtresi
            if (radioButtonGauss.Checked == true)
            {
                pictureBox2.Image = GaussFiltresi();
            }
        }

        Graphics CizimAlani;
        Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 1);
        Pen Kalem2 = new Pen(System.Drawing.Color.Red, 2);

        private void Form1_Load(object sender, EventArgs e)
        {
            CizimAlani = pictureBox1.CreateGraphics();
        }

        int tiklanma_sayisi = 0;
        int x1, y1, x2, y2;

        private void CizimAlani_MouseUp(object sender, MouseEventArgs e)
        {
            tiklanma_sayisi++;

            CizimAlani.DrawLine(Kalem1, e.X - 5, e.Y, e.X + 5, e.Y);
            CizimAlani.DrawLine(Kalem1, e.X, e.Y - 5, e.X, e.Y + 5);

            textBox_x1.Text = e.X.ToString();
            textBox_y1.Text = e.Y.ToString();

            if (tiklanma_sayisi == 1)
            {
                x1 = e.X;
                y1 = e.Y;
            }
            else if (tiklanma_sayisi >= 2)
            {
                x2 = e.X;
                y2 = e.Y;
                CizimAlani.DrawLine(Kalem2, x1, y1, x2, y2);
                x1 = x2;
                y1 = y2;
            }
        }

        //Seçilen Alanı Bulanıklaştırma
        private void button2_Click(object sender, EventArgs e)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = Convert.ToInt32(textBox1.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;

            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;

                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);

                            toplamR = toplamR + OkunanRenk.R;
                            toplamG = toplamG + OkunanRenk.G;
                            toplamB = toplamB + OkunanRenk.B;
                        }
                    }
                    ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                    ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                    ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);

                    CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        public Bitmap OrjianalResimdenBulanikResmiCikarma(Bitmap OrjinalResim, Bitmap BulanikResim)
        {

            Color OkunanRenk1, OkunanRenk2, DonusenRenk;
            Bitmap CikisResmi;

            int ResimGenisligi = OrjinalResim.Width;
            int ResimYuksekligi = OrjinalResim.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int R, G, B;
            double Olcekleme = 1.7; //0.2-0.7 arası uygundur.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk1 = OrjinalResim.GetPixel(x, y);
                    OkunanRenk2 = BulanikResim.GetPixel(x, y);

                    R = Convert.ToInt16(Olcekleme * (OkunanRenk1.R - OkunanRenk2.R));
                    G = Convert.ToInt16(Olcekleme * (OkunanRenk1.G - OkunanRenk2.G));
                    B = Convert.ToInt16(Olcekleme * (OkunanRenk1.B - OkunanRenk2.B));

                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            return CikisResmi;
        }

        public Bitmap KenarGoruntusuIleOrjinalResmiBirlestir(Bitmap OrjinalResim, Bitmap KenarGoruntusu)
        {
            Color OkunanRenk1, OkunanRenk2, DonusenRenk;
            Bitmap CikisResmi;

            int ResimGenisligi = OrjinalResim.Width;
            int ResimYuksekligi = OrjinalResim.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int R, G, B;

            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk1 = OrjinalResim.GetPixel(x, y);
                    OkunanRenk2 = KenarGoruntusu.GetPixel(x, y);

                    R = OkunanRenk1.R + OkunanRenk2.R;
                    G = OkunanRenk1.G + OkunanRenk2.G;
                    B = OkunanRenk1.B + OkunanRenk2.B;

                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            return CikisResmi;
        }

        //Seçilen Alanı Netleştirme
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap OrjinalResim = new Bitmap(pictureBox1.Image);

            Bitmap BulanikResim;

            //Mean Filtresi
            if (radioButton1.Checked == true)
            {
                BulanikResim = MeanFiltresi();
                Bitmap KenarGoruntusu = OrjianalResimdenBulanikResmiCikarma(OrjinalResim, BulanikResim);
                Bitmap NetlesmisResim = KenarGoruntusuIleOrjinalResmiBirlestir(OrjinalResim, KenarGoruntusu);
                pictureBox2.Image = NetlesmisResim;
            }

            //Gauss Filtresi
            if (radioButton2.Checked == true)
            {
                BulanikResim = GaussFiltresi();
                Bitmap KenarGoruntusu = OrjianalResimdenBulanikResmiCikarma(OrjinalResim, BulanikResim);
                Bitmap NetlesmisResim = KenarGoruntusuIleOrjinalResmiBirlestir(OrjinalResim, KenarGoruntusu);
                pictureBox2.Image = NetlesmisResim;
            }
        }
    }
}
