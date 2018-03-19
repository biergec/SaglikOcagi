using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaglikOcagi
{
    public partial class TaburcuEkrani : Form
    {
        public TaburcuEkrani()
        {
            InitializeComponent();
        }

        private void button3_Vazgec_Click(object sender, EventArgs e)
        {
            HastaTaburcuEkraniVeri.dosyaNo = "";
            HastaTaburcuEkraniVeri.cikis_tarihi=null;
            HastaTaburcuEkraniVeri.odeme_sekli = "";
            HastaTaburcuEkraniVeri.sevk_tarih =null;
            HastaTaburcuEkraniVeri.toplam_tutar = "";
            this.Close();
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {   
                if (textBox1_DosyaNo.Text != "" && comboBox1_sevkTarihi.Text != "" && comboBox2_cikisTarihi.Text != "" && comboBox3_OdemeSekli.Text != "")
                {
                    if (comboBox4_ToplamTutar.Text == "")
                    {
                        DialogResult result = MessageBox.Show("Toplam Tutar Bulunamadı. Hastayı Yinede Taburcu Etmek İstiyor Musunuz? ( 0 TL Baz Alınacaktır ) ", "Fiyat Uyarısı", MessageBoxButtons.YesNo);
                        if (result==DialogResult.Yes)
                        {
                            comboBox4_ToplamTutar.Text = "0";
                            cikisIslemiDBKayit();
                        }
                    }
                    else
                        cikisIslemiDBKayit();
                    // aynı zamanda Sevk tablosundaki taburcu kısmı evet olarak doldurulur.
                }
                else
                {
                    MessageBox.Show("Tüm Alanlar Dolu Olmalıdır.");
                    return;
                }
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        SqlCommand cmd;
        private void cikisIslemiDBKayit()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = SQLBaglanti.SqlBaglan();
                SQLBaglanti.SqlBaglan().Open();

                cmd.CommandText = "hasta_cikis_veri_kayit";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dosya_no", SqlDbType.Int);
                cmd.Parameters["@dosya_no"].Value = Convert.ToInt32(textBox1_DosyaNo.Text.Trim());

                DateTime sevkTarihx = Convert.ToDateTime(comboBox1_sevkTarihi.Text.Trim());
                string x = String.Format("{0:yyyy/MM/dd}", sevkTarihx);

                cmd.Parameters.Add("@sevk_tarih", SqlDbType.DateTime);
                cmd.Parameters["@sevk_tarih"].Value =Convert.ToDateTime(x);

                cmd.Parameters.Add("@cikis_tarihi", SqlDbType.DateTime);
                cmd.Parameters["@cikis_tarihi"].Value = Convert.ToDateTime(comboBox2_cikisTarihi.Text.Trim());

                cmd.Parameters.Add("@odeme_sekli", SqlDbType.VarChar);
                cmd.Parameters["@odeme_sekli"].Value = comboBox3_OdemeSekli.Text.Trim();

                cmd.Parameters.Add("@toplam_tutar", SqlDbType.VarChar);
                cmd.Parameters["@toplam_tutar"].Value = comboBox4_ToplamTutar.Text.Trim();

                cmd.Parameters.Add("@taburcu", SqlDbType.VarChar);
                cmd.Parameters["@taburcu"].Value = "Evet";

                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }

        private void TaburcuEkrani_Load(object sender, EventArgs e)
        {
            VerileriDoldur();
        }

        private void VerileriDoldur()
        {
            textBox1_DosyaNo.Text = HastaTaburcuEkraniVeri.dosyaNo;
            comboBox1_sevkTarihi.Text = HastaTaburcuEkraniVeri.sevk_tarih.ToString();
            comboBox2_cikisTarihi.Text = HastaTaburcuEkraniVeri.cikis_tarihi.ToString();
            comboBox4_ToplamTutar.Text = HastaTaburcuEkraniVeri.toplam_tutar;

            string[] odeme_sekilleri = { "Nakit", "Kredi Kartı Peşin","Kredi Kartı Taksitli", "Senet", "Çek" };
            foreach (string item in odeme_sekilleri)
            {
                comboBox3_OdemeSekli.Items.Add(item);
            }
        }
    }
}
