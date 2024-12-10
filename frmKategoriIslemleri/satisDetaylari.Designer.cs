namespace frmKategoriIslemleri
{
    partial class frmSatisDetayları
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
            this.label1 = new System.Windows.Forms.Label();
            this.grdSatisListesi = new System.Windows.Forms.DataGridView();
            this.grbSatisDetayları = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.btnSatisIptalEt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisToplamFiyatı = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatisListesi)).BeginInit();
            this.grbSatisDetayları.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATIŞ LİSTESİ";
            // 
            // grdSatisListesi
            // 
            this.grdSatisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatisListesi.Location = new System.Drawing.Point(16, 64);
            this.grdSatisListesi.Name = "grdSatisListesi";
            this.grdSatisListesi.Size = new System.Drawing.Size(453, 374);
            this.grdSatisListesi.TabIndex = 1;
            // 
            // grbSatisDetayları
            // 
            this.grbSatisDetayları.Controls.Add(this.txtSatisToplamFiyatı);
            this.grbSatisDetayları.Controls.Add(this.label3);
            this.grbSatisDetayları.Controls.Add(this.btnSatisIptalEt);
            this.grbSatisDetayları.Controls.Add(this.grdSatilanUrunler);
            this.grbSatisDetayları.Controls.Add(this.label2);
            this.grbSatisDetayları.Location = new System.Drawing.Point(492, 64);
            this.grbSatisDetayları.Name = "grbSatisDetayları";
            this.grbSatisDetayları.Size = new System.Drawing.Size(374, 374);
            this.grbSatisDetayları.TabIndex = 2;
            this.grbSatisDetayları.TabStop = false;
            this.grbSatisDetayları.Text = "Satış Detayları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SATILAN ÜRNLER";
            // 
            // grdSatilanUrunler
            // 
            this.grdSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilanUrunler.Location = new System.Drawing.Point(15, 90);
            this.grdSatilanUrunler.Name = "grdSatilanUrunler";
            this.grdSatilanUrunler.Size = new System.Drawing.Size(353, 150);
            this.grdSatilanUrunler.TabIndex = 1;
            // 
            // btnSatisIptalEt
            // 
            this.btnSatisIptalEt.Location = new System.Drawing.Point(33, 305);
            this.btnSatisIptalEt.Name = "btnSatisIptalEt";
            this.btnSatisIptalEt.Size = new System.Drawing.Size(92, 37);
            this.btnSatisIptalEt.TabIndex = 2;
            this.btnSatisIptalEt.Text = "Satış İptal Et";
            this.btnSatisIptalEt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Satış Toplam Fiyatı";
            // 
            // txtSatisToplamFiyatı
            // 
            this.txtSatisToplamFiyatı.Location = new System.Drawing.Point(268, 314);
            this.txtSatisToplamFiyatı.Name = "txtSatisToplamFiyatı";
            this.txtSatisToplamFiyatı.Size = new System.Drawing.Size(100, 20);
            this.txtSatisToplamFiyatı.TabIndex = 4;
            // 
            // frmSatisDetayları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.grbSatisDetayları);
            this.Controls.Add(this.grdSatisListesi);
            this.Controls.Add(this.label1);
            this.Name = "frmSatisDetayları";
            this.Text = "frmSatisDetayları";
            ((System.ComponentModel.ISupportInitialize)(this.grdSatisListesi)).EndInit();
            this.grbSatisDetayları.ResumeLayout(false);
            this.grbSatisDetayları.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSatisListesi;
        private System.Windows.Forms.GroupBox grbSatisDetayları;
        private System.Windows.Forms.DataGridView grdSatilanUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatisToplamFiyatı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSatisIptalEt;
    }
}