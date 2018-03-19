using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaglikOcagi
{
    public partial class poliklinik_giris : Form
    {
        public poliklinik_giris()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void poliklinik_giris_Load(object sender, EventArgs e)
        {
            poliklinikIsimOkuma();
        }

        SqlCommand cmd;
        SqlDataReader dr;
        public void poliklinikIsimOkuma()
        {
            try
            {
                cmd = new SqlCommand("SELECT poliklinikAdi From SOHTS.dbo.poliklinik", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1_PoliklinikGirisAd.Items.Add(dr["poliklinikAdi"].ToString());
                }
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

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && comboBox1_PoliklinikGirisAd.Text!="")
            {
                try
                {
                    //Kayi varsa diğer formu açar ve kayıtları doldurur.
                    string poliklinikGirisAd = comboBox1_PoliklinikGirisAd.Text;
                    bool poliklinik_ac_bool = PoliklinikVeriGirisiKayitVarMi(poliklinikGirisAd);
                    // false geri dönüş var ise veri var demektir gerisine gerek yok
                    if (poliklinik_ac_bool==false)
                        return;

                    DialogResult result = MessageBox.Show("Böyle Bir Kayit Bulunamadı, Yeni Bir Kayit Oluşturmak İster Misiniz?", "Poliklinik Bulunamadi", MessageBoxButtons.OKCancel);
                    if (result==DialogResult.Cancel)
                    {
                        comboBox1_PoliklinikGirisAd.Text="";
                        checkBox1_gecerliMi.Checked = false;
                    }
                    if (result==DialogResult.OK)
                    {
                        try
                        {
                            PoliklinikVeriAktarimi.poliklinikAd = comboBox1_PoliklinikGirisAd.Text;
                            cmd = new SqlCommand("INSERT INTO SOHTS.dbo.poliklinik (poliklinikAdi) VALUES(@PoliklinikAd)", SQLBaglanti.SqlBaglan());

                            cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                            cmd.Parameters["@PoliklinikAd"].Value = PoliklinikVeriAktarimi.poliklinikAd;

                            SQLBaglanti.SqlBaglan().Open();
                            cmd.ExecuteNonQuery();

                            poliklinik p = new poliklinik();
                            p.MdiParent = Program.owner;
                            p.Show();
                            this.Close();
                        }
                        catch(Exception E)
                        {
                            MessageBox.Show("Hata : ",E.ToString());
                        }
                        finally
                        {
                            SQLBaglanti.SqlBaglan().Close();
                        }
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("Hata : "+E.ToString());
                }
            }
            
        }

        public bool PoliklinikVeriGirisiKayitVarMi(string poliklinikAd)
        {
            try
            {
                cmd = new SqlCommand("SELECT * From SOHTS.dbo.poliklinik WHERE poliklinikAdi = @PoliklinikAd", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                cmd.Parameters["@PoliklinikAd"].Value = poliklinikAd;
                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PoliklinikVeriAktarimi.gecerliMi = dr["durum"].ToString();
                    PoliklinikVeriAktarimi.poliklinikAciklama = dr["aciklama"].ToString();
                    PoliklinikVeriAktarimi.poliklinikAd = dr["poliklinikAdi"].ToString();
                    if (PoliklinikVeriAktarimi.poliklinikAd!="" || PoliklinikVeriAktarimi.gecerliMi != "" || PoliklinikVeriAktarimi.poliklinikAciklama != "")
                    {
                        poliklinik p = new poliklinik();
                        p.MdiParent = Program.owner;
                        p.Show();
                        this.Close();
                        return false;
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
            return true;
        }

        private void poliklinik_giris_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
