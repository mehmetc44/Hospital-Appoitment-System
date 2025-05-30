using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistem.Classes.DataClasses
{
    internal class RandevuBilgileri
    {
        public RandevuBilgileri(Doktorlar doktor, Hastaneler hastane, Klinikler klinik, Sehirler sehir)
        {
            this.klinik = klinik;
            this.doktor = doktor;
            this.hastane = hastane;
            this.sehir = sehir;

        }
        public Doktorlar doktor;
        public Hastaneler hastane;
        public Klinikler klinik;
        public Sehirler sehir;
    }
}
