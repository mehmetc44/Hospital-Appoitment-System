using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistem.Classes.Operations
{
    internal class Hesaplamalar
    {

        public static int YasHesapla(string date)
        {
            DateTime birthDate;
            if (DateTime.TryParse(date, out birthDate))
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;

                if (birthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
            else
            {
                return 0;
            }
        }
        public static int TarihKarsilastir(string tarihStr1, string tarihStr2)
        {
            DateTime tarih1;
            DateTime tarih2;

            // Tarihleri DateTime olarak parse et
            if (DateTime.TryParse(tarihStr1, out tarih1) && DateTime.TryParse(tarihStr2, out tarih2))
            {
                // Tarihleri karşılaştır
                return DateTime.Compare(tarih1, tarih2);
            }
            else
            {
                throw new ArgumentException("Geçersiz tarih formatı.");
            }
        }
        public static string GetBolumDescription(int bolumId)
        {
            string description = string.Empty; // Başlangıçta boş bir string değeri

            switch (bolumId)
            {
                case 1:
                    description = "Cildiye";
                    break;
                case 2:
                    description = "Fizik Tedavi";
                    break;
                case 3:
                    description = "Dahiliye";
                    break;
                case 4:
                    description = "Kardiyoloji";
                    break;
                case 5:
                    description = "Ortopedi";
                    break;
                case 6:
                    description = "Nöroloji";
                    break;
                case 7:
                    description = "KBB";
                    break;
                case 8:
                    description = "Göz Hastalıkları";
                    break;
                case 9:
                    description = "Kadın Hastalıkları ve Doğum";
                    break;
                case 10:
                    description = "Üroloji";
                    break;
                case 11:
                    description = "Psikiyatri";
                    break;
                case 12:
                    description = "Genel Cerrahi";
                    break;
                case 13:
                    description = "Göğüs Hastalıkları";
                    break;
                case 14:
                    description = "Alerji";
                    break;
                case 15:
                    description = "Gastroenteroloji";
                    break;
                case 16:
                    description = "Endokrinoloji";
                    break;
                case 17:
                    description = "Radyoloji";
                    break;
                case 18:
                    description = "Anestezi ve Reanimasyon";
                    break;
                case 19:
                    description = "Onkoloji";
                    break;
                case 20:
                    description = "Enfeksiyon Hastalıkları";
                    break;
                case 21:
                    description = "Diyetetik";
                    break;
                default:
                    description = "Geçersiz bölüm ID'si";
                    break;
            }

            return description;
        }
        public static int GetKanGurubuId(string kangurup)
        {
            int kangrubu;
            switch (kangurup)
            {
                case "0-": kangrubu = 1; break;
                case "0+": kangrubu = 2; break;
                case "A-": kangrubu = 3; break;
                case "A+": kangrubu = 4; break;
                case "B-": kangrubu = 5; break;
                case "B+": kangrubu = 6; break;
                case "AB-": kangrubu = 7; break;
                case "AB+": kangrubu = 8; break;
                default: kangrubu = 0; break;
            }
            return kangrubu;
        }
        public static string GetKanGurubuById(int kangrubuId)
        {
            string kangurup;
            switch (kangrubuId)
            {
                case 0: kangurup = "-"; break;
                case 1: kangurup = "0-"; break;
                case 2: kangurup = "0+"; break;
                case 3: kangurup = "A-"; break;
                case 4: kangurup = "A+"; break;
                case 5: kangurup = "B-"; break;
                case 6: kangurup = "B+"; break;
                case 7: kangurup = "AB-"; break;
                case 8: kangurup = "AB+"; break;
                default: kangurup = "-"; break;
            }
            return kangurup;
        }
    }
}
