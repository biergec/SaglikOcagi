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
    public partial class DosyaNoKullaniciBulma : Form
    {
        public DosyaNoKullaniciBulma()
        {
            InitializeComponent();
        }

        private void DosyaNoKullaniciBulma_Load(object sender, EventArgs e)
        {
            label2_ad.Hide();
            checkBox1_Ve.Hide();
            label3_soyad.Hide();
            label4_aramaSorguGir.Hide();
            textBox1_Ad.Hide();
            textBox2_Soyad.Hide();
            textBox3_AramaNormalSorgu.Hide();
            ComboBoxVeriYukleme();
        }

        private void ComboBoxVeriYukleme()
        {
            string[] kriterler = { "Hasta Ad Soyad", "TC Kimlik No","Kurum Sicil No","Dosya No" };

            foreach (var item in kriterler)
                comboBox1_AramaKriterleri.Items.Add(item);
        }

        private void comboBox1_AramaKriterleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ComboBoxDeger = comboBox1_AramaKriterleri.Text.Trim();
            if (ComboBoxDeger == "Hasta Ad Soyad")
            {
                label2_ad.Show();
                label3_soyad.Show();
                label4_aramaSorguGir.Hide();
                textBox1_Ad.Show();
                textBox2_Soyad.Show();
                textBox3_AramaNormalSorgu.Hide();
                checkBox1_Ve.Show();
            }
            else
            {
                label2_ad.Hide();
                label3_soyad.Hide();
                label4_aramaSorguGir.Show();
                textBox1_Ad.Hide();
                textBox2_Soyad.Hide();
                textBox3_AramaNormalSorgu.Show();
                checkBox1_Ve.Hide();
            }
        }

        private void button1_Bul_Click(object sender, EventArgs e)
        {
            string ArananDeger,KOSUL, ArananDeger2Soyad;
            if (comboBox1_AramaKriterleri.Text == "Hasta Ad Soyad")
            {
                if (checkBox1_Ve.Checked!=true)
                {
                    ArananDeger = textBox1_Ad.Text.Trim();
                    HastaDadaGridViewEkleme(ArananDeger, 1);
                }
                else if (checkBox1_Ve.Checked == true)
                {
                    ArananDeger = textBox1_Ad.Text.Trim();
                    ArananDeger2Soyad = textBox2_Soyad.Text;
                    KOSUL = ArananDeger + " " + ArananDeger2Soyad;
                    HastaDadaGridViewEkleme(KOSUL,2);
                }
            }
            else if (comboBox1_AramaKriterleri.Text == "TC Kimlik No")
            {
                ArananDeger = textBox3_AramaNormalSorgu.Text.Trim();
                HastaDadaGridViewEkleme(ArananDeger, 3);
            }
            else if (comboBox1_AramaKriterleri.Text == "Kurum Sicil No")
            {
                ArananDeger = textBox3_AramaNormalSorgu.Text.Trim();
                HastaDadaGridViewEkleme(ArananDeger, 4);
            }
            else if (comboBox1_AramaKriterleri.Text == "Dosya No")
            {
                ArananDeger = textBox3_AramaNormalSorgu.Text.Trim();
                HastaDadaGridViewEkleme(ArananDeger, 5);
            }
        }

        SqlDataAdapter da;
        private void HastaDadaGridViewEkleme(string kosul,int temp)
        {
            dataGridView1_Listele.DataSource = null;
            try
            {
                if (temp == 1)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM hasta WHERE ad=@ad", SQLBaglanti.SqlBaglan());
                    cmd.Parameters.Add("@ad", SqlDbType.VarChar);
                    cmd.Parameters["@ad"].Value = kosul;
                    GridViewYazdir(cmd);
                }
                if (temp == 2)
                {
                    string[] kosul_parse = kosul.Split(' ');
                    SqlCommand cmd = new SqlCommand("SELECT * FROM hasta WHERE ad=@ad and soyad=@soyad", SQLBaglanti.SqlBaglan());
                    cmd.Parameters.Add("@ad", SqlDbType.VarChar);
                    cmd.Parameters["@ad"].Value = kosul_parse[0];

                    cmd.Parameters.Add("@soyad", SqlDbType.VarChar);
                    cmd.Parameters["@soyad"].Value = kosul_parse[1];
                    GridViewYazdir(cmd);
                }
                if (temp == 3)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM hasta WHERE TC=@TC", SQLBaglanti.SqlBaglan());
                    cmd.Parameters.Add("@TC", SqlDbType.Int);
                    cmd.Parameters["@TC"].Value = kosul;
                    GridViewYazdir(cmd);
                }

                if (temp == 4)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM hasta WHERE kurumSicilNo=@kurumSicilNo", SQLBaglanti.SqlBaglan());
                    cmd.Parameters.Add("@kurumSicilNo", SqlDbType.VarChar);
                    cmd.Parameters["@kurumSicilNo"].Value = kosul;
                    GridViewYazdir(cmd);
                }
                if (temp == 5)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM hasta WHERE dosyaNo=@dosyaNo", SQLBaglanti.SqlBaglan());
                    cmd.Parameters.Add("@dosyaNo", SqlDbType.Int);
                    cmd.Parameters["@dosyaNo"].Value = kosul;
                    GridViewYazdir(cmd);
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

        private void GridViewYazdir(SqlCommand cmd)
        {
            SQLBaglanti.SqlBaglan().Open();
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1_Listele.DataSource = dt;
        }

        private void dataGridView1_Listele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public delegate void DelegeteTanimlamam();
        public event DelegeteTanimlamam hastaDosyaNoEvent;
        public static string deger;
        
        private void dataGridView1_Listele_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deger = dataGridView1_Listele.CurrentRow.Cells["dosyaNo"].Value.ToString();
            HastaIslemleri frm2 = (HastaIslemleri)Application.OpenForms["HastaIslemleri"];
            frm2.textBox1_DosyaNo.Text = deger;

            hastaDosyaNoEvent();
        }
    }
}
