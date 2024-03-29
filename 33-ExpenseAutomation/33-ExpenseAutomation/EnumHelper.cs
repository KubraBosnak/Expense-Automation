﻿using System.Collections.Generic;

namespace _33_ExpenseAutomation
{
    public static class EnumHelper
    {
        public static string GetKullaniciTipiName(KullaniciTipi kullaniciTipi)  // Enum listeyi string olarak gönderebilmesi için method yazdık
        {
            string result = string.Empty;

            switch (kullaniciTipi)
            {
                case KullaniciTipi.admin:
                    result = "Admin";
                    break;
                case KullaniciTipi.personel:
                    result = "Personel";
                    break;
                case KullaniciTipi.muhasebeci:
                    result = "Muhasebeci";
                    break;
                case KullaniciTipi.yonetici:
                    result = "Yönetici";
                    break;

                default:
                    break;
            }
            return result;
        }

        public static string GetMasrafDurumName(MasrafDurum durum)
        {
            string result = string.Empty;
            {
                switch (durum)
                {
                    case MasrafDurum.OnayBekliyor:
                        result = "Onay Bekliyor";
                        break;
                    case MasrafDurum.Onaylandi:
                        result = "Onaylandi";
                        break;
                    case MasrafDurum.Reddedildi:
                        result = "Reddedildi";
                        break;
                    case MasrafDurum.Odendi:
                        result = "Ödendi";
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        public static List<EnumObject> GetKullaniciTipiList()
        {
            List<EnumObject> result = new List<EnumObject>();
            result.Add(new EnumObject { Name = GetKullaniciTipiName(KullaniciTipi.admin), Value = (int)KullaniciTipi.admin });
            result.Add(new EnumObject { Name = GetKullaniciTipiName(KullaniciTipi.personel), Value = (int)KullaniciTipi.personel });
            result.Add(new EnumObject { Name = GetKullaniciTipiName(KullaniciTipi.yonetici), Value = (int)KullaniciTipi.yonetici });
            result.Add(new EnumObject { Name = GetKullaniciTipiName(KullaniciTipi.muhasebeci), Value = (int)KullaniciTipi.muhasebeci });

            // yukarıdaki işlemin aynısını yapar

            //List<EnumObject> result2 = new List<EnumObject>();

            //foreach (string enumName in Enum.GetNames(typeof(KullaniciTipi)))
            //{
            //    KullaniciTipi tip = Enum.Parse<KullaniciTipi>(enumName);

            //    result2.Add(new EnumObject
            //    {
            //        Name = GetKullaniciTipiName(tip),
            //        Value = (int)tip
            //    });
            //}


            return result;
        }
    }

    public class EnumObject // bu class enumların numerik değerlerini döndürmek için yazıldı.
    {
        public int Value { get; set; }

        public string Name { get; set; }
    }
}
