namespace SaglikOcagi
{
    partial class kullanici_tanitma
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
            this.button1_YeniKullaniciEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_KullanicilarEkranaBas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1_YeniKullaniciEkle
            // 
            this.button1_YeniKullaniciEkle.Location = new System.Drawing.Point(16, 35);
            this.button1_YeniKullaniciEkle.Name = "button1_YeniKullaniciEkle";
            this.button1_YeniKullaniciEkle.Size = new System.Drawing.Size(230, 36);
            this.button1_YeniKullaniciEkle.TabIndex = 1;
            this.button1_YeniKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.button1_YeniKullaniciEkle.UseVisualStyleBackColor = true;
            this.button1_YeniKullaniciEkle.Click += new System.EventHandler(this.button1_YeniKullaniciEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // comboBox1_KullanicilarEkranaBas
            // 
            this.comboBox1_KullanicilarEkranaBas.FormattingEnabled = true;
            this.comboBox1_KullanicilarEkranaBas.Location = new System.Drawing.Point(125, 8);
            this.comboBox1_KullanicilarEkranaBas.MaximumSize = new System.Drawing.Size(121, 0);
            this.comboBox1_KullanicilarEkranaBas.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBox1_KullanicilarEkranaBas.Name = "comboBox1_KullanicilarEkranaBas";
            this.comboBox1_KullanicilarEkranaBas.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_KullanicilarEkranaBas.TabIndex = 3;
            this.comboBox1_KullanicilarEkranaBas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kullanici_tanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 83);
            this.Controls.Add(this.comboBox1_KullanicilarEkranaBas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_YeniKullaniciEkle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(277, 122);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(277, 122);
            this.Name = "kullanici_tanitma";
            this.ShowIcon = false;
            this.Text = "Kullanıcı Ekleme/ Düzenleme Ekranı";
            this.Load += new System.EventHandler(this.kullanici_tanitma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_YeniKullaniciEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_KullanicilarEkranaBas;
    }
}