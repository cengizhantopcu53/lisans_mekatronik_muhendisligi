using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Problem Parametreleri
        string[] Dugumler = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
        int[,] MesafeMatrisi;
        int[,] CozumMatrisi;
        int iterasyon;
        #endregion

        void BaslangicCozumleri()
        {
            int i, j, secilenDugum = 0;
            int[] demoCozum;
            Random DugumSec = new Random();            

            for (i = 0; i < populasyon; i++)
            {
                demoCozum = new int[Dugumler.Length + 1];
                for (j = 0; j < Dugumler.Length; j++)
                {
                    do
                        secilenDugum = DugumSec.Next(Dugumler.Length) + 1;
                    while (Array.IndexOf(demoCozum, secilenDugum) != -1);
                    demoCozum[j] = secilenDugum;
                }
                demoCozum[j] = demoCozum[0];

                for (j = 0; j < demoCozum.Length; j++)
                    CozumMatrisi[i, j] = demoCozum[j];
                CozumMatrisi[i, j] = MaliyetHesapla(demoCozum);
            }
        }

        int MaliyetHesapla(int[] MuhtemelCozum)
        {
            int maliyet = 0, i;

            for (i = 0; i < 10; i++)
            {
                maliyet += MesafeMatrisi[MuhtemelCozum[i] - 1, MuhtemelCozum[i + 1] - 1];
            }
            return maliyet;
        }

        #region GA Parametre ve Operatörleri

        int populasyon, caprazlama, mutasyon;
        double[] rulet;

        void RuleteYerlestir()
        {
            int i, toplamMaliyet = 0;
            rulet = new double[populasyon];
            for (i = 0; i < populasyon; i++)
                toplamMaliyet += CozumMatrisi[i, 11];
            rulet[0] = (CozumMatrisi[0, 11] / (double)toplamMaliyet) * 360;
            for (i = 1; i < populasyon; i++)
                rulet[i] = rulet[i - 1] + (CozumMatrisi[i, 11] / (double)toplamMaliyet) * 360;
        }

        #endregion GA Parametre ve Operatörleri

        #region KKS Parametre ve Operatörleri
        double alfa, beta, rho, q0;
        double[,] feromonMatrisi;

        void YerelFeromonGuncelleme()
        {
            int i, j;
            // Feromon buharlaştırılıyor
            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                    feromonMatrisi[i, j] *= 1 - rho;

            // Feromon eklemesi yapılıyor
            for (i = 0; i < 5; i++)
                for (j = 0; j < 10; j++)
                    feromonMatrisi[CozumMatrisi[i, j] - 1, CozumMatrisi[i, j + 1] - 1] += 1 / (double)CozumMatrisi[i, 11];
        }

        void GenelFeromonGuncelleme()
        {
            int i, indis = 100, maliyet = 1000000;
            for (i = 0; i < populasyon; i++)
                if (CozumMatrisi[i, 11] < maliyet)
                {
                    maliyet = CozumMatrisi[i, 11];
                    indis = i;
                }

            //for (i = 0; i < 10; i++)
            //    feromonMatrisi[CozumMatrisi[indis, i] - 1, CozumMatrisi[indis, i + 1] - 1] *= 1 - rho;
            for (i = 0; i < 10; i++)
                feromonMatrisi[CozumMatrisi[indis, i] - 1, CozumMatrisi[indis, i + 1] - 1] += 1 / (double)maliyet;
        }

        #endregion KKS Parametre ve Operatörleri

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int i;
            if(radioButton2.Checked==true)
            {
                #region Karınca Koloni Sistemi
                populasyon = Convert.ToInt32(txtKarincaSayisi.Text);
                alfa = Convert.ToDouble(txtAlfa.Text);
                beta = Convert.ToDouble(txtBeta.Text);
                rho = Convert.ToDouble(txtRho.Text);
                q0 = Convert.ToDouble(txtq0.Text);
                CozumMatrisi = new int[populasyon, Dugumler.Length + 2];
                #endregion Karınca Koloni Sistemi
            }
            else
            {
                #region Genetik Algoritma
                int cap, mut;
                populasyon = Convert.ToInt32(txtPop.Text);
                caprazlama = Convert.ToInt32(txtCap.Text);
                mutasyon = Convert.ToInt32(txtMut.Text);

                cap = 2 * ((populasyon * caprazlama) / 100);
                mut = (populasyon * mutasyon) / 100;
                CozumMatrisi = new int[populasyon + cap + mut, Dugumler.Length + 2];
                #endregion Genetik Algoritma
            }
           
            iterasyon = Convert.ToInt32(txtIterasyon.Text);
            
            BaslangicCozumleri();

            if(radioButton2.Checked==true)
            {
                for (i = 0; i < iterasyon;i++)
                {
                    YerelFeromonGuncelleme();
                    GenelFeromonGuncelleme();
                }
            }
            else
            {
                RuleteYerlestir();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Mesafe Matrisi tanımlanıyor
            MesafeMatrisi = new int[20, 20];
            MesafeMatrisi[0, 0] = 0;
            MesafeMatrisi[0, 1] = 9;
            MesafeMatrisi[0, 2] = 4;
            MesafeMatrisi[0, 3] = 6;
            MesafeMatrisi[0, 4] = 1;
            MesafeMatrisi[0, 5] = 5;
            MesafeMatrisi[0, 6] = 3;
            MesafeMatrisi[0, 7] = 8;
            MesafeMatrisi[0, 8] = 4;
            MesafeMatrisi[0, 9] = 7;
            MesafeMatrisi[1, 0] = 9;
            MesafeMatrisi[1, 1] = 0;
            MesafeMatrisi[1, 2] = 2;
            MesafeMatrisi[1, 3] = 7;
            MesafeMatrisi[1, 4] = 4;
            MesafeMatrisi[1, 5] = 9;
            MesafeMatrisi[1, 6] = 6;
            MesafeMatrisi[1, 7] = 3;
            MesafeMatrisi[1, 8] = 8;
            MesafeMatrisi[1, 9] = 3;
            MesafeMatrisi[2, 0] = 4;
            MesafeMatrisi[2, 1] = 2;
            MesafeMatrisi[2, 2] = 0;
            MesafeMatrisi[2, 3] = 9;
            MesafeMatrisi[2, 4] = 6;
            MesafeMatrisi[2, 5] = 8;
            MesafeMatrisi[2, 6] = 3;
            MesafeMatrisi[2, 7] = 5;
            MesafeMatrisi[2, 8] = 1;
            MesafeMatrisi[2, 9] = 3;
            MesafeMatrisi[3, 0] = 6;
            MesafeMatrisi[3, 1] = 7;
            MesafeMatrisi[3, 2] = 9;
            MesafeMatrisi[3, 3] = 0;
            MesafeMatrisi[3, 4] = 4;
            MesafeMatrisi[3, 5] = 4;
            MesafeMatrisi[3, 6] = 6;
            MesafeMatrisi[3, 7] = 8;
            MesafeMatrisi[3, 8] = 3;
            MesafeMatrisi[3, 9] = 6;
            MesafeMatrisi[4, 0] = 1;
            MesafeMatrisi[4, 1] = 4;
            MesafeMatrisi[4, 2] = 6;
            MesafeMatrisi[4, 3] = 4;
            MesafeMatrisi[4, 4] = 0;
            MesafeMatrisi[4, 5] = 5;
            MesafeMatrisi[4, 6] = 6;
            MesafeMatrisi[4, 7] = 2;
            MesafeMatrisi[4, 8] = 3;
            MesafeMatrisi[4, 9] = 8;
            MesafeMatrisi[5, 0] = 5;
            MesafeMatrisi[5, 1] = 9;
            MesafeMatrisi[5, 2] = 8;
            MesafeMatrisi[5, 3] = 4;
            MesafeMatrisi[5, 4] = 5;
            MesafeMatrisi[5, 5] = 0;
            MesafeMatrisi[5, 6] = 4;
            MesafeMatrisi[5, 7] = 2;
            MesafeMatrisi[5, 8] = 7;
            MesafeMatrisi[5, 9] = 3;
            MesafeMatrisi[6, 0] = 3;
            MesafeMatrisi[6, 1] = 6;
            MesafeMatrisi[6, 2] = 3;
            MesafeMatrisi[6, 3] = 6;
            MesafeMatrisi[6, 4] = 6;
            MesafeMatrisi[6, 5] = 4;
            MesafeMatrisi[6, 6] = 0;
            MesafeMatrisi[6, 7] = 9;
            MesafeMatrisi[6, 8] = 5;
            MesafeMatrisi[6, 9] = 4;
            MesafeMatrisi[7, 0] = 8;
            MesafeMatrisi[7, 1] = 3;
            MesafeMatrisi[7, 2] = 5;
            MesafeMatrisi[7, 3] = 8;
            MesafeMatrisi[7, 4] = 2;
            MesafeMatrisi[7, 5] = 2;
            MesafeMatrisi[7, 6] = 9;
            MesafeMatrisi[7, 7] = 0;
            MesafeMatrisi[7, 8] = 7;
            MesafeMatrisi[7, 9] = 8;
            MesafeMatrisi[8, 0] = 4;
            MesafeMatrisi[8, 1] = 8;
            MesafeMatrisi[8, 2] = 1;
            MesafeMatrisi[8, 3] = 3;
            MesafeMatrisi[8, 4] = 3;
            MesafeMatrisi[8, 5] = 7;
            MesafeMatrisi[8, 6] = 5;
            MesafeMatrisi[8, 7] = 7;
            MesafeMatrisi[8, 8] = 0;
            MesafeMatrisi[8, 9] = 6;
            MesafeMatrisi[9, 0] = 7;
            MesafeMatrisi[9, 1] = 3;
            MesafeMatrisi[9, 2] = 3;
            MesafeMatrisi[9, 3] = 6;
            MesafeMatrisi[9, 4] = 8;
            MesafeMatrisi[9, 5] = 3;
            MesafeMatrisi[9, 6] = 4;
            MesafeMatrisi[9, 7] = 8;
            MesafeMatrisi[9, 8] = 6;
            MesafeMatrisi[9, 9] = 0;
            #endregion Mesafe Matrisi tanımlanıyor

            #region Feromon Matrisi tanımlanıyor
            feromonMatrisi = new double[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    feromonMatrisi[i, j] = 0.1;
            #endregion Feromon Matrisi tanımlanıyor
        }


    }
}
