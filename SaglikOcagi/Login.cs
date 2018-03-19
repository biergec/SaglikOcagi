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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            button_Temizle.Enabled = false;
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            if (textBox_Kullani_Adi.Text.Length > 0 || textBox_Sifre.Text.Length > 0)
            {
                textBox_Kullani_Adi.Text = "";
                textBox_Sifre.Text = "";
            }
            else
                MessageBox.Show("Kullanıcı Adı Veya Şifre Girmelisiniz.");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Kullani_Adi_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Kullani_Adi.Text.Length > 0)
            {
                button_Temizle.Enabled = true;
            }else if (textBox_Kullani_Adi.Text.Length <= 0)
            {
                button_Temizle.Enabled = false;
            }
        }

        private void textBox_Sifre_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Sifre.Text.Length>0)
            {
                button_Temizle.Enabled = true;
            }
            else if (textBox_Sifre.Text.Length <= 0)
            {
                button_Temizle.Enabled = false;
            }
        }

        private void button_Cikis_Yap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlCommand cmd;
        SqlDataReader dr;
        private void button_Giris_Yap_Click(object sender, EventArgs e)
        {
            Boolean durum=false;
            durum = GirisYap();

            if (durum==true)
            {
                ((AnaForm)this.MdiParent).Menu_ReferanslarAktif();
                this.Hide();
            }
            else
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre");
        }

        public Boolean GirisYap()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM SOHTS.dbo.kullanici where userName = @KullaniciAd AND sifre= @KullaniciSifre ", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@KullaniciAd", SqlDbType.VarChar);
                cmd.Parameters["@KullaniciAd"].Value = textBox_Kullani_Adi.Text;
                cmd.Parameters.Add("@KullaniciSifre", SqlDbType.VarChar);
                cmd.Parameters["@KullaniciSifre"].Value = textBox_Sifre.Text;

                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    YetkiliKullaniciKontorl.YetkliKullanici = dr["yetki"].ToString().Trim();
                    return true;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return false;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }

            return false;
        }

        private void textBox_Kullani_Adi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && textBox_Sifre.Text!="" && textBox_Kullani_Adi.Text!="")
            {
                enterKullaniciGiris();
            }
        }

        public void enterKullaniciGiris()
        {
            Boolean durum;
            durum = GirisYap();

            if (durum == true)
            {
                ((AnaForm)this.MdiParent).Menu_ReferanslarAktif();
                this.Hide();
            }
            else
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre");
        }

        private void textBox_Sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox_Sifre.Text != "" && textBox_Kullani_Adi.Text != "")
            {
                enterKullaniciGiris();
            }
        }
    }
}
