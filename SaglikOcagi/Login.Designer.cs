namespace SaglikOcagi
{
    partial class Login
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
            this.button_Giris_Yap = new System.Windows.Forms.Button();
            this.textBox_Kullani_Adi = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Cikis_Yap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullani Adi";
            // 
            // button_Giris_Yap
            // 
            this.button_Giris_Yap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Giris_Yap.ForeColor = System.Drawing.Color.Green;
            this.button_Giris_Yap.Location = new System.Drawing.Point(12, 98);
            this.button_Giris_Yap.Name = "button_Giris_Yap";
            this.button_Giris_Yap.Size = new System.Drawing.Size(79, 44);
            this.button_Giris_Yap.TabIndex = 1;
            this.button_Giris_Yap.Text = "Giriş Yap";
            this.button_Giris_Yap.UseVisualStyleBackColor = false;
            this.button_Giris_Yap.Click += new System.EventHandler(this.button_Giris_Yap_Click);
            // 
            // textBox_Kullani_Adi
            // 
            this.textBox_Kullani_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Kullani_Adi.Location = new System.Drawing.Point(146, 16);
            this.textBox_Kullani_Adi.Name = "textBox_Kullani_Adi";
            this.textBox_Kullani_Adi.Size = new System.Drawing.Size(148, 30);
            this.textBox_Kullani_Adi.TabIndex = 2;
            this.textBox_Kullani_Adi.Text = "ergec";
            this.textBox_Kullani_Adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Kullani_Adi.TextChanged += new System.EventHandler(this.textBox_Kullani_Adi_TextChanged);
            this.textBox_Kullani_Adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Kullani_Adi_KeyDown);
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sifre.Location = new System.Drawing.Point(146, 52);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(148, 30);
            this.textBox_Sifre.TabIndex = 2;
            this.textBox_Sifre.Text = "123";
            this.textBox_Sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Sifre.TextChanged += new System.EventHandler(this.textBox_Sifre_TextChanged);
            this.textBox_Sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Sifre_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre";
            // 
            // button_Temizle
            // 
            this.button_Temizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Temizle.ForeColor = System.Drawing.Color.Yellow;
            this.button_Temizle.Location = new System.Drawing.Point(97, 98);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(67, 44);
            this.button_Temizle.TabIndex = 1;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = false;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Cikis_Yap
            // 
            this.button_Cikis_Yap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Cikis_Yap.ForeColor = System.Drawing.Color.Black;
            this.button_Cikis_Yap.Location = new System.Drawing.Point(233, 98);
            this.button_Cikis_Yap.Name = "button_Cikis_Yap";
            this.button_Cikis_Yap.Size = new System.Drawing.Size(79, 44);
            this.button_Cikis_Yap.TabIndex = 1;
            this.button_Cikis_Yap.Text = "Çıkış";
            this.button_Cikis_Yap.UseVisualStyleBackColor = false;
            this.button_Cikis_Yap.Click += new System.EventHandler(this.button_Cikis_Yap_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 164);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_Kullani_Adi);
            this.Controls.Add(this.button_Cikis_Yap);
            this.Controls.Add(this.button_Temizle);
            this.Controls.Add(this.button_Giris_Yap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 203);
            this.MinimumSize = new System.Drawing.Size(340, 203);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Giris_Yap;
        private System.Windows.Forms.TextBox textBox_Kullani_Adi;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Cikis_Yap;
    }
}