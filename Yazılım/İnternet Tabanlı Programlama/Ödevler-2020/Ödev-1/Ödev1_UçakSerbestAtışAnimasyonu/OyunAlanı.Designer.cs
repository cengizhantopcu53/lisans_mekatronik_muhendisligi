namespace Ödev1_UçakSerbestAtışAnimasyonu
{
    partial class OyunAlanı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunAlanı));
            this.PctUcak = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblSayac = new System.Windows.Forms.Label();
            this.LblX_Ucak = new System.Windows.Forms.Label();
            this.LblY_Ucak = new System.Windows.Forms.Label();
            this.PctRoket = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAtes = new System.Windows.Forms.Button();
            this.PctHedef = new System.Windows.Forms.PictureBox();
            this.PctAtes = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblY_Roket = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblX_Roket = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblX_Hedef = new System.Windows.Forms.Label();
            this.LblY_Hedef = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.PctFail = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Lbl_L = new System.Windows.Forms.Label();
            this.Lbl_H = new System.Windows.Forms.Label();
            this.Lbl_R = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctUcak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRoket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctHedef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAtes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctFail)).BeginInit();
            this.SuspendLayout();
            // 
            // PctUcak
            // 
            this.PctUcak.BackColor = System.Drawing.Color.SkyBlue;
            this.PctUcak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PctUcak.Image = ((System.Drawing.Image)(resources.GetObject("PctUcak.Image")));
            this.PctUcak.Location = new System.Drawing.Point(0, 0);
            this.PctUcak.Name = "PctUcak";
            this.PctUcak.Size = new System.Drawing.Size(180, 100);
            this.PctUcak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctUcak.TabIndex = 1;
            this.PctUcak.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            // 
            // LblSayac
            // 
            this.LblSayac.AutoSize = true;
            this.LblSayac.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSayac.Location = new System.Drawing.Point(83, 422);
            this.LblSayac.Name = "LblSayac";
            this.LblSayac.Size = new System.Drawing.Size(20, 24);
            this.LblSayac.TabIndex = 2;
            this.LblSayac.Text = "0";
            // 
            // LblX_Ucak
            // 
            this.LblX_Ucak.AutoSize = true;
            this.LblX_Ucak.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblX_Ucak.Location = new System.Drawing.Point(44, 496);
            this.LblX_Ucak.Name = "LblX_Ucak";
            this.LblX_Ucak.Size = new System.Drawing.Size(20, 24);
            this.LblX_Ucak.TabIndex = 3;
            this.LblX_Ucak.Text = "0";
            // 
            // LblY_Ucak
            // 
            this.LblY_Ucak.AutoSize = true;
            this.LblY_Ucak.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblY_Ucak.Location = new System.Drawing.Point(44, 531);
            this.LblY_Ucak.Name = "LblY_Ucak";
            this.LblY_Ucak.Size = new System.Drawing.Size(20, 24);
            this.LblY_Ucak.TabIndex = 4;
            this.LblY_Ucak.Text = "0";
            // 
            // PctRoket
            // 
            this.PctRoket.Image = ((System.Drawing.Image)(resources.GetObject("PctRoket.Image")));
            this.PctRoket.Location = new System.Drawing.Point(90, 50);
            this.PctRoket.Name = "PctRoket";
            this.PctRoket.Size = new System.Drawing.Size(90, 50);
            this.PctRoket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctRoket.TabIndex = 5;
            this.PctRoket.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sayac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "X:";
            // 
            // BtnAtes
            // 
            this.BtnAtes.Location = new System.Drawing.Point(60, 573);
            this.BtnAtes.Name = "BtnAtes";
            this.BtnAtes.Size = new System.Drawing.Size(166, 90);
            this.BtnAtes.TabIndex = 9;
            this.BtnAtes.Text = "ATEŞ";
            this.BtnAtes.UseVisualStyleBackColor = true;
            this.BtnAtes.Click += new System.EventHandler(this.BtnAtes_Click);
            // 
            // PctHedef
            // 
            this.PctHedef.Image = ((System.Drawing.Image)(resources.GetObject("PctHedef.Image")));
            this.PctHedef.Location = new System.Drawing.Point(1000, 475);
            this.PctHedef.Name = "PctHedef";
            this.PctHedef.Size = new System.Drawing.Size(120, 90);
            this.PctHedef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctHedef.TabIndex = 10;
            this.PctHedef.TabStop = false;
            // 
            // PctAtes
            // 
            this.PctAtes.Image = ((System.Drawing.Image)(resources.GetObject("PctAtes.Image")));
            this.PctAtes.Location = new System.Drawing.Point(1073, 573);
            this.PctAtes.Name = "PctAtes";
            this.PctAtes.Size = new System.Drawing.Size(120, 90);
            this.PctAtes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAtes.TabIndex = 11;
            this.PctAtes.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Uçak";
            // 
            // LblY_Roket
            // 
            this.LblY_Roket.AutoSize = true;
            this.LblY_Roket.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblY_Roket.Location = new System.Drawing.Point(115, 531);
            this.LblY_Roket.Name = "LblY_Roket";
            this.LblY_Roket.Size = new System.Drawing.Size(20, 24);
            this.LblY_Roket.TabIndex = 13;
            this.LblY_Roket.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(83, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(82, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "X:";
            // 
            // LblX_Roket
            // 
            this.LblX_Roket.AutoSize = true;
            this.LblX_Roket.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblX_Roket.Location = new System.Drawing.Point(115, 496);
            this.LblX_Roket.Name = "LblX_Roket";
            this.LblX_Roket.Size = new System.Drawing.Size(20, 24);
            this.LblX_Roket.TabIndex = 16;
            this.LblX_Roket.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(83, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Roket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(166, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hedef";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(166, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(165, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Y:";
            // 
            // LblX_Hedef
            // 
            this.LblX_Hedef.AutoSize = true;
            this.LblX_Hedef.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblX_Hedef.Location = new System.Drawing.Point(199, 496);
            this.LblX_Hedef.Name = "LblX_Hedef";
            this.LblX_Hedef.Size = new System.Drawing.Size(20, 24);
            this.LblX_Hedef.TabIndex = 22;
            this.LblX_Hedef.Text = "0";
            // 
            // LblY_Hedef
            // 
            this.LblY_Hedef.AutoSize = true;
            this.LblY_Hedef.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblY_Hedef.Location = new System.Drawing.Point(197, 531);
            this.LblY_Hedef.Name = "LblY_Hedef";
            this.LblY_Hedef.Size = new System.Drawing.Size(20, 24);
            this.LblY_Hedef.TabIndex = 21;
            this.LblY_Hedef.Text = "0";
            // 
            // timer3
            // 
            this.timer3.Interval = 150;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 150;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 150;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // PctFail
            // 
            this.PctFail.Image = ((System.Drawing.Image)(resources.GetObject("PctFail.Image")));
            this.PctFail.Location = new System.Drawing.Point(947, 573);
            this.PctFail.Name = "PctFail";
            this.PctFail.Size = new System.Drawing.Size(120, 90);
            this.PctFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFail.TabIndex = 25;
            this.PctFail.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(249, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "L:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(246, 528);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "R:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(246, 497);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "H:";
            // 
            // Lbl_L
            // 
            this.Lbl_L.AutoSize = true;
            this.Lbl_L.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_L.Location = new System.Drawing.Point(279, 462);
            this.Lbl_L.Name = "Lbl_L";
            this.Lbl_L.Size = new System.Drawing.Size(20, 24);
            this.Lbl_L.TabIndex = 29;
            this.Lbl_L.Text = "0";
            // 
            // Lbl_H
            // 
            this.Lbl_H.AutoSize = true;
            this.Lbl_H.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_H.Location = new System.Drawing.Point(280, 497);
            this.Lbl_H.Name = "Lbl_H";
            this.Lbl_H.Size = new System.Drawing.Size(20, 24);
            this.Lbl_H.TabIndex = 30;
            this.Lbl_H.Text = "0";
            // 
            // Lbl_R
            // 
            this.Lbl_R.AutoSize = true;
            this.Lbl_R.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_R.Location = new System.Drawing.Point(279, 528);
            this.Lbl_R.Name = "Lbl_R";
            this.Lbl_R.Size = new System.Drawing.Size(20, 24);
            this.Lbl_R.TabIndex = 31;
            this.Lbl_R.Text = "0";
            // 
            // OyunAlanı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 675);
            this.Controls.Add(this.Lbl_R);
            this.Controls.Add(this.Lbl_H);
            this.Controls.Add(this.Lbl_L);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PctFail);
            this.Controls.Add(this.LblX_Hedef);
            this.Controls.Add(this.LblY_Hedef);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblX_Roket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblY_Roket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PctAtes);
            this.Controls.Add(this.PctHedef);
            this.Controls.Add(this.BtnAtes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctRoket);
            this.Controls.Add(this.LblY_Ucak);
            this.Controls.Add(this.LblX_Ucak);
            this.Controls.Add(this.LblSayac);
            this.Controls.Add(this.PctUcak);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "OyunAlanı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Alanı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctUcak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRoket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctHedef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAtes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctFail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PctUcak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblSayac;
        private System.Windows.Forms.Label LblX_Ucak;
        private System.Windows.Forms.Label LblY_Ucak;
        private System.Windows.Forms.PictureBox PctRoket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAtes;
        private System.Windows.Forms.PictureBox PctHedef;
        private System.Windows.Forms.PictureBox PctAtes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblY_Roket;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblX_Roket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblX_Hedef;
        private System.Windows.Forms.Label LblY_Hedef;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.PictureBox PctFail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Lbl_L;
        private System.Windows.Forms.Label Lbl_H;
        private System.Windows.Forms.Label Lbl_R;
    }
}

