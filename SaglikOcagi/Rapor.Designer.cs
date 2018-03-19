namespace SaglikOcagi
{
    partial class Rapor
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
            this.button1_Sorgula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_baslangic = new System.Windows.Forms.ComboBox();
            this.dataGridView1_rapor = new System.Windows.Forms.DataGridView();
            this.radioButton1_taburcuOlmus = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2_bitis = new System.Windows.Forms.ComboBox();
            this.radioButton2_TaburcuOlmamıs = new System.Windows.Forms.RadioButton();
            this.radioButton3_hepsi = new System.Windows.Forms.RadioButton();
            this.button2_temizle = new System.Windows.Forms.Button();
            this.button3_Yazdir = new System.Windows.Forms.Button();
            this.button4_Kapat = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_rapor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Sorgula
            // 
            this.button1_Sorgula.Location = new System.Drawing.Point(434, 12);
            this.button1_Sorgula.Name = "button1_Sorgula";
            this.button1_Sorgula.Size = new System.Drawing.Size(67, 63);
            this.button1_Sorgula.TabIndex = 0;
            this.button1_Sorgula.Text = "Sorgula";
            this.button1_Sorgula.UseVisualStyleBackColor = true;
            this.button1_Sorgula.Click += new System.EventHandler(this.button1_Sorgula_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1_baslangic
            // 
            this.comboBox1_baslangic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_baslangic.DropDownWidth = 100;
            this.comboBox1_baslangic.FormattingEnabled = true;
            this.comboBox1_baslangic.Location = new System.Drawing.Point(139, 12);
            this.comboBox1_baslangic.Name = "comboBox1_baslangic";
            this.comboBox1_baslangic.Size = new System.Drawing.Size(165, 21);
            this.comboBox1_baslangic.TabIndex = 2;
            // 
            // dataGridView1_rapor
            // 
            this.dataGridView1_rapor.AllowUserToAddRows = false;
            this.dataGridView1_rapor.AllowUserToDeleteRows = false;
            this.dataGridView1_rapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_rapor.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1_rapor.Name = "dataGridView1_rapor";
            this.dataGridView1_rapor.ReadOnly = true;
            this.dataGridView1_rapor.Size = new System.Drawing.Size(812, 367);
            this.dataGridView1_rapor.TabIndex = 3;
            // 
            // radioButton1_taburcuOlmus
            // 
            this.radioButton1_taburcuOlmus.AutoSize = true;
            this.radioButton1_taburcuOlmus.Location = new System.Drawing.Point(321, 12);
            this.radioButton1_taburcuOlmus.Name = "radioButton1_taburcuOlmus";
            this.radioButton1_taburcuOlmus.Size = new System.Drawing.Size(97, 17);
            this.radioButton1_taburcuOlmus.TabIndex = 4;
            this.radioButton1_taburcuOlmus.Text = "Taburcu Olmuş";
            this.radioButton1_taburcuOlmus.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox2_bitis
            // 
            this.comboBox2_bitis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2_bitis.DropDownWidth = 100;
            this.comboBox2_bitis.FormattingEnabled = true;
            this.comboBox2_bitis.Location = new System.Drawing.Point(139, 54);
            this.comboBox2_bitis.Name = "comboBox2_bitis";
            this.comboBox2_bitis.Size = new System.Drawing.Size(165, 21);
            this.comboBox2_bitis.TabIndex = 2;
            // 
            // radioButton2_TaburcuOlmamıs
            // 
            this.radioButton2_TaburcuOlmamıs.AutoSize = true;
            this.radioButton2_TaburcuOlmamıs.Location = new System.Drawing.Point(321, 35);
            this.radioButton2_TaburcuOlmamıs.Name = "radioButton2_TaburcuOlmamıs";
            this.radioButton2_TaburcuOlmamıs.Size = new System.Drawing.Size(107, 17);
            this.radioButton2_TaburcuOlmamıs.TabIndex = 4;
            this.radioButton2_TaburcuOlmamıs.Text = "Taburcu Olmamış";
            this.radioButton2_TaburcuOlmamıs.UseVisualStyleBackColor = true;
            // 
            // radioButton3_hepsi
            // 
            this.radioButton3_hepsi.AutoSize = true;
            this.radioButton3_hepsi.Checked = true;
            this.radioButton3_hepsi.Location = new System.Drawing.Point(321, 58);
            this.radioButton3_hepsi.Name = "radioButton3_hepsi";
            this.radioButton3_hepsi.Size = new System.Drawing.Size(52, 17);
            this.radioButton3_hepsi.TabIndex = 4;
            this.radioButton3_hepsi.TabStop = true;
            this.radioButton3_hepsi.Text = "Hepsi";
            this.radioButton3_hepsi.UseVisualStyleBackColor = true;
            // 
            // button2_temizle
            // 
            this.button2_temizle.Location = new System.Drawing.Point(507, 12);
            this.button2_temizle.Name = "button2_temizle";
            this.button2_temizle.Size = new System.Drawing.Size(67, 63);
            this.button2_temizle.TabIndex = 0;
            this.button2_temizle.Text = "Temizle";
            this.button2_temizle.UseVisualStyleBackColor = true;
            this.button2_temizle.Click += new System.EventHandler(this.button2_temizle_Click);
            // 
            // button3_Yazdir
            // 
            this.button3_Yazdir.Location = new System.Drawing.Point(580, 12);
            this.button3_Yazdir.Name = "button3_Yazdir";
            this.button3_Yazdir.Size = new System.Drawing.Size(67, 63);
            this.button3_Yazdir.TabIndex = 0;
            this.button3_Yazdir.Text = "Yazdır";
            this.button3_Yazdir.UseVisualStyleBackColor = true;
            this.button3_Yazdir.Click += new System.EventHandler(this.button3_Yazdir_Click);
            // 
            // button4_Kapat
            // 
            this.button4_Kapat.Location = new System.Drawing.Point(757, 10);
            this.button4_Kapat.Name = "button4_Kapat";
            this.button4_Kapat.Size = new System.Drawing.Size(67, 63);
            this.button4_Kapat.TabIndex = 0;
            this.button4_Kapat.Text = "Kapat";
            this.button4_Kapat.UseVisualStyleBackColor = true;
            this.button4_Kapat.Click += new System.EventHandler(this.button4_Kapat_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 470);
            this.Controls.Add(this.radioButton3_hepsi);
            this.Controls.Add(this.radioButton2_TaburcuOlmamıs);
            this.Controls.Add(this.radioButton1_taburcuOlmus);
            this.Controls.Add(this.dataGridView1_rapor);
            this.Controls.Add(this.comboBox2_bitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1_baslangic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4_Kapat);
            this.Controls.Add(this.button3_Yazdir);
            this.Controls.Add(this.button2_temizle);
            this.Controls.Add(this.button1_Sorgula);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(854, 509);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(854, 509);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_rapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Sorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_baslangic;
        private System.Windows.Forms.DataGridView dataGridView1_rapor;
        private System.Windows.Forms.RadioButton radioButton1_taburcuOlmus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2_bitis;
        private System.Windows.Forms.RadioButton radioButton2_TaburcuOlmamıs;
        private System.Windows.Forms.RadioButton radioButton3_hepsi;
        private System.Windows.Forms.Button button2_temizle;
        private System.Windows.Forms.Button button3_Yazdir;
        private System.Windows.Forms.Button button4_Kapat;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}