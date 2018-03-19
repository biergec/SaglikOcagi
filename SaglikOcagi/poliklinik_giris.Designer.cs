namespace SaglikOcagi
{
    partial class poliklinik_giris
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
            this.checkBox1_gecerliMi = new System.Windows.Forms.CheckBox();
            this.comboBox1_PoliklinikGirisAd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1_gecerliMi
            // 
            this.checkBox1_gecerliMi.AutoSize = true;
            this.checkBox1_gecerliMi.Location = new System.Drawing.Point(125, 76);
            this.checkBox1_gecerliMi.Name = "checkBox1_gecerliMi";
            this.checkBox1_gecerliMi.Size = new System.Drawing.Size(111, 17);
            this.checkBox1_gecerliMi.TabIndex = 0;
            this.checkBox1_gecerliMi.Text = "Geçerli / Geçersiz";
            this.checkBox1_gecerliMi.UseVisualStyleBackColor = true;
            // 
            // comboBox1_PoliklinikGirisAd
            // 
            this.comboBox1_PoliklinikGirisAd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox1_PoliklinikGirisAd.FormattingEnabled = true;
            this.comboBox1_PoliklinikGirisAd.Location = new System.Drawing.Point(125, 34);
            this.comboBox1_PoliklinikGirisAd.Name = "comboBox1_PoliklinikGirisAd";
            this.comboBox1_PoliklinikGirisAd.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_PoliklinikGirisAd.TabIndex = 1;
            this.comboBox1_PoliklinikGirisAd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1_PoliklinikGirisAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Poliklinik Adı";
            // 
            // poliklinik_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 114);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_PoliklinikGirisAd);
            this.Controls.Add(this.checkBox1_gecerliMi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(297, 153);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(297, 153);
            this.Name = "poliklinik_giris";
            this.ShowIcon = false;
            this.Text = "Poliklinik Tanıtma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.poliklinik_giris_FormClosing);
            this.Load += new System.EventHandler(this.poliklinik_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1_gecerliMi;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1_PoliklinikGirisAd;
    }
}