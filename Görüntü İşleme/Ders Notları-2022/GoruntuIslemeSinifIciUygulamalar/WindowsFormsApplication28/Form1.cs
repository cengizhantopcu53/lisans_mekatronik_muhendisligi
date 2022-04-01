using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using System.Windows;

using System.IO;
using System.Drawing.Imaging;


namespace WindowsFormsApplication28
{
    public partial class Form1 : Form
    {
        Bitmap GirisResmi, CikisResmi;
        Color OkunanRenk= new Color();

        public Form1()
        {
            InitializeComponent();
        }



        private void DosyaAc_menu_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }
        private void DosyaAc_toolbar_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }
        //DOSYA AÇ -----------------------------
        public void DosyaAc()
        {
            Bitmap GirisResmi;
            try
            {
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

                openFileDialog1.ShowDialog();

                String ResminYolu = openFileDialog1.FileName;

                GirisResmi = new Bitmap(Image.FromFile(ResminYolu));

                pictureBox1.Image = GirisResmi;


            }
            catch { }
        }


        //RESMİ KAYDETME-----------------------------------------
        public void ResmiKaydet()
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


        //GRI-TON a dönüştürme--------------------------------------
        public Bitmap ResmiGriTonaDonustur(Bitmap GirisResmi)
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;
            //Bitmap GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. Fonksiyonla gelmedi.
            int ResimYuksekligi = GirisResmi.Height;

            //CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi, System.Drawing.Imaging.PixelFormat.Format8bppIndexed); //8 bir formatında gri-ton resim oluşturmak için.
            Bitmap CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    //int GriDegeri = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B)/3; //Ortalama Gri-ton formülü
                    //int GriDegeri = Convert.ToInt16(OkunanRenk.R * 0.299 + OkunanRenk.G * 0.587 + OkunanRenk.B * 0.114); //Gri-ton formülü
                    int GriDegeri = Convert.ToInt16(OkunanRenk.R * 0.21 + OkunanRenk.G * 0.71 + OkunanRenk.B * 0.071); //Gri-ton formülü

                    R = GriDegeri;
                    G = GriDegeri;
                    B = GriDegeri;
                    DonusenRenk = Color.FromArgb(R, G, B);

                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }

            //CikisResmi = Deneme8bit(CikisResmi);

            return CikisResmi;
        }

        //DENEME ---------------------------------------
        public Bitmap Deneme8bit(Bitmap CikisResmi)
        {
            var imageEncoders = ImageCodecInfo.GetImageEncoders();
            var imageCodecInfo = imageEncoders.FirstOrDefault(t => t.MimeType == "image/tiff");

            var encoder = System.Drawing.Imaging.Encoder.ColorDepth;
            var encoderParameters = new EncoderParameters(1);
            var encoderParameter = new EncoderParameter(encoder, 8L);
            encoderParameters.Param[0] = encoderParameter;
            var memoryStream = new MemoryStream();
            CikisResmi.Save(memoryStream, imageCodecInfo, encoderParameters);
            Bitmap Resim8bit = new Bitmap(Image.FromStream(memoryStream));

            return Resim8bit;
        }

        //NEGATİFİNİ ALMA----------------------------------------
        public Bitmap ResminNegatifiniAl()
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = 255 - OkunanRenk.R;
                    G = 255 - OkunanRenk.G;
                    B = 255 - OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }

            return CikisResmi;

        }


        //HİSTOGRAM -------------------------------------
        public void ResminHistograminiCiz()
        {
            pictureBox2.Image = null;

            ArrayList DiziPiksel = new ArrayList();

            int OrtalamaRenk = 0;
            Color OkunanRenk;

            Bitmap GirisResmi; //Histogram için giriş resmi gri-ton olmalıdır.
            GirisResmi = new Bitmap(pictureBox1.Image);

            Bitmap GriResim= ResmiGriTonaDonustur(GirisResmi); //Giriş resmi global olduğu için burada götürmüyor.
            pictureBox1.Image = GriResim;

            int ResimGenisligi = GriResim.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GriResim.Height;

            for (int x = 0; x < GirisResmi.Width; x++)
            {
                for (int y = 0; y < GirisResmi.Height; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    //OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.

                    DiziPiksel.Add(OkunanRenk.R ); //Gri resim olduğu için tek kanalı okuması yeterli olacaktır. 
                }

            }

            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r < 255; r++) //256 tane renk tonu için dönecek.
            {
                int PikselSayisi = 0;
                for (int s = 0; s < DiziPiksel.Count; s++) //resimdeki piksel sayısınca dönecek. 
                {
                    if (r == Convert.ToInt16(DiziPiksel[s]))
                        PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }

            //Değerleri listbox'a ekliyor. 
            int RenkMaksPikselSayisi = 0; //Grafikte y eksenini ölçeklerken kullanılacak. 
            for (int k = 0; k <= 255; k++)
            {
                listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);

                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }

            //Grafiği çiziyor. 
            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Blue, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pictureBox2.CreateGraphics();

            pictureBox2.Refresh();
            int GrafikYuksekligi = 450;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi, OlcekX = 1.6;
            for (int x = 0; x <= 255; x++)
            {
                CizimAlani.DrawLine(Kalem1, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), 0);

            }
            textBox1.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();

        }



        //PARLAKLIĞINI DEĞİŞTİRME ----------------------------------------
        public Bitmap ResminParlakliginiDegistir()
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.

            int Ekleme = trackBar1.Value;
            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R + Ekleme;
                    G = OkunanRenk.G + Ekleme;
                    B = OkunanRenk.B + Ekleme;

                    //Renkler 255 geçtiyse son sınır olan 255 alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }

            return CikisResmi;

        }


        //**************************************************
        private void Menu_Kucult_Click(object sender, EventArgs e)
        {

        }

        private void Kaydet_menu_Click(object sender, EventArgs e)
        {
            ResmiKaydet();
        }

        private void Kaydet_toolbar_Click(object sender, EventArgs e)
        {
            ResmiKaydet();
        }


        private void GriTon_menu_Click(object sender, EventArgs e)
        {
            Bitmap GirisResmi = new Bitmap(pictureBox1.Image);
            pictureBox2.Image = ResmiGriTonaDonustur(GirisResmi); //Giriş resmi global olduğu için burada götürmüyor.

        }


        private void Negatif_menu_Click(object sender, EventArgs e)
        {

            pictureBox2.Image = ResminNegatifiniAl(); //Giriş resmi global olduğu için burada götürmüyor.

        }

        private void Esikleme_menu_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = ResmiEsiklemeYap();
        }

        private void Histogram_menu_Click(object sender, EventArgs e)
        {
            ResminHistograminiCiz();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            //pictureBox2.Image = ResmiEsiklemeYap();
        }

        private void parlaklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ResminParlakliginiDegistir();
        }


        private void Karsitlik_menu_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Karsitlik();
        }
        public Bitmap Karsitlik() //KONTRAST
        {

            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.

            double KontrastSeviyesi = 128;

            double KontrastFaktoru = (259 * (KontrastSeviyesi + 255)) / (255 * (259 - KontrastSeviyesi));

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;

                    R = (int)((KontrastFaktoru * (R - 128)) + 128);
                    G = (int)((KontrastFaktoru * (G - 128)) + 128);
                    B = (int)((KontrastFaktoru * (B - 128)) + 128);

                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }

            return CikisResmi;


        }

        private void Kucultme_menu_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = Kucultme_DegistirmeMetodu();
            pictureBox2.Image = Kucultme_InterpolasyonMetodu();

        }

        public Bitmap Kucultme_DegistirmeMetodu()
        {
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;

            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resminin boyutları


            int x2 = 0, y2 = 0; //Çıkış resminin x ve y si olacak.
            int KucultmeKatsayisi = 2;
            for (int x1 = 0; x1 < ResimGenisligi; x1 = x1 + KucultmeKatsayisi)
            {
                y2 = 0;
                for (int y1 = 0; y1 < ResimYuksekligi; y1 = y1 + KucultmeKatsayisi)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);

                    DonusenRenk = OkunanRenk;
                    CikisResmi.SetPixel(x2, y2, DonusenRenk);
                    y2++;
                }
                x2++;
            }

            return CikisResmi;


        }

        //------- ÖLÇEKLEME - Küçültme--------------------------
        public Bitmap Kucultme_InterpolasyonMetodu()
        {
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;
            int R = 0, G = 0, B = 0;

            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resminin boyutları


            int x2 = 0, y2 = 0; //Çıkış resminin x ve y si olacak.
            int KucultmeKatsayisi = 2;


            for (int x1 = 0; x1 < ResimGenisligi; x1 = x1 + KucultmeKatsayisi)
            {
                y2 = 0;
                for (int y1 = 0; y1 < ResimYuksekligi; y1 = y1 + KucultmeKatsayisi)
                {
                    //x ve y de ilerlerken her atlanan pikselleri okuyacak ve ortalama değerini alacak.
                    R = 0; G = 0; B = 0;
                    try //resim sınırının dışına çıkaldığında hata vermesin diye
                    {
                        for (int i = 0; i < KucultmeKatsayisi; i++)
                        {
                            for (int j = 0; j < KucultmeKatsayisi; j++)
                            {
                                OkunanRenk = GirisResmi.GetPixel(x1 + i, y1 + j);

                                R = R + OkunanRenk.R;
                                G = G + OkunanRenk.G;
                                B = B + OkunanRenk.B;

                            }
                        }
                    }
                    catch { }

                    //Renk kanallarının ortalamasını alıyor
                    R = R / (KucultmeKatsayisi * KucultmeKatsayisi);
                    G = G / (KucultmeKatsayisi * KucultmeKatsayisi);
                    B = B / (KucultmeKatsayisi * KucultmeKatsayisi);


                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x2, y2, DonusenRenk);
                    y2++;
                }
                x2++;
            }

            return CikisResmi;
        }

        private void Dondurme_menu_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Dondurme();
        }

        //==================== DONDURME ===========================
        public Bitmap Dondurme()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Çıkış resmi giriş resmi ile aynı boyutta olacak.

            int Aci = 15; //Convert.ToInt16(textBox1.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;

            double x2 = 0, y2 = 0;

            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;

            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);

                    //Aliassız Döndürme Formülleri
                    x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
                    y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;

                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            return CikisResmi;
        }


        private void DondurmeAlias_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Dondurme_Alias();
        }
        //==================== DONDURME ===========================
        public Bitmap Dondurme_Alias()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Çıkış resmi giriş resmi ile aynı boyutta olacak.

            int Aci = 15; //Convert.ToInt16(textBox1.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;

            double x2 = 0, y2 = 0;

            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;

            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);

                    //Aliaslı Döndürme -Sağa Kaydırma
                    x2 = (x1 - x0) - Math.Tan(RadyanAci / 2) * (y1 - y0) + x0;
                    y2 = (y1 - y0) + y0;

                    x2 = Convert.ToInt16(x2);
                    y2 = Convert.ToInt16(y2);

                    //Aliaslı Döndürme -Aşağı kaydırma
                    x2 = (x2 - x0) + x0;
                    y2 = Math.Sin(RadyanAci) * (x2 - x0) + (y2 - y0) + y0;

                    x2 = Convert.ToInt16(x2);

                    y2 = Convert.ToInt16(y2);

                    //Aliaslı Döndürme -Sağa Kaydırma
                    x2 = (x2 - x0) - Math.Tan(RadyanAci / 2) * (y2 - y0) + x0;
                    y2 = (y2 - y0) + y0;

                    x2 = Convert.ToInt16(x2);
                    y2 = Convert.ToInt16(y2);


                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            return CikisResmi;
        }


        private void Aynalama_menu_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Aynalama();
        }

        //==================== AYNALAMA ===========================
        public Bitmap Aynalama()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Çıkış resmi giriş resmi ile aynı boyutta olacak.

            double Aci = 15; //Convert.ToDouble(textBox1.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;

            double x2 = 0, y2 = 0;

            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;

            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);

                    //----A-Orta dikey eksen etrafında aynalama ----------------
                    //x2 = Convert.ToInt16(-x1 + 2 * x0); 
                    //y2 = Convert.ToInt16(y1);

                    //----B-Orta yatay eksen etrafında aynalama ----------------
                    //x2 = Convert.ToInt16(x1);
                    //y2 = Convert.ToInt16(-y1 + 2 *y0);

                    //----C-Ortadan geçen 45 açılı çizgi etrafında aynalama----------
                    double Delta = (x1 - x0) * Math.Sin(RadyanAci) - (y1 - y0) * Math.Cos(RadyanAci);

                    x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(RadyanAci)));
                    y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(RadyanAci)));

                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            return CikisResmi;
        }

        private void tasima_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Tasima();

        }

        //==================== TAŞIMA ===========================
        public Bitmap Tasima()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Çıkış resmi giriş resmi ile aynı boyutta olacak.

            double x2 = 0, y2 = 0;

            //Taşıma mesafelerini atıyor. 
            int Tx = 100;
            int Ty = 50;

            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);

                    //----Taşıma
                    x2 = x1 + Tx;
                    y2 = y1 + Ty;

                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            return CikisResmi;
        }

        private void afinDonusumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Tasima();
            pictureBox1.Image = pictureBox2.Image;

            pictureBox2.Image = Dondurme();
            pictureBox1.Image = pictureBox2.Image;

            pictureBox2.Image = Kucultme_InterpolasyonMetodu();

        }

        private void egmeKaydirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Egme_Kaydirma();
        }
        public Bitmap Egme_Kaydirma()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            //Taşıma mesafelerini atıyor. 
            double EgmeKatsayisi = 0.2;
            double x2 = 0, y2 = 0;

            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);

                    // +X ekseni yönünde
                    //x2 = x1 + EgmeKatsayisi * y1;
                    //y2 = y1;

                    // -X ekseni yönünde
                    //x2 = x1 - EgmeKatsayisi * y1;
                    //y2 = y1;


                    // +Y ekseni yönünde
                    //x2 = x1;
                    //y2 = EgmeKatsayisi * x1 + y1;

                    // -Y ekseni yönünde
                    x2 = x1;
                    y2 = -EgmeKatsayisi * x1 + y1;


                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            return CikisResmi;

        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void matrisTersiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }






        private void perspektifDuzeltmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image=  PerspektifDuzelt();
            double x1 = 47, y1 = 155;
            double x2 = 806, y2 = 101;
            double x3 = 46, y3 = 291;
            double x4 = 726, y4 = 417;

            double X1 = 0, Y1 = 0;
            double X2 = 800, Y2 = 0;
            double X3 = 0, Y3 = 600;
            double X4 = 800, Y4 = 600;

            double[][] matrixA = new double[8][];

            // { x1, y1, 1, 0, 0, 0, -x1 * X1, -y1 * X1 }
            matrixA[0] = new double[8];
            matrixA[0][0] = x1;
            matrixA[0][1] = y1;
            matrixA[0][2] = 1;
            matrixA[0][3] = 0;
            matrixA[0][4] = 0;
            matrixA[0][5] = 0;
            matrixA[0][6] = -x1 * X1;
            matrixA[0][7] = -y1 * X1;

            //{ 0, 0, 0, x1, y1, 1, -x1 * Y1, -y1 * Y1 }
            matrixA[1] = new double[8];
            matrixA[1][0] = 0;
            matrixA[1][1] = 0;
            matrixA[1][2] = 0;
            matrixA[1][3] = x1;
            matrixA[1][4] = y1;
            matrixA[1][5] = 1;
            matrixA[1][6] = -x1 * Y1;
            matrixA[1][7] = -y1 * Y1;

            //{ x2, y2, 1, 0, 0, 0, -x2 * X2, -y2 * X2 } 
            matrixA[2] = new double[8];
            matrixA[2][0] = x2;
            matrixA[2][1] = y2;
            matrixA[2][2] = 1;
            matrixA[2][3] = 0;
            matrixA[2][4] = 0;
            matrixA[2][5] = 0;
            matrixA[2][6] = -x2 * X2;
            matrixA[2][7] = -y2 * X2;

            //{ 0, 0, 0, x2, y2, 1, -x2 * Y2, -y2 * Y2 }
            matrixA[3] = new double[8];
            matrixA[3][0] = 0;
            matrixA[3][1] = 0;
            matrixA[3][2] = 0;
            matrixA[3][3] = x2;
            matrixA[3][4] = y2;
            matrixA[3][5] = 1;
            matrixA[3][6] = -x2 * Y2;
            matrixA[3][7] = -y2 * Y2;

            //{ x3, y3, 1, 0, 0, 0, -x3 * X3, -y3 * X3 }
            matrixA[4] = new double[8];
            matrixA[4][0] = x3;
            matrixA[4][1] = y3;
            matrixA[4][2] = 1;
            matrixA[4][3] = 0;
            matrixA[4][4] = 0;
            matrixA[4][5] = 0;
            matrixA[4][6] = -x3 * X3;
            matrixA[4][7] = -y3 * X3;

            //{ 0, 0, 0, x3, y3, 1, -x3 * Y3, -y3 * Y3 }
            matrixA[5] = new double[8];
            matrixA[5][0] = 0;
            matrixA[5][1] = 0;
            matrixA[5][2] = 0;
            matrixA[5][3] = x3;
            matrixA[5][4] = y3;
            matrixA[5][5] = 1;
            matrixA[5][6] = -x3 * Y3;
            matrixA[5][7] = -y3 * Y3;

            //{ x4, y4, 1, 0, 0, 0, -x4 * X4, -y4 * X4 }
            matrixA[6] = new double[8];
            matrixA[6][0] = x4;
            matrixA[6][1] = y4;
            matrixA[6][2] = 1;
            matrixA[6][3] = 0;
            matrixA[6][4] = 0;
            matrixA[6][5] = 0;
            matrixA[6][6] = -x4 * X4;
            matrixA[6][7] = -y4 * X4;

            //{ 0, 0, 0, x4, y4, 1, -x4 * Y4, -y4 * Y4 } 
            matrixA[7] = new double[8];
            matrixA[7][0] = 0;
            matrixA[7][1] = 0;
            matrixA[7][2] = 0;
            matrixA[7][3] = x4;
            matrixA[7][4] = y4;
            matrixA[7][5] = 1;
            matrixA[7][6] = -x4 * Y4;
            matrixA[7][7] = -y4 * Y4;

            for (int i = 0; i < matrixA.Length; i++)
            {
                string Satir = null;
                for (int j = 0; j < matrixA[i].Length; j++)
                    Satir = Satir + "," + matrixA[i][j].ToString();

                textBox2.Text = textBox2.Text + Satir + "\r\n";
            }
            //---------------------------------------------------------------------------
            double[][] matrixB = MatrisTersiniAl_2(matrixA);
            //---------------------------------------------------------------------------

            for (int i = 0; i < matrixB.Length; i++)
            {
                string Satir = null;
                for (int j = 0; j < matrixB[i].Length; j++)
                {
                    Satir = Satir + "," + matrixB[i][j].ToString();
                }
                textBox2.Text = textBox2.Text + Satir + "\r\n";
            }

            //---kontrol
            int N = matrixB.Length;
            double[][] matrixC = new double[N][];

            for (int i = 0; i < N; i++)
            {
                string Satir = null;
                for (int j = 0; j < N; j++)
                {

                    matrixC[i] = new double[N];
                    for (int x = 0; x < N; x++)
                    {
                        matrixC[i][j] = matrixC[i][j] + (matrixA[i][x] * matrixB[x][j]);
                    }

                    Satir = Satir + Math.Round(matrixC[i][j], 2).ToString() + ",";
                }
                textBox2.Text = textBox2.Text + Satir + "\r\n";
            }

            //------------------------------------B TERS MATRISI----------------------------
            double[,] BtersMatris = new double[8, 8];

            for (int i = 0; i < matrixB.Length; i++)
            {
                for (int j = 0; j < matrixB[i].Length; j++)
                {
                    BtersMatris[i, j] = matrixB[i][j];
                }
            }

            //----------------------------------- Ekrana yazdırıyor --------------------------------------
            textBox2.Text = textBox2.Text + "==========BtersMatris ===========" + "\r\n";
            for (int i = 0; i < matrixB.Length; i++)
            {
                string Satir = null;
                for (int j = 0; j < matrixB[i].Length; j++)
                {
                    Satir = Satir + BtersMatris[i, j];
                }
                textBox2.Text = textBox2.Text + Satir + "\r\n";
            }

            //----------------------------------- A Dönüşüm Matrisi (A Dönüşüm Vektörü matrise çevrildi) ------------------
            double a00 = 0, a01 = 0, a02 = 0, a10 = 0, a11 = 0, a12 = 0, a20 = 0, a21 = 0, a22 = 0;
            for (int i = 0; i < 8; i++)
            {
                a00 = BtersMatris[0, 0] * X1 + BtersMatris[0, 1] * Y1 + BtersMatris[0, 2] * X2 + BtersMatris[0, 3] * Y2 + BtersMatris[0, 4] * X3 + BtersMatris[0, 5] * Y3 + BtersMatris[0, 6] * X4 + BtersMatris[0, 7] * Y4;
                a01 = BtersMatris[1, 0] * X1 + BtersMatris[1, 1] * Y1 + BtersMatris[1, 2] * X2 + BtersMatris[1, 3] * Y2 + BtersMatris[1, 4] * X3 + BtersMatris[1, 5] * Y3 + BtersMatris[1, 6] * X4 + BtersMatris[1, 7] * Y4;
                a02 = BtersMatris[2, 0] * X1 + BtersMatris[2, 1] * Y1 + BtersMatris[2, 2] * X2 + BtersMatris[2, 3] * Y2 + BtersMatris[2, 4] * X3 + BtersMatris[2, 5] * Y3 + BtersMatris[2, 6] * X4 + BtersMatris[2, 7] * Y4;

                a10 = BtersMatris[3, 0] * X1 + BtersMatris[3, 1] * Y1 + BtersMatris[3, 2] * X2 + BtersMatris[3, 3] * Y2 + BtersMatris[3, 4] * X3 + BtersMatris[3, 5] * Y3 + BtersMatris[3, 6] * X4 + BtersMatris[3, 7] * Y4;
                a11 = BtersMatris[4, 0] * X1 + BtersMatris[4, 1] * Y1 + BtersMatris[4, 2] * X2 + BtersMatris[4, 3] * Y2 + BtersMatris[4, 4] * X3 + BtersMatris[4, 5] * Y3 + BtersMatris[4, 6] * X4 + BtersMatris[4, 7] * Y4;
                a12 = BtersMatris[5, 0] * X1 + BtersMatris[5, 1] * Y1 + BtersMatris[5, 2] * X2 + BtersMatris[5, 3] * Y2 + BtersMatris[5, 4] * X3 + BtersMatris[5, 5] * Y3 + BtersMatris[5, 6] * X4 + BtersMatris[5, 7] * Y4;

                a20 = BtersMatris[6, 0] * X1 + BtersMatris[6, 1] * Y1 + BtersMatris[6, 2] * X2 + BtersMatris[6, 3] * Y2 + BtersMatris[6, 4] * X3 + BtersMatris[6, 5] * Y3 + BtersMatris[6, 6] * X4 + BtersMatris[6, 7] * Y4;
                a21 = BtersMatris[7, 0] * X1 + BtersMatris[7, 1] * Y1 + BtersMatris[7, 2] * X2 + BtersMatris[7, 3] * Y2 + BtersMatris[7, 4] * X3 + BtersMatris[7, 5] * Y3 + BtersMatris[7, 6] * X4 + BtersMatris[7, 7] * Y4;
                a22 = 1;

            }

            //------------------------- Perspektif düzeltme işlemi --------------------------------
            PerspektifDuzelt(a00, a01, a02, a10, a11, a12, a20, a21, a22, X1, Y1, X4, Y4);
        }

        public void PerspektifDuzelt(double a00, double a01, double a02, double a10, double a11, double a12, double a20, double a21, double a22, double X1, double Y1, double X4, double Y4)
        {
            Bitmap GirisResmi, CikisResmi;
            Color OkunanRenk;

            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            Label1.Text = "W=" + ResimGenisligi + "; " + "H" + ResimYuksekligi;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            double X, Y, z;

            for (int x = 0; x < (ResimGenisligi); x++)
            {
                for (int y = 0; y < (ResimYuksekligi); y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    z = a20 * x + a21 * y + 1;
                    X = (a00 * x + a01 * y + a02) / z;
                    Y = (a10 * x + a11 * y + a12) / z;


                    //if (X > 0 && X < ResimGenisligi && Y > 0 && Y < ResimYuksekligi)
                    //    CikisResmi.SetPixel((int)X, (int)Y, OkunanRenk);

                    if (X > X1 && X < X4 && Y > Y1 && Y < Y4) //Çapraz iki köşe dikdörtgen olacak (X1,Y1)-(X2,Y2)
                        CikisResmi.SetPixel((int)X, (int)Y, OkunanRenk);
                }
            }

            pictureBox2.Image = CikisResmi;

        }


        // MATRİS TERSİNİ ALMA---------------------
        public double[][] MatrisTersiniAl_2(double[][] matrixA)
        {
            double ratio, a;
            int n = matrixA.Length;

            double[][] matrixB = new double[n][];
            for (int i = 0; i < n; i++)
                matrixB[i] = new double[n];

            double[][] matrix2 = new double[n][];
            for (int i = 0; i < n; i++)
                matrix2[i] = new double[2 * n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix2[i][j] = matrixA[i][j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = n; j < 2 * n; j++)
                {
                    if (i == (j - n))
                        matrix2[i][j] = 1.0;
                    else
                        matrix2[i][j] = 0.0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (matrix2[i][i] == 0)
                        {
                            matrix2[i][i] = 0.0001; //0 bölme hata veriyordu. 
                        }
                        ratio = matrix2[j][i] / matrix2[i][i];

                        for (int k = 0; k < 2 * n; k++)
                        {
                            matrix2[j][k] -= ratio * matrix2[i][k];
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                a = matrix2[i][i];
                for (int j = 0; j < 2 * n; j++)
                {
                    matrix2[i][j] /= a;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixB[i][j] = matrix2[i][n + j];
                }
            }

            return matrixB;
        }


        // MATRİS TERSİNİ ALMA---------------------
        public double[,] MatrisTersiniAl_1(double[,] matrisA)
        {
            int MatrisBoyutu = Convert.ToInt16(Math.Sqrt(matrisA.Length)); //matris boyutu içindeki eleman sayısı olduğu için karekökünü alarak buluyor.
            double[,] matrisB = new double[MatrisBoyutu, MatrisBoyutu]; //A nın tersi alındığında bu matris içinde tutulacak.

            //--I Birim matrisin içeriğini dolduruyor (B ile gösterildi)
            for (int i = 0; i < MatrisBoyutu; i++)
            {
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    if (i == j)
                        matrisB[i, j] = 1;
                    else
                        matrisB[i, j] = 0;
                }
            }

            //--Matris Tersini alma işlemi---------
            double d, k;

            for (int i = 0; i < MatrisBoyutu; i++)
            {
                d = matrisA[i, i];
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    if (d == 0)
                    {
                        d = 0.0001; //0 bölme hata veriyordu. 
                    }
                    matrisA[i, j] = matrisA[i, j] / d;
                    matrisB[i, j] = matrisB[i, j] / d;
                }
                for (int x = 0; x < MatrisBoyutu; x++)
                {
                    if (x != i)
                    {
                        k = matrisA[x, i];
                        for (int j = 0; j < MatrisBoyutu; j++)
                        {
                            matrisA[x, j] = matrisA[x, j] - matrisA[i, j] * k;
                            matrisB[x, j] = matrisB[x, j] - matrisB[i, j] * k;
                        }
                    }
                }
            }

            return matrisB;
        }

        //*********************************************************************************
        //*********************************************************************************
        private void perspektifDuzeltme2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image=  Perspektif

            double x1 = 47, y1 = 155;
            double x2 = 806, y2 = 101;
            double x3 = 46, y3 = 291;
            double x4 = 726, y4 = 417;

            double X1 = 0, Y1 = 0;
            double X2 = 800, Y2 = 0;
            double X3 = 0, Y3 = 600;
            double X4 = 800, Y4 = 600;

            //double X1 = 0, Y1 = 0;
            //double X2 = 400, Y2 = 0;
            //double X3 = 0, Y3 = 100;
            //double X4 = 400, Y4 = 100;

            double[,] matrisA = new double[8, 8];

            // { x1, y1, 1, 0, 0, 0, -x1 * X1, -y1 * X1 }
            matrisA[0, 0] = x1;
            matrisA[0, 1] = y1;
            matrisA[0, 2] = 1;
            matrisA[0, 3] = 0;
            matrisA[0, 4] = 0;
            matrisA[0, 5] = 0;
            matrisA[0, 6] = -x1 * X1;
            matrisA[0, 7] = -y1 * X1;

            //{ 0, 0, 0, x1, y1, 1, -x1 * Y1, -y1 * Y1 }
            matrisA[1, 0] = 0;
            matrisA[1, 1] = 0;
            matrisA[1, 2] = 0;
            matrisA[1, 3] = x1;
            matrisA[1, 4] = y1;
            matrisA[1, 5] = 1;
            matrisA[1, 6] = -x1 * Y1;
            matrisA[1, 7] = -y1 * Y1;

            //{ x2, y2, 1, 0, 0, 0, -x2 * X2, -y2 * X2 } 
            matrisA[2, 0] = x2;
            matrisA[2, 1] = y2;
            matrisA[2, 2] = 1;
            matrisA[2, 3] = 0;
            matrisA[2, 4] = 0;
            matrisA[2, 5] = 0;
            matrisA[2, 6] = -x2 * X2;
            matrisA[2, 7] = -y2 * X2;

            //{ 0, 0, 0, x2, y2, 1, -x2 * Y2, -y2 * Y2 }
            matrisA[3, 0] = 0;
            matrisA[3, 1] = 0;
            matrisA[3, 2] = 0;
            matrisA[3, 3] = x2;
            matrisA[3, 4] = y2;
            matrisA[3, 5] = 1;
            matrisA[3, 6] = -x2 * Y2;
            matrisA[3, 7] = -y2 * Y2;

            //{ x3, y3, 1, 0, 0, 0, -x3 * X3, -y3 * X3 }
            matrisA[4, 0] = x3;
            matrisA[4, 1] = y3;
            matrisA[4, 2] = 1;
            matrisA[4, 3] = 0;
            matrisA[4, 4] = 0;
            matrisA[4, 5] = 0;
            matrisA[4, 6] = -x3 * X3;
            matrisA[4, 7] = -y3 * X3;

            //{ 0, 0, 0, x3, y3, 1, -x3 * Y3, -y3 * Y3 }
            matrisA[5, 0] = 0;
            matrisA[5, 1] = 0;
            matrisA[5, 2] = 0;
            matrisA[5, 3] = x3;
            matrisA[5, 4] = y3;
            matrisA[5, 5] = 1;
            matrisA[5, 6] = -x3 * Y3;
            matrisA[5, 7] = -y3 * Y3;

            //{ x4, y4, 1, 0, 0, 0, -x4 * X4, -y4 * X4 }
            matrisA[6, 0] = x4;
            matrisA[6, 1] = y4;
            matrisA[6, 2] = 1;
            matrisA[6, 3] = 0;
            matrisA[6, 4] = 0;
            matrisA[6, 5] = 0;
            matrisA[6, 6] = -x4 * X4;
            matrisA[6, 7] = -y4 * X4;

            //{ 0, 0, 0, x4, y4, 1, -x4 * Y4, -y4 * Y4 } 
            matrisA[7, 0] = 0;
            matrisA[7, 1] = 0;
            matrisA[7, 2] = 0;
            matrisA[7, 3] = x4;
            matrisA[7, 4] = y4;
            matrisA[7, 5] = 1;
            matrisA[7, 6] = -x4 * Y4;
            matrisA[7, 7] = -y4 * Y4;

            //---------------------------------------------------------------------------
            double[,] matrisB = MatrisTersiniAl_1(matrisA);
            //---------------------------------------------------------------------------

            //------------Textbox a yazıyor ------------------
            int MatrisBoyutu = Convert.ToInt16(Math.Sqrt(matrisB.Length));
            for (int i = 0; i < MatrisBoyutu; i++)
            {
                string Satir = null;
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    Satir = Satir + ";" + Math.Round(matrisB[i, j], 6);
                }
                textBox2.Text = textBox2.Text + Satir + "\r\n";
            }

            //----------------------------------- A Dönüşüm Matrisi (3x3) ------------------
            double a00 = 0, a01 = 0, a02 = 0, a10 = 0, a11 = 0, a12 = 0, a20 = 0, a21 = 0, a22 = 0;
            for (int i = 0; i < 8; i++)
            {
                a00 = matrisB[0, 0] * X1 + matrisB[0, 1] * Y1 + matrisB[0, 2] * X2 + matrisB[0, 3] * Y2 + matrisB[0, 4] * X3 + matrisB[0, 5] * Y3 + matrisB[0, 6] * X4 + matrisB[0, 7] * Y4;
                a01 = matrisB[1, 0] * X1 + matrisB[1, 1] * Y1 + matrisB[1, 2] * X2 + matrisB[1, 3] * Y2 + matrisB[1, 4] * X3 + matrisB[1, 5] * Y3 + matrisB[1, 6] * X4 + matrisB[1, 7] * Y4;
                a02 = matrisB[2, 0] * X1 + matrisB[2, 1] * Y1 + matrisB[2, 2] * X2 + matrisB[2, 3] * Y2 + matrisB[2, 4] * X3 + matrisB[2, 5] * Y3 + matrisB[2, 6] * X4 + matrisB[2, 7] * Y4;

                a10 = matrisB[3, 0] * X1 + matrisB[3, 1] * Y1 + matrisB[3, 2] * X2 + matrisB[3, 3] * Y2 + matrisB[3, 4] * X3 + matrisB[3, 5] * Y3 + matrisB[3, 6] * X4 + matrisB[3, 7] * Y4;
                a11 = matrisB[4, 0] * X1 + matrisB[4, 1] * Y1 + matrisB[4, 2] * X2 + matrisB[4, 3] * Y2 + matrisB[4, 4] * X3 + matrisB[4, 5] * Y3 + matrisB[4, 6] * X4 + matrisB[4, 7] * Y4;
                a12 = matrisB[5, 0] * X1 + matrisB[5, 1] * Y1 + matrisB[5, 2] * X2 + matrisB[5, 3] * Y2 + matrisB[5, 4] * X3 + matrisB[5, 5] * Y3 + matrisB[5, 6] * X4 + matrisB[5, 7] * Y4;

                a20 = matrisB[6, 0] * X1 + matrisB[6, 1] * Y1 + matrisB[6, 2] * X2 + matrisB[6, 3] * Y2 + matrisB[6, 4] * X3 + matrisB[6, 5] * Y3 + matrisB[6, 6] * X4 + matrisB[6, 7] * Y4;
                a21 = matrisB[7, 0] * X1 + matrisB[7, 1] * Y1 + matrisB[7, 2] * X2 + matrisB[7, 3] * Y2 + matrisB[7, 4] * X3 + matrisB[7, 5] * Y3 + matrisB[7, 6] * X4 + matrisB[7, 7] * Y4;
                a22 = 1;

            }

            //------------------------- Perspektif düzeltme işlemi --------------------------------
            PerspektifDuzelt(a00, a01, a02, a10, a11, a12, a20, a21, a22, X1, Y1, X4, Y4);

        }

        //MEAN FİLTRESİ****************************************
        private void meanFiltresiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Image = MeanFiltresi();
        }

        public Bitmap MeanFiltresi()
        {

            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);


            int SablonBoyutu = 9; //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image;
        }

        //MEDIAN FİLTRESİ*************************************
        private void medianFiltresiToolStripMenuItem_Click(object sender, EventArgs e)
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

        //GAUSS FİLTRESİ*************************************
        private void gaussFiltresiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox2.Image = GaussFiltresi();

        }


        public Bitmap GaussFiltresi()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = 5; //Convert.ToInt16(textBox1.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
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


        //NETLEŞTİRME-------------------------------
        private void netlestirmeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap OrjinalResim = new Bitmap(pictureBox1.Image);

            Bitmap BulanikResim = MeanFiltresi();
            //Bitmap BulanikResim = GaussFiltresi();
            //pictureBox2.Image = BulanikResim;
            Bitmap KenarGoruntusu = OrjianalResimdenBulanikResmiCikarma(OrjinalResim, BulanikResim);
            //Bitmap KenarGoruntusu = OrjianalResimdenBulanikResmiCikarma2(OrjinalResim, BulanikResim);
            //pictureBox2.Image = KenarGoruntusu;
            Bitmap NetlesmisResim = KenarGoruntusuIleOrjinalResmiBirlestir(OrjinalResim, KenarGoruntusu);
            //Bitmap NetlesmisResim = KenarGoruntusuIleOrjinalResmiBirlestir2(OrjinalResim, KenarGoruntusu);


            pictureBox2.Image = NetlesmisResim;
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

                    //===============================================================
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    //================================================================
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

                    //===============================================================
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    //================================================================

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);

                }
            }

            return CikisResmi;
        }


        public Bitmap OrjianalResimdenBulanikResmiCikarma2(Bitmap OrjinalResim, Bitmap BulanikResim)
        {

            Color OkunanRenk1, OkunanRenk2, DonusenRenk;
            Bitmap CikisResmi;

            int ResimGenisligi = OrjinalResim.Width;
            int ResimYuksekligi = OrjinalResim.Height;
            int PikselSayisi = ResimGenisligi * ResimYuksekligi;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int R, G, B;
            int[] Kirmizi = new int[PikselSayisi];
            int[] Yesil = new int[PikselSayisi];
            int[] Mavi = new int[PikselSayisi];

            int PikselNo = 0;
            int EnBuyukR = 0, EnKucukR = 0;
            int EnBuyukG = 0, EnKucukG = 0;
            int EnBuyukB = 0, EnKucukB = 0;

            double Olcekleme = 0.7; //0.2-0.7 arası uygundur.

            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk1 = OrjinalResim.GetPixel(x, y);
                    OkunanRenk2 = BulanikResim.GetPixel(x, y);


                    R = Convert.ToInt16(Olcekleme * (OkunanRenk1.R - OkunanRenk2.R));
                    G = Convert.ToInt16(Olcekleme * (OkunanRenk1.G - OkunanRenk2.G));
                    B = Convert.ToInt16(Olcekleme * (OkunanRenk1.B - OkunanRenk2.B));


                    //Renk değerlerini diziye atıyor
                    Kirmizi[PikselNo] = R;
                    Yesil[PikselNo] = G;
                    Mavi[PikselNo] = B;

                    //Ust sınırları bulmaya çalışıyor
                    if (R > EnBuyukR) EnBuyukR = R;
                    if (G > EnBuyukG) EnBuyukG = G;
                    if (R > EnBuyukB) EnBuyukB = B;

                    //Alt snırı bulmaya çalışıyor. 
                    if (R < EnKucukR) EnKucukR = R;
                    if (G < EnKucukG) EnKucukG = G;
                    if (B < EnKucukB) EnKucukB = B;

                    PikselNo++;

                }
            }

            listBox1.Items.Add(EnBuyukR);
            listBox1.Items.Add(EnBuyukG);
            listBox1.Items.Add(EnBuyukB);
            listBox1.Items.Add(EnKucukR);
            listBox1.Items.Add(EnKucukG);
            listBox1.Items.Add(EnKucukB);
            //ResimNormalleştirme---------------

            int UstDegerR = EnBuyukR, UstDegerG = EnBuyukG, UstDegerB = EnBuyukB;
            int AltDegerR = EnKucukR, AltDegerG = EnKucukG, AltDegerB = EnKucukB;

            if (EnBuyukR > 255) UstDegerR = 255;
            if (EnBuyukG > 255) UstDegerG = 255;
            if (EnBuyukB > 255) UstDegerB = 255;

            if (EnKucukR < 0) AltDegerR = 0;
            if (EnKucukG < 0) AltDegerG = 0;
            if (EnKucukB < 0) AltDegerB = 0;

            PikselNo = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {

                    R = (Kirmizi[PikselNo] - EnKucukR) * ((UstDegerR - AltDegerR) / (EnBuyukR - EnKucukR)) + AltDegerR;
                    G = (Yesil[PikselNo] - EnKucukG) * ((UstDegerG - AltDegerG) / (EnBuyukG - EnKucukG)) + AltDegerG;
                    B = (Mavi[PikselNo] - EnKucukB) * ((UstDegerB - AltDegerB) / (EnBuyukB - EnKucukB)) + AltDegerB;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                    PikselNo++;
                }
            }

            return CikisResmi;
        }

        public Bitmap KenarGoruntusuIleOrjinalResmiBirlestir2(Bitmap OrjinalResim, Bitmap KenarGoruntusu)
        {

            Color OkunanRenk1, OkunanRenk2, DonusenRenk;
            Bitmap CikisResmi;

            int ResimGenisligi = OrjinalResim.Width;
            int ResimYuksekligi = OrjinalResim.Height;
            int PikselSayisi = ResimGenisligi * ResimYuksekligi;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);


            int R, G, B;
            int[] Kirmizi = new int[PikselSayisi];
            int[] Yesil = new int[PikselSayisi];
            int[] Mavi = new int[PikselSayisi];

            int PikselNo = 0;
            int EnBuyukR = 0, EnKucukR = 0;
            int EnBuyukG = 0, EnKucukG = 0;
            int EnBuyukB = 0, EnKucukB = 0;

            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk1 = OrjinalResim.GetPixel(x, y);
                    OkunanRenk2 = KenarGoruntusu.GetPixel(x, y);

                    R = OkunanRenk1.R + OkunanRenk2.R;
                    G = OkunanRenk1.G + OkunanRenk2.G;
                    B = OkunanRenk1.B + OkunanRenk2.B;

                    //Renk değerlerini diziye atıyor
                    Kirmizi[PikselNo] = R;
                    Yesil[PikselNo] = G;
                    Mavi[PikselNo] = B;

                    //Ust sınırları bulmaya çalışıyor
                    if (R > EnBuyukR) EnBuyukR = R;
                    if (G > EnBuyukG) EnBuyukG = G;
                    if (R > EnBuyukB) EnBuyukB = B;

                    //Alt snırı bulmaya çalışıyor. 
                    if (R < EnKucukR) EnKucukR = R;
                    if (G < EnKucukG) EnKucukG = G;
                    if (B < EnKucukB) EnKucukB = B;

                    PikselNo++;

                }
            }
            listBox1.Items.Add("===============");
            listBox1.Items.Add(EnBuyukR);
            listBox1.Items.Add(EnBuyukG);
            listBox1.Items.Add(EnBuyukB);
            listBox1.Items.Add(EnKucukR);
            listBox1.Items.Add(EnKucukG);
            listBox1.Items.Add(EnKucukB);
            //ResimNormalleştirme---------------

            int UstDegerR = EnBuyukR, UstDegerG = EnBuyukG, UstDegerB = EnBuyukB;
            int AltDegerR = EnKucukR, AltDegerG = EnKucukG, AltDegerB = EnKucukB;

            if (EnBuyukR > 255) UstDegerR = 255;
            if (EnBuyukG > 255) UstDegerG = 255;
            if (EnBuyukB > 255) UstDegerB = 255;

            if (EnKucukR < 0) AltDegerR = 0;
            if (EnKucukG < 0) AltDegerG = 0;
            if (EnKucukB < 0) AltDegerB = 0;

            PikselNo = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {

                    R = (Kirmizi[PikselNo] - EnKucukR) * ((UstDegerR - AltDegerR) / (EnBuyukR - EnKucukR)) + AltDegerR;
                    G = (Yesil[PikselNo] - EnKucukG) * ((UstDegerG - AltDegerG) / (EnBuyukG - EnKucukG)) + AltDegerG;
                    B = (Mavi[PikselNo] - EnKucukB) * ((UstDegerB - AltDegerB) / (EnBuyukB - EnKucukB)) + AltDegerB;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                    PikselNo++;
                }
            }
            return CikisResmi;
        }

        //NETLEŞTİRME-matrisli uygulama
        private void netlestirme2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;


            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;

            int R, G, B;
            int[] Matris = { 0, -2, 0, -2, 11, -2, 0, -2, 0 };
            int MatrisToplami = 0 + -2 + 0 + -2 + 11 + -2 + 0 + -2 + 0;

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

                            R = toplamR / MatrisToplami;
                            G = toplamG / MatrisToplami;
                            B = toplamB / MatrisToplami;

                            //===========================================================
                            //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                            if (R > 255) R = 255;
                            if (G > 255) G = 255;
                            if (B > 255) B = 255;

                            if (R < 0) R = 0;
                            if (G < 0) G = 0;
                            if (B < 0) B = 0;
                            //===========================================================

                            CikisResmi.SetPixel(x, y, Color.FromArgb(R, G, B));

                            k++;
                        }

                    }

                }
            }
            pictureBox2.Image = CikisResmi;


        }

        private void sobelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;


            int x, y; //, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;

            //int R, G, B;

            //int[] MatrisDikey = { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
            //int[] MatrisYatay = { 2, 1, 0, 1, 0, -1, 0, -1, -2 };
            //int[] MatrisCapraz = { 1, 2, 1, 0, 0, 0, -1, -2, -1 };
            //int MatrisToplami = 0; 

            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    //toplamR = 0;
                    //toplamG = 0;
                    //toplamB = 0;

                    /*
                    //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                    int k = 0; //matris içindeki elemanları sırayla okurken kullanılacak.
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);

                            toplamR = toplamR + Convert.ToInt16(Math.Sqrt((OkunanRenk.R * MatrisDikey[k]) * (OkunanRenk.R * MatrisDikey[k]) + (OkunanRenk.R * MatrisYatay[k]) * (OkunanRenk.R * MatrisYatay[k]))); //+OkunanRenk.R * MatrisCapraz[k];
                            //toplamG = toplamG + OkunanRenk.G * MatrisDikey[k] + OkunanRenk.G * MatrisYatay[k]; //+OkunanRenk.G * MatrisCapraz[k];
                            //toplamB = toplamB + OkunanRenk.B * MatrisDikey[k] + OkunanRenk.B * MatrisYatay[k]; //+OkunanRenk.B * MatrisCapraz[k];

                            R = toplamR; 
                            G = R; 
                            B = R; 



                            //===============================================================
                            //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                            if (R > 255) R = 255;
                            if (G > 255) G = 255;
                            if (B > 255) B = 255;

                            if (R < 0) R = 0;
                            if (G < 0) G = 0;
                            if (B < 0) B = 0;
                            //================================================================


                            CikisResmi.SetPixel(x, y, Color.FromArgb(R, G, B));

                            k++;
                        }

                    }
                    */
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
            pictureBox2.Image = CikisResmi;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        //EŞİKLEME -------------------------------------
        public Bitmap ResmiEsiklemeYap(Bitmap GirisResmi)
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk;
            //Bitmap GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            Bitmap CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.

            //Eşik değerini trackBar'dan alacaktır. 
            int EsikDegeri = trackBar1.Value;

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    if (OkunanRenk.R >= EsikDegeri)
                        R = 255;
                    else
                        R = 0;

                    if (OkunanRenk.G >= EsikDegeri)
                        G = 255;
                    else
                        G = 0;

                    if (OkunanRenk.B >= EsikDegeri)
                        B = 255;
                    else
                        B = 0;

                    Color DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }

            return CikisResmi;
        }


        //RESMİ BÖLGELERE AYIRMA******************************
        private void bolgelereAyirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap GirisResmi, CikisResmi;

            int KomsularinEnKucukEtiketDegeri = 0;

            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            int PikselSayisi = ResimGenisligi * ResimYuksekligi;

            GirisResmi = ResmiGriTonaDonustur(GirisResmi); //Resmi önce gri tona dönüştürüyor.
            GirisResmi = ResmiEsiklemeYap(GirisResmi); //Resmi 128 ile eşikleme siyah beyaz yapıyor.
            pictureBox1.Image = GirisResmi; //Resmin son halini gösteriyor. 

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);


            int x, y, i, j, EtiketNo = 0;

            int[,] EtiketNumarasi = new int[ResimGenisligi, ResimYuksekligi]; //Resmin her pikselinin etiket numarası tutulacak.

            //Tüm piksellerin Etiket numarasını başlangıçta 0 olarak atayacak. Siyah ve beyaz farketmez. Zaten ileride beyaz olanlara numara verilecek.
            for (x = 0; x < ResimGenisligi; x++)
            {
                for (y = 0; y < ResimYuksekligi; y++)
                {
                    EtiketNumarasi[x, y] = 0;
                }
            }

            int IlkDeger = 0, SonDeger = 0;
            bool DegisimVar = false; //Etiket numaralarında değişim olmayana kadar dönmesi için sonsuz döngüyü kontrol edecek. 
            do //etiket numaralarında değişim kalmayana kadar dönecek.
            {
                DegisimVar = false;
                //------------------------- Resmi tarıyor ----------------------------
                for (y = 1; y < ResimYuksekligi - 1; y++) //Resmin 1 piksel içerisinden başlayıp, bitirecek. Çünkü çekirdek şablon en dış kenardan başlamalı.
                {
                    for (x = 1; x < ResimGenisligi - 1; x++)
                    {
                        //Resim siyah beyaz olduğu için tek kanala bakmak yeterli olacak. Sıradaki piksel beyaz ise işlem yap. Beyaz olduğu 255 yerine 128 kullanarak yapıldı.
                        if (GirisResmi.GetPixel(x, y).R > 128)
                        {

                            //işlem öncesi ele alınan pikselin etiket değerini okuyacak. İşlemler bittikten sonra bu değer değişirse, sonsuz döngü için işlem yapılmış demektir.
                            IlkDeger = EtiketNumarasi[x, y];

                            //Komşular arasında en küçük etiket numarasını bulacak.
                            KomsularinEnKucukEtiketDegeri = 0;
                            for (j = -1; j <= 1; j++) //Çekirdek şablon 3x3 lük bir matris. Dolayısı ile x,y nin -1 den başlayıp +1 ne kadar yer kaplar.
                            {
                                for (i = -1; i <= 1; i++)
                                {

                                    if (EtiketNumarasi[x + i, y + j] != 0 && KomsularinEnKucukEtiketDegeri == 0)  //hücrenin etiketi varsa ve daha hiç en küçük atanmadı ise ilk okuduğu bu değeri en küçük olarak atayacak.
                                    {
                                        KomsularinEnKucukEtiketDegeri = EtiketNumarasi[x + i, y + j];
                                    }
                                    else if (EtiketNumarasi[x + i, y + j] < KomsularinEnKucukEtiketDegeri && EtiketNumarasi[x + i, y + j] != 0 && KomsularinEnKucukEtiketDegeri != 0)  //En küçük değer ve okunan hücreye etiket atanmışsa, içindeki değer en küçük değerden küçük ise  o zaman en küçük o hücrenin değeri olmalıdır. 
                                    {
                                        KomsularinEnKucukEtiketDegeri = EtiketNumarasi[x + i, y + j];
                                    }
                                }
                            }

                            if (KomsularinEnKucukEtiketDegeri != 0) //Beyaz komşu buldu ve içlerinde en küçük etiket değerine sahip numara da var.  O zaman orta piksele o numarayı ata.
                            {
                                EtiketNumarasi[x, y] = KomsularinEnKucukEtiketDegeri;
                            }
                            else if (KomsularinEnKucukEtiketDegeri == 0) //Komşuların hiç birinde etiket numarası yoksa o zaman yeni bir numara ata
                            {
                                EtiketNo = EtiketNo + 1;
                                EtiketNumarasi[x, y] = EtiketNo;
                            }

                            SonDeger = EtiketNumarasi[x, y]; //İşlem öncesi ve işlem sonrası değerler aynı ise ve butün piksellerde hep aynı olursa artık değişim yok demektir.

                            if (IlkDeger != SonDeger)
                                DegisimVar = true;

                        }

                    }
                }
            } while (DegisimVar == true);


            // Etiket değerine bağlı resmi renklendirecek-----------------------
            // Önce etiket numaralarını diziye çekecek. 
            int[] DiziEtiket = new int[PikselSayisi];
            i = 0;
            for (x = 1; x < ResimGenisligi - 1; x++)
            {
                for (y = 1; y < ResimYuksekligi - 1; y++)
                {
                    i++;
                    DiziEtiket[i] = EtiketNumarasi[x, y];
                }
            }

            //Dizideki etiket numaralarını sıralıyor. Hazır fonksiyon kullanıyor. 
            Array.Sort(DiziEtiket);

            //Tekrar eden etiket numaraarını çıkarıyor. Hazır fonksiyon kullanıyor.
            int[] TekrarsizEtiketNumaralari = DiziEtiket.Distinct().ToArray();

            int[] RenkDizisi = new int[TekrarsizEtiketNumaralari.Length];

            for (j = 0; j < TekrarsizEtiketNumaralari.Length; j++)
            {
                RenkDizisi[j] = TekrarsizEtiketNumaralari[j]; //sıradaki ilk renge, ait olacağı etiketin kaç numara olacağını atıyor. 
            }

            int RenkSayisi = RenkDizisi.Length;

            Color[] Renkler = new Color[RenkSayisi];
            Random Rastgele = new Random();
            int Kirmizi, Yesil, Mavi;

            for (int r = 0; r < RenkSayisi; r++) //sonraki renkler.
            {
                Kirmizi = Rastgele.Next(5, 25) * 10; //Açık renkler elde etmek ve 10 katları şeklinde olmasını sağlıyor. yani 150-250 arasındaki sayıları atıyor.
                Yesil = Rastgele.Next(5, 25) * 10;
                Mavi = Rastgele.Next(5, 25) * 10;

                Renkler[r] = Color.FromArgb(Kirmizi, Yesil, Mavi);
            }

            //Color[] Renkler= { Color.Black, Color.Blue, Color.Red, Color.Orange, Color.LightPink, Color.LightYellow, Color.LimeGreen, Color.MediumPurple, Color.Olive, Color.Magenta, Color.Maroon, Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.LightBlue, Color.Azure, Color.White  };

            for (x = 1; x < ResimGenisligi - 1; x++) //Resmin 1 piksel içerisinden başlayıp, bitirecek. Çünkü çekirdek şablon en dış kenardan başlamalı.
            {
                for (y = 1; y < ResimYuksekligi - 1; y++)
                {
                    int RenkSiraNo = Array.IndexOf(RenkDizisi, EtiketNumarasi[x, y]); //Dikkat: önemli bir komut. Dizinin değerinden sıra numarasını alıyor. int[] array = { 2, 3, 5, 7, 11, 13 }; int index = Array.IndexOf(array, 11); // returns 4

                    if (GirisResmi.GetPixel(x, y).R < 128) //Eğer bu pikselin rengi siyah ise aynı pikselin CikisResmi resmide siyah yapılacak.
                    {
                        CikisResmi.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        CikisResmi.SetPixel(x, y, Renkler[RenkSiraNo]);
                    }
                }
            }



            pictureBox2.Image = CikisResmi;
        }

        //SINAV SORUSU
        private void ciktiSorusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = 300;
            int B = 200;
            int C = 200;
            int D = 150;
            int E = 100;
            int F = 50;
            Color G = Color.White;
            Color H = Color.Black;

            Bitmap CikisResmi = new Bitmap(A, B);

            for (int x = 0; x < A; x++)
            {
                for (int y = 0; y < B; y++)
                {
                    if (x < C && x > E && y < D && y > F)
                        CikisResmi.SetPixel(x, y, G);
                    else
                        CikisResmi.SetPixel(x, y, H);
                }
            }
            pictureBox2.Image = CikisResmi;

        }

        private void balonTanimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            int R = 0, G = 0, B = 0;
            Color OkunanRenk;
            Bitmap GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;
            Bitmap  CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur.

            //Eşik değerini trackBar'dan alacaktır. 
            int EsikDegeri = trackBar1.Value;

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {

                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    if (OkunanRenk.R >= 150 && OkunanRenk.G < 50 && OkunanRenk.B < 50)
                    {
                        R = 255;
                        G = 0;
                        B = 0;
                    }
                    else
                    {
                        R = 0;
                        G = 0;
                        B = 0;
                    }

  
                    Color DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }

            pictureBox2.Image = CikisResmi;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            GirisResmi = new Bitmap(pictureBox1.Image);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;

            Bitmap GirisResmi = new Bitmap(pictureBox1.Image);

            OkunanRenk = GirisResmi.GetPixel(X, Y);


            toolStripLabel1.Text = "R= " + OkunanRenk.R + ";  G= " + OkunanRenk.G + ";  B=  " + OkunanRenk.B;

           
        }


     

    }
}
