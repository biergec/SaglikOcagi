using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikOcagi
{
    public partial class kullanici_tanitma : Form
    {
        public kullanici_tanitma()
        {
            InitializeComponent();
        }

        private void kullanici_tanitma_Load(object sender, EventArgs e)
        {
            KayitliKullaniciEkranaBas();

        }

        SqlCommand cmd;
        SqlDataReader dr;
        public void KayitliKullaniciEkranaBas()
        {
            try
            {
                cmd = new SqlCommand("SELECT userName From SOHTS.dbo.kullanici", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1_KullanicilarEkranaBas.Items.Add(dr["userName"].ToString().Trim());
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

        //Kayit varsa diğer formu açar ve kayıtları doldurur.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aranan_kullanici=comboBox1_KullanicilarEkranaBas.Text;

            bool poliklinik_ac_bool = KullaniciTanitmaKullaniciEkraniAc(aranan_kullanici);
            // false geri dönüş var ise veri var demektir
            if (poliklinik_ac_bool == false)
            {
                kullanici p = new kullanici();
                p.MdiParent = Program.owner;
                p.Show();
                this.Close();
            }

        }

        public bool KullaniciTanitmaKullaniciEkraniAc(string kullanici_userName)
        {
            try
            {
                cmd = new SqlCommand("SELECT * From SOHTS.dbo.kullanici WHERE userName = @kullanici_userName", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@kullanici_userName", SqlDbType.VarChar);
                cmd.Parameters["@kullanici_userName"].Value = kullanici_userName;

                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KullaniciVeriAktarimi.kullaniciUserName = dr["userName"].ToString();
                    if (KullaniciVeriAktarimi.kullaniciUserName != "")
                    {
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

        private void button1_YeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (comboBox1_KullanicilarEkranaBas.Text != "")
            {
                YeniKullaniciEkleme();
            }
            else
                MessageBox.Show("Lütfen Bir Kullanıcı Adı Girin");
        }

        private void YeniKullaniciEkleme()
        {
            string aranan_kullanici = comboBox1_KullanicilarEkranaBas.Text;

            bool poliklinik_ac_bool = KullaniciTanitmaKullaniciEkraniAc(aranan_kullanici);
            // false geri dönüş var ise veri var demektir
            if (poliklinik_ac_bool == false)
            {
                KullaniciVeriAktarimi.kullaniciUserName = aranan_kullanici;
                kullanici p = new kullanici();
                p.MdiParent = Program.owner;
                p.Show();
                this.Close();
            }
            if (poliklinik_ac_bool == true)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO SOHTS.dbo.kullanici (userName) VALUES (@aranan_kullanici)", SQLBaglanti.SqlBaglan());
                    cmd.Parameters.Add("@aranan_kullanici", SqlDbType.VarChar);
                    cmd.Parameters["@aranan_kullanici"].Value = aranan_kullanici;

                    SQLBaglanti.SqlBaglan().Open();
                    
                    dr = cmd.ExecuteReader();
                    // Diğer formda verileri okuyabilmek için kullanıcı adı ataması yapıldı
                    KullaniciVeriAktarimi.kullaniciUserName = aranan_kullanici;

                    // Ekledikten sonra bilgi ekranına yönlendirme yapıldı
                    kullanici p = new kullanici();
                    p.MdiParent = Program.owner;
                    p.Show();
                    this.Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
                }
                finally
                {
                    SQLBaglanti.SqlBaglan().Close();
                }
            }
        }
    }
}
