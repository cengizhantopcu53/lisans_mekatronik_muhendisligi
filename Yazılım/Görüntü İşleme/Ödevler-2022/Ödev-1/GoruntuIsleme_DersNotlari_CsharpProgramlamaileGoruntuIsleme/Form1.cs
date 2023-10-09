using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme_DersNotlari_CsharpProgramlamaileGoruntuIsleme
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
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = pictureBox1.Image;

            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

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

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
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

        //Resimin Negatifini Alma
        private void btnNegatif_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü yüklendi.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = 255 - OkunanRenk.R;
                    G = 255 - OkunanRenk.G;
                    B = 255 - OkunanRenk.B;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        //Gri Ton Resmi
        private void btnGri_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

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
                    int Gri = Convert.ToInt16(R*0.3 + G*0.6 + B*0.1);   //Gri Ton

                    DonusenRenk = Color.FromArgb(Gri, Gri, Gri);
                    CikisResmi.SetPixel(x, y, DonusenRenk);

                }
            }
            pictureBox2.Image = CikisResmi;
        }

        //Parlaklık
        private void trackParlaklik_Scroll(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü yüklendi.
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.

            int i = 0, j = 0; //Çıkış resminin x ve y si olacak.
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);

                    int Artis = trackParlaklik.Value - 100;
                    lblParlaklik.Text = Artis.ToString();

                    R = OkunanRenk.R + Artis;
                    G = OkunanRenk.G + Artis;
                    B = OkunanRenk.B + Artis;

                    if (R > 255) R = 255; 
                    if (G > 255) G = 255; 
                    if (B > 255) B = 255;

                    if (R < 0) R = 0;
                    if (G > 0) G = 0;
                    if (B > 0) B = 0;

                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);

                }
            }
            pictureBox2.Image = CikisResmi;
        }

        //Ödev-1 a)
        private void btnGoruntuDegistir_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

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

                    if (checkBoxR.Checked == true && checkBoxG.Checked == false && checkBoxB.Checked == false)
                    {
                        DonusenRenk = Color.FromArgb(0, G, B);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = "R= " + 0 + ";  G= " + OkunanRenk.G + ";  B=  " + OkunanRenk.B;
                    }

                    if (checkBoxR.Checked == false && checkBoxG.Checked == true && checkBoxB.Checked == false)
                    {
                        DonusenRenk = Color.FromArgb(R, 0, B);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = "R= " + OkunanRenk.R + "  G= " + 0 + "  B=  " + OkunanRenk.B;
                    }

                    if (checkBoxR.Checked == false && checkBoxG.Checked == false && checkBoxB.Checked == true)
                    {
                        DonusenRenk = Color.FromArgb(R, G, 0);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = "R= " + OkunanRenk.R + "  G= " + OkunanRenk.G + "  B=  " + 0;
                    }

                    if (checkBoxR.Checked == true && checkBoxG.Checked == true && checkBoxB.Checked == false)
                    {
                        DonusenRenk = Color.FromArgb(0, 0, B);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = "R= " + 0 + "  G= " + 0 + "  B=  " + OkunanRenk.B;
                    }

                    if (checkBoxR.Checked == true && checkBoxG.Checked == false && checkBoxB.Checked == true)
                    {
                        DonusenRenk = Color.FromArgb(0, G, 0);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = "R= " + 0 + "  G= " + OkunanRenk.G + "  B=  " + 0;
                    }

                    if (checkBoxR.Checked == false && checkBoxG.Checked == true && checkBoxB.Checked == true)
                    {
                        DonusenRenk = Color.FromArgb(R, 0, 0);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = "R= " + OkunanRenk.R + "  G= " + 0 + "  B=  " + 0;
                    }

                    if (checkBoxR.Checked == true && checkBoxG.Checked == true && checkBoxB.Checked == true)
                    {
                        DonusenRenk = Color.FromArgb(0, 0, 0);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = "R= " + 0 + "  G= " + 0 + "  B=  " + 0;
                    }

                    if (checkBoxR.Checked == false && checkBoxG.Checked == false && checkBoxB.Checked == false)
                    {
                        DonusenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = "R= " + OkunanRenk.R + "  G= " + OkunanRenk.G + "  B=  " + OkunanRenk.B;
                    }
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        //Ödev-1 b)
        private void btnGrilestir_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

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

                    if (radioButtonR.Checked== true)
                    {
                        int Gri = R;  //Kırmızı Ton
                        DonusenRenk = Color.FromArgb(Gri, Gri, Gri);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = Gri.ToString();
                    }

                    if (radioButtonG.Checked == true)
                    {
                        int Gri = G;  //Yeşil Ton
                        DonusenRenk = Color.FromArgb(Gri, Gri, Gri);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = Gri.ToString();
                    }

                    if (radioButtonB.Checked == true)
                    {
                        int Gri = B;  //Mavi Ton
                        DonusenRenk = Color.FromArgb(Gri, Gri, Gri);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                        label1.Text = Gri.ToString();
                    }
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        //Ödev-1 c)
        private void btnKatsayı_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            int R = 0, G = 0, B = 0;

            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

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

                    double KatsayiR, KatsayiG, KatsayiB;
                    KatsayiR = Convert.ToDouble(textBoxR.Text);
                    KatsayiG = Convert.ToDouble(textBoxG.Text);
                    KatsayiB = Convert.ToDouble(textBoxB.Text);

                    int Gri = Convert.ToInt16(R * KatsayiR + G * KatsayiG + B * KatsayiB);   //Gri Ton

                    DonusenRenk = Color.FromArgb(Gri, Gri, Gri);
                    CikisResmi.SetPixel(x, y, DonusenRenk);

                }
            }
            pictureBox2.Image = CikisResmi;
        }

        //Ödev-1 e) 
        private void btnCalistir_Click(object sender, EventArgs e)
        {
            ArrayList DiziPiksel = new ArrayList();

            int OrtalamaRenk = 0; 
            Color OkunanRenk; 
            int R = 0, G = 0, B = 0; 
            Bitmap GirisResmi; //Histogram için giriş resmi gri-ton olmalıdır.
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
            int ResimYuksekligi = GirisResmi.Height;

            int i = 0; //piksel sayısı tutulacak.
            for (int x = 0; x < GirisResmi.Width; x++) 
            { 
                for (int y = 0; y < GirisResmi.Height; y++) 
                { 
                    OkunanRenk = GirisResmi.GetPixel(x, y); 
                    OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.
                    DiziPiksel.Add(OrtalamaRenk); //Resimdeki tüm noktaları diziye atıyor.
                }
            }

            int[] DiziPikselSayilari = new int[256]; 
            for (int r = 0; r < 255; r++) //256 tane renk tonu için dönecek.
            { 
                int PikselSayisi=0; 
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
            Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 1); 
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1); 
            CizimAlani = pictureBox2.CreateGraphics();

            pictureBox2.Refresh(); 
            int GrafikYuksekligi = 400; 
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi, OlcekX = 1.6; 
            for (int x = 0; x <= 255; x++)
            {
                CizimAlani.DrawLine(Kalem1, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY))); if (x % 50 == 0) CizimAlani.DrawLine(Kalem2, (int)(20 + x * OlcekX), GrafikYuksekligi, (int)(20 + x * OlcekX), 0);
            }
            textBox1.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();
        }
    }
}
