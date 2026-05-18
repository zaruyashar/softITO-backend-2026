using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal abstract class Emlak
    {
        private string YapiDurumu;
        private string BelgeAdi;
        private int BelgeNo;
        private string EmlakCinsi;
        private string BolgeSorumlusu;
        private string AlimSatimSorumlusu;
        private string AlimDurumu;
        private double Komisyon;
        private double M2Fiyat;
        private double M2;


        // Properties
        public string yapiDurumu
        {
            get { return YapiDurumu; }
            set
            {
                if (value == "İmarlı")
                {
                    YapiDurumu = value;
                }
                else
                {
                    Console.WriteLine("Kabul edilmeyen bir değer girdiniz.");
                }
            }
        }

        public string belgeAdi { get { return BelgeAdi; } set { BelgeAdi = value; } }

        public int belgeNo
        {
            get { return BelgeNo; }
            set
            {
                if (value > 99999 && value < 1000000)
                {
                    BelgeNo = value;
                }
                else
                {
                    Console.WriteLine("Kabul edilmeyen bir değer girdiniz.");
                }
            }
        }

        public string emlakCinsi
        {
            get { return EmlakCinsi; }
            set
            {
                if (value == "Arsa" || value == "Konut")
                {
                    EmlakCinsi = value;
                }
                else
                {
                    Console.WriteLine("Kabul edilmeyen bir değer girdiniz.");
                }
            }
        }

        public string bolgeSorumlusu { get { return BolgeSorumlusu; } set { BolgeSorumlusu = value; } }

        public string alimSatimSorumlusu { get { return AlimSatimSorumlusu; } set { AlimSatimSorumlusu = value; } }

        public string alimDurumu
        {
            get { return AlimDurumu; }
            set
            {
                if (value == "Kiralık" || value == "Satılık")
                {
                    AlimDurumu = value;
                }
                else
                {
                    Console.WriteLine("Kabul edilmeyen bir değer girdiniz.");
                }
            }
        }

        public double komisyon { get { return Komisyon; } set { Komisyon = value; } }

        public double m2Fiyat { get { return M2Fiyat; } set { M2Fiyat = value; } }

        public double m2 { get { return M2; } set { M2 = value; } }


        // Methods
        public abstract double FiyatHesapla();

        public abstract double ToplamFiyatHesapla();

        public virtual bool SatisaUygunMu()
        {
            if (YapiDurumu == "İmarlı")
            {
                Console.WriteLine("Satışa uygundur.");
                return true;
            }
            else
            {
                Console.WriteLine("Satışa uygun değildir.");
                return false;
            }
        }
    }
}
