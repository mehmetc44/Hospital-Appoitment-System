using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedikApp.UI.Models
{
    internal class RandevuBilgi
    {
        public RandevuBilgi(Doktor doktor, Hastane hastane, Klinik klinik, Sehir sehir)
        {
            this.klinik = klinik;
            this.doktor = doktor;
            this.hastane = hastane;
            this.sehir = sehir;

        }
        public Doktor doktor;
        public Hastane hastane;
        public Klinik klinik;
        public Sehir sehir;
    }
}
