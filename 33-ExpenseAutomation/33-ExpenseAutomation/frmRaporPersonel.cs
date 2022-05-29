using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _33_ExpenseAutomation
{
    public partial class frmRaporPersonel : Form
    {
        public frmRaporPersonel()
        {
            InitializeComponent();
        }

        List<MasrafRaporu> raporMasrafları = new List<MasrafRaporu>();
        private void frmRaporPersonel_Load(object sender, EventArgs e)
        {
            List<Masraf> masraflar = DosyaIslemleri.GetirMasraflar();
            List<Kullanici> kullanicilar = DosyaIslemleri.GetirKullanicilar();

            foreach (Masraf masraf in masraflar)
            {

                string sahibi = string.Empty;

                foreach (Kullanici kullanici in kullanicilar)
                {
                    if (masraf.KullaniciId == kullanici.Id)
                    {

                        sahibi = kullanici.TamAdi;
                        break;
                    }
                }
                MasrafRaporu masrafRaporu = new MasrafRaporu
                {
                    Id = masraf.Id,
                    Aciklama = masraf.Aciklama,
                    MasrafTipi = masraf.MasrafTipi,
                    FisNo = masraf.FisBilgisi.No,
                    Tarih = masraf.FisBilgisi.Tarih,
                    Tutar = masraf.FisBilgisi.Tutar,
                    Durumu = EnumHelper.GetMasrafDurumName(masraf.Durumu),
                    Sahibi = sahibi
                };

                raporMasrafları.Add(masrafRaporu);
            }
            dgvVeriler.DataSource = null;
            dgvVeriler.DataSource = raporMasrafları;

            dgvVeriler.Columns["Id"].Visible = false;
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Title = "Excel Aktar";
            saveFileDialog.FileName = "personel_masraf_raporu.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelMapper mapper = new ExcelMapper();
                mapper.Save<MasrafRaporu>(saveFileDialog.FileName, raporMasrafları, "Personel Rapor");

                notifyIcon1.ShowBalloonTip(5000);
            }
        }
    }
}
