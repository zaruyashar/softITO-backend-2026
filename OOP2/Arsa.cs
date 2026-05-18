using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal sealed class Arsa : Emlak
    {
        public string tapuAdi { get; set; }
        public int tapuNo { get; set; }
        private string TapuDurumu;
        private string ArsaDurumu;


        // Properties
        public string tapuDurumu
        {
            get { return TapuDurumu; }
            set
            {
                if (value == "Müstakil" || value == "Hisseli")
                {
                    TapuDurumu = value;
                }
                else
                {
                    Console.WriteLine("Kabul edilmeyen bir değer girdiniz.");
                }
            }
        }

        public string arsaDurumu
        {
            get { return ArsaDurumu; }
            set
            {
                if (value == "Toplu konut" || value == "Spor" || value == "Şahsi")
                {
                    ArsaDurumu = value;
                }
                else
                {
                    Console.WriteLine("Kabul edilmeyen bir değer girdiniz.");
                }
            }
        }


        // Methods
        public override double FiyatHesapla()
        {
            return m2 * m2Fiyat;
        }

        public override double ToplamFiyatHesapla()
        {
            double temelFiyat = FiyatHesapla();
            komisyon = temelFiyat * 0.04;
            return temelFiyat + komisyon;
        }

        public int YapiIzniOrani()
        {
            int yapiIzinOran = 0;

            if (m2 > 7000)
            {
                yapiIzinOran = 30;
            }
            else if (m2 >= 5000 && m2 <= 7000)
            {
                yapiIzinOran = 15;
            }
            else
            {
                Console.WriteLine("Yapı izni oranı ilgili aralıkta değil.");
            }

            Console.WriteLine($"Yapı izin oranınız: %{yapiIzinOran}");
            return yapiIzinOran;
        }
    }
}
