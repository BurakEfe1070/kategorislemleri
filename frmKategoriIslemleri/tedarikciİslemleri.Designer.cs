namespace frmKategoriIslemleri
{
    partial class tedarikciİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tedarikciİslemleri));
            this.grpBilgiGirisi = new System.Windows.Forms.GroupBox();
            this.grdTedarikciler = new System.Windows.Forms.DataGridView();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtYetkiliAd = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.grpBilgiGirisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTedarikciler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBilgiGirisi
            // 
            this.grpBilgiGirisi.Controls.Add(this.grdTedarikciler);
            this.grpBilgiGirisi.Controls.Add(this.mskTelefon);
            this.grpBilgiGirisi.Controls.Add(this.txtAdres);
            this.grpBilgiGirisi.Controls.Add(this.btnGuncelle);
            this.grpBilgiGirisi.Controls.Add(this.btnSil);
            this.grpBilgiGirisi.Controls.Add(this.btnEkle);
            this.grpBilgiGirisi.Controls.Add(this.btnYeni);
            this.grpBilgiGirisi.Controls.Add(this.txtMail);
            this.grpBilgiGirisi.Controls.Add(this.txtYetkiliAd);
            this.grpBilgiGirisi.Controls.Add(this.txtFirmaAdi);
            this.grpBilgiGirisi.Controls.Add(this.label5);
            this.grpBilgiGirisi.Controls.Add(this.label4);
            this.grpBilgiGirisi.Controls.Add(this.label3);
            this.grpBilgiGirisi.Controls.Add(this.label2);
            this.grpBilgiGirisi.Controls.Add(this.label1);
            this.grpBilgiGirisi.Location = new System.Drawing.Point(12, 12);
            this.grpBilgiGirisi.Name = "grpBilgiGirisi";
            this.grpBilgiGirisi.Size = new System.Drawing.Size(776, 426);
            this.grpBilgiGirisi.TabIndex = 0;
            this.grpBilgiGirisi.TabStop = false;
            this.grpBilgiGirisi.Text = "BİLGİ GİRİŞİ";
            this.grpBilgiGirisi.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grdTedarikciler
            // 
            this.grdTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTedarikciler.Location = new System.Drawing.Point(20, 252);
            this.grdTedarikciler.Name = "grdTedarikciler";
            this.grdTedarikciler.Size = new System.Drawing.Size(736, 157);
            this.grdTedarikciler.TabIndex = 16;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(131, 89);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(100, 20);
            this.mskTelefon.TabIndex = 14;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(634, 49);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 96);
            this.txtAdres.TabIndex = 13;
            this.txtAdres.Text = "";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "148764.png");
            this.ımageList1.Images.SetKeyName(1, "images.jpg");
            this.ımageList1.Images.SetKeyName(2, "indir (1).jpg");
            this.ımageList1.Images.SetKeyName(3, "indir.jpg");
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(408, 93);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(158, 20);
            this.txtMail.TabIndex = 8;
            // 
            // txtYetkiliAd
            // 
            this.txtYetkiliAd.Location = new System.Drawing.Point(408, 43);
            this.txtYetkiliAd.Name = "txtYetkiliAd";
            this.txtYetkiliAd.Size = new System.Drawing.Size(158, 20);
            this.txtYetkiliAd.TabIndex = 6;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(122, 39);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(170, 20);
            this.txtFirmaAdi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yetkili Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.ImageKey = "images.jpg";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(628, 167);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 44);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.ImageKey = "indir (1).jpg";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(488, 167);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 44);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "indir.jpg";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(350, 167);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 44);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.ImageKey = "148764.png";
            this.btnYeni.ImageList = this.ımageList1;
            this.btnYeni.Location = new System.Drawing.Point(20, 167);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(96, 44);
            this.btnYeni.TabIndex = 9;
            this.btnYeni.Text = "Yeni Kayıt";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBilgiGirisi);
            this.Name = "Form2";
            this.Text = "Tedarikçi İşlemleri";
            this.grpBilgiGirisi.ResumeLayout(false);
            this.grpBilgiGirisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTedarikciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBilgiGirisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtYetkiliAd;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.DataGridView grdTedarikciler;
    }
}