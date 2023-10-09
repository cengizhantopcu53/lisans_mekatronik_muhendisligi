
namespace GoruntuIsleme_DersNotlari_CsharpProgramlamaileGoruntuIsleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAc = new System.Windows.Forms.ToolStripButton();
            this.BtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBoyutAyarla = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSagaAktar = new System.Windows.Forms.ToolStripButton();
            this.btnSolaAktar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNegatif = new System.Windows.Forms.ToolStripButton();
            this.btnGri = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackParlaklik = new System.Windows.Forms.TrackBar();
            this.lblParlaklik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoruntuDegistir = new System.Windows.Forms.Button();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxG = new System.Windows.Forms.CheckBox();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrilestir = new System.Windows.Forms.Button();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKatsayı = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackParlaklik)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAc,
            this.BtnKaydet,
            this.toolStripSeparator1,
            this.btnBoyutAyarla,
            this.toolStripSeparator2,
            this.btnSagaAktar,
            this.btnSolaAktar,
            this.toolStripSeparator3,
            this.btnNegatif,
            this.btnGri});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1902, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAc
            // 
            this.BtnAc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAc.Image = ((System.Drawing.Image)(resources.GetObject("BtnAc.Image")));
            this.BtnAc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAc.Name = "BtnAc";
            this.BtnAc.Size = new System.Drawing.Size(29, 24);
            this.BtnAc.Text = "toolStripButton1";
            this.BtnAc.ToolTipText = "Aç";
            this.BtnAc.Click += new System.EventHandler(this.BtnAc_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.Image")));
            this.BtnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(29, 24);
            this.BtnKaydet.Text = "toolStripButton2";
            this.BtnKaydet.ToolTipText = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnBoyutAyarla
            // 
            this.btnBoyutAyarla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBoyutAyarla.Image = ((System.Drawing.Image)(resources.GetObject("btnBoyutAyarla.Image")));
            this.btnBoyutAyarla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoyutAyarla.Name = "btnBoyutAyarla";
            this.btnBoyutAyarla.Size = new System.Drawing.Size(29, 24);
            this.btnBoyutAyarla.Text = "toolStripButton1";
            this.btnBoyutAyarla.ToolTipText = "Boyut Ayarla";
            this.btnBoyutAyarla.Click += new System.EventHandler(this.btnBoyutAyarla_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSagaAktar
            // 
            this.btnSagaAktar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSagaAktar.Image = ((System.Drawing.Image)(resources.GetObject("btnSagaAktar.Image")));
            this.btnSagaAktar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSagaAktar.Name = "btnSagaAktar";
            this.btnSagaAktar.Size = new System.Drawing.Size(29, 24);
            this.btnSagaAktar.Text = "toolStripButton2";
            this.btnSagaAktar.ToolTipText = "Sağa Aktar";
            this.btnSagaAktar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnSolaAktar
            // 
            this.btnSolaAktar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSolaAktar.Image = ((System.Drawing.Image)(resources.GetObject("btnSolaAktar.Image")));
            this.btnSolaAktar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSolaAktar.Name = "btnSolaAktar";
            this.btnSolaAktar.Size = new System.Drawing.Size(29, 24);
            this.btnSolaAktar.Text = "toolStripButton3";
            this.btnSolaAktar.ToolTipText = "Sola Aktar";
            this.btnSolaAktar.Click += new System.EventHandler(this.btnSolaAktar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnNegatif
            // 
            this.btnNegatif.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNegatif.Image = ((System.Drawing.Image)(resources.GetObject("btnNegatif.Image")));
            this.btnNegatif.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNegatif.Name = "btnNegatif";
            this.btnNegatif.Size = new System.Drawing.Size(29, 24);
            this.btnNegatif.Text = "toolStripButton3";
            this.btnNegatif.ToolTipText = "Negatif";
            this.btnNegatif.Click += new System.EventHandler(this.btnNegatif_Click);
            // 
            // btnGri
            // 
            this.btnGri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGri.Image = ((System.Drawing.Image)(resources.GetObject("btnGri.Image")));
            this.btnGri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGri.Name = "btnGri";
            this.btnGri.Size = new System.Drawing.Size(29, 24);
            this.btnGri.Text = "toolStripButton1";
            this.btnGri.ToolTipText = "Gri";
            this.btnGri.Click += new System.EventHandler(this.btnGri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(618, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 400);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackParlaklik
            // 
            this.trackParlaklik.Location = new System.Drawing.Point(55, 32);
            this.trackParlaklik.Maximum = 250;
            this.trackParlaklik.Name = "trackParlaklik";
            this.trackParlaklik.Size = new System.Drawing.Size(361, 56);
            this.trackParlaklik.SmallChange = 25;
            this.trackParlaklik.TabIndex = 5;
            this.trackParlaklik.Value = 100;
            this.trackParlaklik.Scroll += new System.EventHandler(this.trackParlaklik_Scroll);
            // 
            // lblParlaklik
            // 
            this.lblParlaklik.AutoSize = true;
            this.lblParlaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParlaklik.Location = new System.Drawing.Point(6, 32);
            this.lblParlaklik.Name = "lblParlaklik";
            this.lblParlaklik.Size = new System.Drawing.Size(31, 32);
            this.lblParlaklik.TabIndex = 6;
            this.lblParlaklik.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGoruntuDegistir);
            this.groupBox1.Controls.Add(this.checkBoxB);
            this.groupBox1.Controls.Add(this.checkBoxG);
            this.groupBox1.Controls.Add(this.checkBoxR);
            this.groupBox1.Location = new System.Drawing.Point(12, 569);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "a)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 68);
            this.label2.TabIndex = 12;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "R= 0 G= 0 B= 0";
            // 
            // btnGoruntuDegistir
            // 
            this.btnGoruntuDegistir.Location = new System.Drawing.Point(53, 126);
            this.btnGoruntuDegistir.Name = "btnGoruntuDegistir";
            this.btnGoruntuDegistir.Size = new System.Drawing.Size(150, 36);
            this.btnGoruntuDegistir.TabIndex = 11;
            this.btnGoruntuDegistir.Text = "Görüntü Değiştir";
            this.btnGoruntuDegistir.UseVisualStyleBackColor = true;
            this.btnGoruntuDegistir.Click += new System.EventHandler(this.btnGoruntuDegistir_Click);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(6, 162);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(39, 21);
            this.checkBoxB.TabIndex = 10;
            this.checkBoxB.Text = "B\r\n";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxG
            // 
            this.checkBoxG.AutoSize = true;
            this.checkBoxG.Location = new System.Drawing.Point(6, 135);
            this.checkBoxG.Name = "checkBoxG";
            this.checkBoxG.Size = new System.Drawing.Size(41, 21);
            this.checkBoxG.TabIndex = 9;
            this.checkBoxG.Text = "G\r\n";
            this.checkBoxG.UseVisualStyleBackColor = true;
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Location = new System.Drawing.Point(6, 108);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(40, 21);
            this.checkBoxR.TabIndex = 8;
            this.checkBoxR.Text = "R";
            this.checkBoxR.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrilestir);
            this.groupBox2.Controls.Add(this.radioButtonB);
            this.groupBox2.Controls.Add(this.radioButtonG);
            this.groupBox2.Controls.Add(this.radioButtonR);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(440, 571);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 195);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "b)";
            // 
            // btnGrilestir
            // 
            this.btnGrilestir.Location = new System.Drawing.Point(70, 99);
            this.btnGrilestir.Name = "btnGrilestir";
            this.btnGrilestir.Size = new System.Drawing.Size(128, 35);
            this.btnGrilestir.TabIndex = 17;
            this.btnGrilestir.Text = "Resmi Grileştir";
            this.btnGrilestir.UseVisualStyleBackColor = true;
            this.btnGrilestir.Click += new System.EventHandler(this.btnGrilestir_Click);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(15, 133);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(38, 21);
            this.radioButtonB.TabIndex = 16;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(15, 106);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(40, 21);
            this.radioButtonG.TabIndex = 15;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "G";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(15, 78);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(39, 21);
            this.radioButtonR.TabIndex = 14;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "R";
            this.radioButtonR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Renkli bir resmin üç kanal içinde Gri Resim görüntüsünü \r\ngösterin. Kişi hangi re" +
    "ngin çıktısını istiyorsa onu seçebilsin.\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKatsayı);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxG);
            this.groupBox3.Controls.Add(this.textBoxR);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(868, 571);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 195);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "c)";
            // 
            // btnKatsayı
            // 
            this.btnKatsayı.Location = new System.Drawing.Point(32, 144);
            this.btnKatsayı.Name = "btnKatsayı";
            this.btnKatsayı.Size = new System.Drawing.Size(370, 35);
            this.btnKatsayı.TabIndex = 21;
            this.btnKatsayı.Text = "Katsayıları Formüle Yerleştir";
            this.btnKatsayı.UseVisualStyleBackColor = true;
            this.btnKatsayı.Click += new System.EventHandler(this.btnKatsayı_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "B=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 85);
            this.label4.TabIndex = 14;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(323, 116);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(79, 22);
            this.textBoxB.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "R=";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(193, 116);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(79, 22);
            this.textBoxG.TabIndex = 19;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(61, 116);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(79, 22);
            this.textBoxR.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "G=";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(12, 772);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(422, 197);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "d)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(415, 136);
            this.label8.TabIndex = 22;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.listBox1);
            this.groupBox7.Controls.Add(this.btnCalistir);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Location = new System.Drawing.Point(440, 772);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(422, 154);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "e)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 100);
            this.listBox1.TabIndex = 15;
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(234, 74);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(182, 72);
            this.btnCalistir.TabIndex = 14;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(401, 34);
            this.label9.TabIndex = 13;
            this.label9.Text = "Histogramla Kontras Artırma yada azaltma konusunu deneyin. \r\n \r\n";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.trackParlaklik);
            this.groupBox8.Controls.Add(this.lblParlaklik);
            this.groupBox8.Location = new System.Drawing.Point(11, 439);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(422, 87);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Parlaklık";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 36);
            this.label10.TabIndex = 12;
            this.label10.Text = "ÖDEV-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackParlaklik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripButton BtnKaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBoyutAyarla;
        private System.Windows.Forms.ToolStripButton btnSagaAktar;
        private System.Windows.Forms.ToolStripButton btnNegatif;
        private System.Windows.Forms.ToolStripButton btnSolaAktar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnGri;
        private System.Windows.Forms.TrackBar trackParlaklik;
        private System.Windows.Forms.Label lblParlaklik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoruntuDegistir;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxG;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.Button btnGrilestir;
        private System.Windows.Forms.Button btnKatsayı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}

