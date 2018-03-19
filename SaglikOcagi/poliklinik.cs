using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikOcagi
{

    public partial class poliklinik : Form
    {
        SqlCommand cmd;

        public poliklinik()
        {
            InitializeComponent();
        }

        private void poliklinik_Load(object sender, EventArgs e)
        {
            GelenVerileriYukle();
        }

        private void GelenVerileriYukle()
        {
            if (PoliklinikVeriAktarimi.poliklinikAd != "" || PoliklinikVeriAktarimi.gecerliMi != "" || PoliklinikVeriAktarimi.poliklinikAciklama != "")
            {
                textBox1_poliklinikPoliklinikAd.Text = PoliklinikVeriAktarimi.poliklinikAd;
                if (PoliklinikVeriAktarimi.gecerliMi == "true")
                {
                    checkBox_poliklinikGecerliMi.Checked = false;
                }
                else
                    checkBox_poliklinikGecerliMi.Checked = true;

                textBox_PoliklinikAciklama.Text = PoliklinikVeriAktarimi.poliklinikAciklama;
            }
            PoliklinikVeriAktarimi.gecerliMi = "";
            PoliklinikVeriAktarimi.poliklinikAciklama = "";
            PoliklinikVeriAktarimi.poliklinikAd = "";
        }


        public void PoliklinikSecmeEkraniDon()
        {
            poliklinik_giris p = new poliklinik_giris();
            p.MdiParent = Program.owner;
            p.Show();
            this.Close();
        }

        private void PoliklinikSil()
        {
            try
            {
                cmd = new SqlCommand("poliklinik_sil", SQLBaglanti.SqlBaglan());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                cmd.Parameters["@PoliklinikAd"].Value = textBox1_poliklinikPoliklinikAd.Text;

                SQLBaglanti.SqlBaglan().Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme Başarılı");
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
                PoliklinikSecmeEkraniDon();
            }
        }

        private void PoliklinikUpdate()
        {
            try
            {
                bool checkboxKontrol = true;
                if (checkBox_poliklinikGecerliMi.Checked == true)
                {
                    checkboxKontrol = false;
                }

                cmd = new SqlCommand("poliklinik_update", SQLBaglanti.SqlBaglan());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Aciklama", SqlDbType.VarChar);
                cmd.Parameters.Add("@Durum", SqlDbType.VarChar);
                cmd.Parameters.Add("@Poliklinik", SqlDbType.VarChar);
                cmd.Parameters["@Aciklama"].Value = textBox_PoliklinikAciklama.Text;
                cmd.Parameters["@Durum"].Value = checkboxKontrol;
                cmd.Parameters["@Poliklinik"].Value = textBox1_poliklinikPoliklinikAd.Text;

                SQLBaglanti.SqlBaglan().Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Başarılı");
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }

        private void button_PoliklinikCikisYap_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_PoliklinikSil_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Poliklinik Silme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PoliklinikSil();
            }
        }

        private void button1_PoliklinikGuncelle_Click_1(object sender, EventArgs e)
        {
            PoliklinikUpdate();
        }
    }
}
