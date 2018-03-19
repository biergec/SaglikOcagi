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
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader dr;

        private void kullanici_Load(object sender, EventArgs e)
        {
            CinsiyetMedeniHalKanGrubuUnvanVeriDoldurma();
            if (KullaniciVeriAktarimi.kullaniciUserName != "")
            {
                VarOlanKullaniciVerileriYukleme();
            }
        }

        private void VarOlanKullaniciVerileriYukleme()
        {
            cmd = new SqlCommand("SELECT * From SOHTS.dbo.kullanici WHERE userName=@userName", SQLBaglanti.SqlBaglan());
            cmd.Parameters.Add("@userName", SqlDbType.VarChar);
            cmd.Parameters["@userName"].Value = KullaniciVeriAktarimi.kullaniciUserName;
            try
            {
                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1_KullaniciKod.Text = dr["KullaniciKod"].ToString().Trim();
                    textBox_TC.Text = dr["TC"].ToString().Trim();
                    textBox_DogumYeri.Text = dr["DogumYeri"].ToString().Trim();
                    textBox_BabaAdi.Text = dr["BabaAd"].ToString().Trim();
                    textBox_AnneAdi.Text = dr["AnneAd"].ToString().Trim();
                    textBox_CepTel.Text = dr["cepTelefonNo"].ToString().Trim();
                    textBox_EvTel.Text = dr["evTelefonNo"].ToString().Trim();
                    textBox_Ad.Text = dr["Ad"].ToString().Trim();
                    textBox_Soyad.Text = dr["Soyad"].ToString().Trim();
                    dateTimePicker1_isBaslama.Text = dr["isBaslamaTarih"].ToString().Trim();
                    dateTimePicker2_DogumTarihi.Text = dr["dogumTarihi"].ToString().Trim();
                    comboBox1_cinsiyet.Text = dr["cinsiyet"].ToString().Trim();
                    comboBox2_MedeniHal.Text = dr["medeniHal"].ToString().Trim();
                    textBox_adres.Text = dr["adres"].ToString().Trim();
                    comboBox3_KanGrubu.Text = dr["kanGrubu"].ToString().Trim();
                    textBoxMaas.Text = dr["maas"].ToString().Trim();
                    comboBox1_Unvan.Text = dr["unvan"].ToString().Trim();
                    textBox_KullaniciAd.Text = dr["userName"].ToString().Trim();
                    textBox_Sifre.Text = dr["sifre"].ToString().Trim();
                    string yetki_belgesi = dr["yetki"].ToString().Trim();

                    if (yetki_belgesi == "true")
                    {
                        checkBox_yetkiliKullaniciMi.Checked = true;
                    }
                    else
                        checkBox_yetkiliKullaniciMi.Checked = false;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }

        private void CinsiyetMedeniHalKanGrubuUnvanVeriDoldurma()
        {
            string[] cinsiyetler = { "Kadın", "Erkek" };
            string[] medeniHal = { "Bekar", "Evli", "Dul" };
            string[] unvan = { "Teknisyen", "Doktor", "Gorevli", "Saglik Personeli" };
            string[] kanGrublari = { "AB Rh+", "AB Rh-", "A Rh+", "A Rh-", "B Rh+", "B Rh-", "0 Rh+", "0 Rh-" };

            foreach (var item in cinsiyetler)
                comboBox1_cinsiyet.Items.Add(item);

            foreach (var item in medeniHal)
                comboBox2_MedeniHal.Items.Add(item);

            foreach (var item in kanGrublari)
                comboBox3_KanGrubu.Items.Add(item);

            foreach (var item in unvan)
                comboBox1_Unvan.Items.Add(item);
        }

        public void KullaniciUpdate()
        {
            cmd = new SqlCommand();
            cmd.Connection = SQLBaglanti.SqlBaglan();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "kullanici_tanitma_update_islem";

            cmd.Parameters.Add("@KullaniciKod", SqlDbType.Int);
            cmd.Parameters["@KullaniciKod"].Value = Convert.ToInt32(textBox1_KullaniciKod.Text.Trim());

            cmd.Parameters.Add("@TC", SqlDbType.Int);
            cmd.Parameters["@TC"].Value = Convert.ToInt32(textBox_TC.Text.Trim());

            cmd.Parameters.Add("@DogumYeri", SqlDbType.VarChar);
            cmd.Parameters["@DogumYeri"].Value = textBox_DogumYeri.Text.Trim();

            cmd.Parameters.Add("@BabaAd", SqlDbType.VarChar);
            cmd.Parameters["@BabaAd"].Value = textBox_BabaAdi.Text.Trim();

            cmd.Parameters.Add("@AnneAd", SqlDbType.VarChar);
            cmd.Parameters["@AnneAd"].Value = textBox_AnneAdi.Text.Trim();

            cmd.Parameters.Add("@CepTel", SqlDbType.VarChar);
            cmd.Parameters["@CepTel"].Value = textBox_CepTel.Text.Trim();

            cmd.Parameters.Add("@EvTel", SqlDbType.VarChar);
            cmd.Parameters["@EvTel"].Value = textBox_EvTel.Text.Trim();

            cmd.Parameters.Add("@Ad", SqlDbType.VarChar);
            cmd.Parameters["@Ad"].Value = textBox_Ad.Text.Trim();

            cmd.Parameters.Add("@Soyad", SqlDbType.VarChar);
            cmd.Parameters["@Soyad"].Value = textBox_Soyad.Text.Trim();

            cmd.Parameters.Add("@Maas", SqlDbType.VarChar);
            cmd.Parameters["@Maas"].Value = textBoxMaas.Text.Trim();

            cmd.Parameters.Add("@isBaslama", SqlDbType.Date);
            cmd.Parameters["@isBaslama"].Value = dateTimePicker1_isBaslama.Value;

            cmd.Parameters.Add("@DogumTarihi", SqlDbType.Date);
            cmd.Parameters["@DogumTarihi"].Value = dateTimePicker2_DogumTarihi.Value;

            cmd.Parameters.Add("@Cinsiyet", SqlDbType.VarChar);
            cmd.Parameters["@Cinsiyet"].Value = comboBox1_cinsiyet.Text.Trim();

            cmd.Parameters.Add("@MedeniHal", SqlDbType.VarChar);
            cmd.Parameters["@MedeniHal"].Value = comboBox2_MedeniHal.Text.Trim();

            cmd.Parameters.Add("@KanGrubu", SqlDbType.VarChar);
            cmd.Parameters["@KanGrubu"].Value = comboBox3_KanGrubu.Text.Trim();

            cmd.Parameters.Add("@Unvan", SqlDbType.VarChar);
            cmd.Parameters["@Unvan"].Value = comboBox1_Unvan.Text.Trim();

            cmd.Parameters.Add("@Adres", SqlDbType.VarChar);
            cmd.Parameters["@Adres"].Value = textBox_adres.Text.Trim();

            cmd.Parameters.Add("@userName", SqlDbType.VarChar);
            cmd.Parameters["@userName"].Value = textBox_KullaniciAd.Text.Trim();

            cmd.Parameters.Add("@SifreKullanici", SqlDbType.VarChar);
            cmd.Parameters["@SifreKullanici"].Value = textBox_Sifre.Text.Trim();

            cmd.Parameters.Add("@yetki_durumu", SqlDbType.VarChar);

            if (checkBox_yetkiliKullaniciMi.Checked == true)
            {
                cmd.Parameters["@yetki_durumu"].Value = ("true").ToString();
            }
            else
                cmd.Parameters["@yetki_durumu"].Value = ("false").ToString();

            try
            {
                SQLBaglanti.SqlBaglan().Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Başarılı");
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

        public void EkraniTemizle()
        {
            textBox_KullaniciAd.Text = "";
            comboBox1_Unvan.Text = "";
            textBoxMaas.Text = "";
            textBox_TC.Text = "";
            textBox_DogumYeri.Text = "";
            textBox_BabaAdi.Text = "";
            textBox_AnneAdi.Text = "";
            textBox_CepTel.Text = "";
            textBox_EvTel.Text = "";
            textBox_Ad.Text = "";
            textBox_Soyad.Text = "";
            comboBox1_cinsiyet.Text = "";
            comboBox2_MedeniHal.Text = "";
            comboBox3_KanGrubu.Text = "";
            textBox_adres.Text = "";
            textBox_Sifre.Text = "";
            textBox_KullaniciAd.Text = "";
        }

        private void kullaniciSil()
        {
            cmd = new SqlCommand("SOHTS.dbo.kullanici_kullaniciSil", SQLBaglanti.SqlBaglan());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@KullaniciKod", SqlDbType.VarChar);
            cmd.Parameters["@KullaniciKod"].Value = textBox1_KullaniciKod.Text;
            try
            {
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
            }
        }

        private void textBox1_KullaniciKod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_DogumYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void button2_Guncelle_Click(object sender, EventArgs e)
        {
            if (textBox_TC.Text != "" && textBox_Ad.Text != "" && textBox_Soyad.Text != "")
            {
                DialogResult result = MessageBox.Show("Verileri Güncellemek İstediğinize Emin Misiniz?", "Verileri Güncelle", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    KullaniciUpdate();
                }
            }
            else
                MessageBox.Show("TC, Ad ve Soyad Bölümleri Boş Olamaz");
        }

        private void button1_Temizle_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Tüm alanları temizlemek istediğinize emin misiniz?", "Ekrani Temizle", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                EkraniTemizle();
            }
        }

        private void button3_Sil_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Var Olan Kullanıcıyı Silmek İstediğinize Emin Misiniz! İşlem Geri Alınamamaktadır.", "Kullanıcı Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kullaniciSil();
                    kullanici_tanitma K = new kullanici_tanitma();
                    K.MdiParent = Program.owner;
                    K.Show();
                    this.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button4_Cikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
