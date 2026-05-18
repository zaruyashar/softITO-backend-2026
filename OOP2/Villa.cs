using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Villa : Konut
    {
        public string villaTipi { get; set; }

        // Constructor
        public Villa()
        {
            villaTipi = "Standart";
        }

        public Villa(string yapiDurum, int bNo, string eCinsi, double m2Degeri, double fiyatM2, string tip)
        {
            yapiDurumu = yapiDurum;
            belgeNo = bNo;
            emlakCinsi = eCinsi;
            m2 = m2Degeri;
            m2Fiyat = fiyatM2;
            villaTipi = tip;
        }


        // Methods
        public override double FiyatHesapla()
        {
            double carpan = 1.0;

            switch (villaTipi)
            {
                case "Dubleks":
                    carpan = 1.25;
                    break;
                case "Tripleks":
                    carpan = 1.50;
                    break;
                default:
                    carpan = 1.0;
                    break;
            }

            return m2 * m2Fiyat * carpan;
        }

        public override double ToplamFiyatHesapla()
        {
            double temelFiyat = FiyatHesapla();
            komisyon = temelFiyat * 0.02;
            return temelFiyat + komisyon;
        }
    }
}
