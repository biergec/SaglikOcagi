using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SaglikOcagi
{
    public partial class AnaForm : Form
    {
        Login login;
        poliklinik_giris poliklinik;
        public AnaForm()
        {
            InitializeComponent();
            login = new Login();
            FormAc(login);
            hastaKabulToolStripMenuItem.Enabled = false;
            kullaniciİşlemleriToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
            referanslarToolStripMenuItem.Visible = false;
        }

        public void YetkiliKullaniciKontrol()
        {
            if (YetkiliKullaniciKontorl.YetkliKullanici == "true")
            {
                referanslarToolStripMenuItem.Visible = true;
            }
            else
                referanslarToolStripMenuItem.Visible = false;
        }

        public void Menu_ReferanslarAktif()
        {
            hastaKabulToolStripMenuItem.Enabled = true;
            raporlarToolStripMenuItem.Enabled = true;
            referanslarToolStripMenuItem.Visible = true;
            kullaniciİşlemleriToolStripMenuItem.Enabled = true;
            YetkiliKullaniciKontrol();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.owner = this; //tüm program içinde owner formun bu form olduğunu belirtiyoruz.
            IsMdiContainer = true;
          
        }

        public void FormAc(Form AcilacakForm)
        {
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                //Eğer Form2 Form1 üzrinde açıldıysa
                if (form.Text == AcilacakForm.Text)
                {
                    // açıksa true 
                    durum = true;
                    // Form 2 Aktif Edildi
                    form.Activate();
                    form.Show();
                }
                else
                    form.Close();
            }

            // Form2 Form1 üzerinde açık değilse
            if (!durum)
            {
                //Form2'nin ana penceresi olarak Form1 i ayarladık
                AcilacakForm.MdiParent = this;
                //Form2'yi açtık
                AcilacakForm.Show();
            }
        }

        private void hastaKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void hastaKabulToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastaKabulToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
            referanslarToolStripMenuItem.Visible = false;
            login = new Login();
            FormAc(login);
        }

        

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poliklinik = new poliklinik_giris();
            FormAc(poliklinik);
        }

        kullanici_tanitma kullanici_tanit;
        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanici_tanit = new kullanici_tanitma();
            FormAc(kullanici_tanit);
        }

        HastaIslemleri hasta_islemleri;
        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2 && Application.OpenForms["Login"]==null)
            {
                hasta_islemleri = new HastaIslemleri();
                FormAc(hasta_islemleri);
            }
        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hasta_islemleri = new HastaIslemleri();
            FormAc(hasta_islemleri);
        }

        private void referanslarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programdanÇıkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hastaKabulToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
            referanslarToolStripMenuItem.Visible = false;
            kullaniciİşlemleriToolStripMenuItem.Enabled = false;
            login = new Login();
            FormAc(login);
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.MdiParent = Program.owner;
            rapor.Show();
        }

    }
}
