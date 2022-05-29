using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace _33_ExpenseAutomation
{
    class DosyaIslemleri
    {
        private static string PathKullanicilar = Application.StartupPath + "\\kullanicilar.json";
        private static string PathMasrafTipleri = Application.StartupPath + "\\masraftipleri.json";
        private static string PathMasraflar = Application.StartupPath + "\\masraflar.json";
        private static JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static List<Kullanici> GetirKullanicilar()
        {
            if (File.Exists(PathKullanicilar))
            {
                string json = File.ReadAllText(PathKullanicilar);

                return JsonSerializer.Deserialize<List<Kullanici>>(json, options);
            }
            return new List<Kullanici>();
        }

        public static void KaydetKullanicilar(List<Kullanici> kullanicilar)
        {
            string json = JsonSerializer.Serialize<List<Kullanici>>(kullanicilar, options);
            File.WriteAllText(PathKullanicilar, json);
        }

        public static List<string> GetirMasrafTipleri()
        {
            if (File.Exists(PathMasrafTipleri))
            {
                string json = File.ReadAllText(PathMasrafTipleri);
                return JsonSerializer.Deserialize<List<string>>(json, options);
            }
            return new List<string>();
        }

        public static void KaydetMasrafTipleri(List<string> masrafTipleri)
        {
            string json = JsonSerializer.Serialize<List<string>>(masrafTipleri, options);
            File.WriteAllText(PathMasrafTipleri, json);
        }

        public static List<Masraf> GetirMasraflar()
        {
            if (File.Exists(PathMasraflar))
            {
                string json = File.ReadAllText(PathMasraflar);
                return JsonSerializer.Deserialize<List<Masraf>>(json, options);
            }
            return new List<Masraf>();
        }

        public static void KaydetMasraflar(List<Masraf> masraflar)
        {
            string json = JsonSerializer.Serialize<List<Masraf>>(masraflar, options);
            File.WriteAllText(PathMasraflar, json);
        }

    }
}
