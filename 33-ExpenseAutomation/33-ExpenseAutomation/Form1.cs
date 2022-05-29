using System;
using System.Windows.Forms;

namespace _33_ExpenseAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuUygulamaHakkında_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuHarcamaTipleri_Click(object sender, EventArgs e)
        {
            frmMasrafTipYonetimi frm = new frmMasrafTipYonetimi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKullanicilar_Click(object sender, EventArgs e)
        {
            frmKullaniciYonetimi frm = new frmKullaniciYonetimi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowGirisFormu();
        }

        private void ShowGirisFormu()
        {
            frmGiris frmGirisFormu = new frmGiris();
            frmGirisFormu.FormClosed += FrmGirisFormu_FormClosed;
            frmGirisFormu.MdiParent = this;
            frmGirisFormu.Show();
        }

        private void FrmGirisFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Degiskenler.GirisYapanKullanici != null)
            {
                menuStrip1.Visible = true;
                lblGirisYapan.Text = Degiskenler.GirisYapanKullanici.TamAdi;

                mnuYonetim.Visible = false;
                mnuMasrafYonetimi.Visible = false;
                mnuRaporlar.Visible = false;

                switch (Degiskenler.GirisYapanKullanici.Tipi)
                {
                    case KullaniciTipi.admin:
                        mnuYonetim.Visible = true;
                        break;
                    case KullaniciTipi.personel:
                        mnuMasrafYonetimi.Visible = true;
                        break;
                    case KullaniciTipi.yonetici:
                        mnuMasrafYonetimi.Visible = true;
                        mnuRaporlar.Visible = true;
                        break;
                    case KullaniciTipi.muhasebeci:
                        mnuMasrafYonetimi.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }
        private void mnuMasraflar_Click(object sender, EventArgs e)
        {
            frmMasraflar frm = new frmMasraflar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuOturumuKapat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                Degiskenler.GirisYapanKullanici = null;

                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                menuStrip1.Visible = false;
                ShowGirisFormu();
            }
        }

        private void mnuPersonelRaporu_Click(object sender, EventArgs e)
        {
            frmRaporPersonel frm = new frmRaporPersonel();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}


//Pattern = Kalıp(Bir sorun üzerine çıkarılmış çözümler)

//MASRAF OTOMASYONU: Yapılan harcamaların tutulması ve raporlanması. Yöneticiler çalışanlarının masraflarını onaylar. Onaylanan masraflar muhasebeye gider. Muhasebe ödeme yapınca süreç tamamlanır.
//1.	Sistem ayağa ilk kalktığında otomatik olarak bir ADMIN (sistem yöneticisi) hesabı eklemeli. (sabit kullanıcı adı ve şifre)
//2.Sistemdeki kullanıcıların ADMIN hesabı ile yönetmeliyim. (ekle/sil/güncelle/şifre değişimi)
//3.Sistem kullanıcısı eklenirken yönetici personeli seçimi de yaptırmalı.
//4.	Admin sadece sistem tarafında takılmalı yani yukarıdaki ekranları görebilmeli
//5.	Harcamaların Tipleri olmalı.(Harcama tiplerini yönetebileceğimiz(ekle/sil/güncelle) ekranı gerekiyor, ADMIN)
//6.Sistemde kullanıcı tipleri tipleri var ve bu tipler ilk etapta sabit (admin, personel, muhasebeci)
//7.Kullanıcı adı ve şifre ile giriş olacak.
//8.	Giriş yapan kullanıcı personel ise, kendi masraflarını görür ve masraf ekler/düzeltme(düzeltme limitli)
//9.Giriş yapan kullanıcı personel yöneticisi ise, kendi masraflarını görür ve masraf ekler/düzeltme(düzeltme limitli)
//10.Giriş yapan kullanıcı personel yöneticisi ise, altında çalışan personellerinde harcamalarını görmeli ve onaylama/reddetme yapabilmeli
//11.	Giriş yapan kullanıcının yöneticisi yoksa, harcama otomatik onaylanır.
//12.	Giriş yapan kullanıcı muhasebeci ise, onaylanan harcamaları öder ve sisteme işler.
//13.	Raporlar; 1.Rapor, giriş yapan kullanıcı harcama tiplerine göre toplam harcama raporu alabilsin.
//14.	Raporlar; 2.Rapor, giriş yapan kullanıcı yönetici ise altındaki personellerin toplama harcamasını görebilsin.
//15.	Raporlar excel export edilebilsin.
