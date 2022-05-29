using System;

namespace _33_ExpenseAutomation
{
    public class Masraf   // Bu bir sınıftır.
    {
        // GUID : {63BB24AF-E49B-44D1-B4C3-73CA29C483FA

        public Guid Id { get; set; }//bu bir ID propertysidir. Masrafın ID'sini burada tutacağız. Tipi de unique olması için guid üretilir.
        public string MasrafTipi { get; set; }  // bu bir masraf tipi propertysidir. Sabit olacağı için class a ihtiyaç duymadık
        public Fis FisBilgisi { get; set; }  // Fiş bilgileri Fis classından gelecek. Newlenmesi lazım
        public string Aciklama { get; set; }
        public MasrafDurum Durumu { get; set; }  // Enum olarak tanımladığımız masraf durumları gelecek
        public Guid KullaniciId { get; set; }  // Masrafı yapan kişinin ID'sini tutmak için

    }

    public class MasrafRaporu
    {
        public Guid Id { get; set; }
        public string MasrafTipi { get; set; }
        public string FisNo { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
        public string Durumu { get; set; }
        public string Sahibi { get; set; }
    }


    public enum MasrafDurum
    {
        OnayBekliyor = 0,
        Onaylandi = 1,
        Reddedildi = 2,
        Odendi = 3
    }

    public class Fis
    {
        public string No { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
    }

    public class Kullanici
    {
        public Guid Id { get; set; }  // Kullanıcı ID'si unique olması için Guid tipinde kullandık.
        public string TamAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public KullaniciTipi Tipi { get; set; } // Enum olarak tanımladığımız kullanıcı tipleri gelecek
        public Guid? YoneticiId { get; set; }

        //public string DisplayText { get { return $"{TamAdi} ({KullaniciAdi})"; } } //listbox ı seçip display member e property nin ismi olan DisplayText yazmak gerekiyor.

        public override string ToString() // Listbox a tam adı ve kullanıcı adını yazdırmak için gerekli. Datasource ile listbox a yazdırınca olmuyor
        {
            return $"{TamAdi} ({KullaniciAdi})";
        }
    }

    public enum KullaniciTipi
    {
        admin = 0,
        personel = 1,
        yonetici = 2,
        muhasebeci = 3
    }
}


