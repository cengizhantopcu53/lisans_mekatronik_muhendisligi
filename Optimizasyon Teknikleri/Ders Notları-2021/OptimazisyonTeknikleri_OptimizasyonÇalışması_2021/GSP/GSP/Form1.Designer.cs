namespace GSP
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIterasyon = new System.Windows.Forms.TextBox();
            this.txtMut = new System.Windows.Forms.TextBox();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtq0 = new System.Windows.Forms.TextBox();
            this.txtFeromon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRho = new System.Windows.Forms.TextBox();
            this.txtBeta = new System.Windows.Forms.TextBox();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.txtKarincaSayisi = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(257, 261);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(118, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "En Kısa Yol";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIterasyon);
            this.groupBox1.Controls.Add(this.txtMut);
            this.groupBox1.Controls.Add(this.txtCap);
            this.groupBox1.Controls.Add(this.txtPop);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GA Parametreleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "İterasyon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mutasyon Oranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Çaprazlama Oranı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pop. Sayısı";
            // 
            // txtIterasyon
            // 
            this.txtIterasyon.Location = new System.Drawing.Point(109, 107);
            this.txtIterasyon.Name = "txtIterasyon";
            this.txtIterasyon.Size = new System.Drawing.Size(52, 20);
            this.txtIterasyon.TabIndex = 3;
            this.txtIterasyon.Text = "1000";
            // 
            // txtMut
            // 
            this.txtMut.Location = new System.Drawing.Point(109, 80);
            this.txtMut.Name = "txtMut";
            this.txtMut.Size = new System.Drawing.Size(52, 20);
            this.txtMut.TabIndex = 2;
            this.txtMut.Text = "20";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(109, 56);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(52, 20);
            this.txtCap.TabIndex = 1;
            this.txtCap.Text = "80";
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(109, 29);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(52, 20);
            this.txtPop.TabIndex = 0;
            this.txtPop.Text = "5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtq0);
            this.groupBox2.Controls.Add(this.txtFeromon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRho);
            this.groupBox2.Controls.Add(this.txtBeta);
            this.groupBox2.Controls.Add(this.txtAlfa);
            this.groupBox2.Controls.Add(this.txtKarincaSayisi);
            this.groupBox2.Location = new System.Drawing.Point(219, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KKS Parametreleri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "q0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "τ";
            // 
            // txtq0
            // 
            this.txtq0.Location = new System.Drawing.Point(119, 77);
            this.txtq0.Name = "txtq0";
            this.txtq0.Size = new System.Drawing.Size(36, 20);
            this.txtq0.TabIndex = 9;
            this.txtq0.Text = "0,9";
            // 
            // txtFeromon
            // 
            this.txtFeromon.Location = new System.Drawing.Point(119, 53);
            this.txtFeromon.Name = "txtFeromon";
            this.txtFeromon.Size = new System.Drawing.Size(36, 20);
            this.txtFeromon.TabIndex = 8;
            this.txtFeromon.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ρ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "β";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "α";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "m";
            // 
            // txtRho
            // 
            this.txtRho.Location = new System.Drawing.Point(119, 26);
            this.txtRho.Name = "txtRho";
            this.txtRho.Size = new System.Drawing.Size(36, 20);
            this.txtRho.TabIndex = 3;
            this.txtRho.Text = "0,1";
            // 
            // txtBeta
            // 
            this.txtBeta.Location = new System.Drawing.Point(32, 80);
            this.txtBeta.Name = "txtBeta";
            this.txtBeta.Size = new System.Drawing.Size(36, 20);
            this.txtBeta.TabIndex = 2;
            this.txtBeta.Text = "5";
            // 
            // txtAlfa
            // 
            this.txtAlfa.Location = new System.Drawing.Point(32, 56);
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(36, 20);
            this.txtAlfa.TabIndex = 1;
            this.txtAlfa.Text = "1";
            // 
            // txtKarincaSayisi
            // 
            this.txtKarincaSayisi.Location = new System.Drawing.Point(32, 29);
            this.txtKarincaSayisi.Name = "txtKarincaSayisi";
            this.txtKarincaSayisi.Size = new System.Drawing.Size(36, 20);
            this.txtKarincaSayisi.TabIndex = 0;
            this.txtKarincaSayisi.Text = "5";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Genetik Algoritma";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(219, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Karınca Koloni Sistemi";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 316);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIterasyon;
        private System.Windows.Forms.TextBox txtMut;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtq0;
        private System.Windows.Forms.TextBox txtFeromon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRho;
        private System.Windows.Forms.TextBox txtBeta;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.TextBox txtKarincaSayisi;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

