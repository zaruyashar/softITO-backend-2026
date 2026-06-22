using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal sealed class Muhasebe : Departman
    {
        public int DemirbasSayisi;

        public override void IsTanimi()
        {
            Console.WriteLine("Muhasebe departmanı finansal kayıtları tutar ve maaşları öder.");
        }

        public void DemirbasArttiMiAzaldiMi(int oncekiYilDemirbas, int yeniDemirbas)
        {
            int fark = yeniDemirbas - oncekiYilDemirbas;

            if (yeniDemirbas > oncekiYilDemirbas)
            {
                Console.WriteLine($"Demirbaş sayısı {fark} artmış.");
            }
            else if (yeniDemirbas < oncekiYilDemirbas)
            {
                Console.WriteLine($"Demirbaş sayısı {fark} azalmış.");
            }
            else
            {
                Console.WriteLine("Sayıda değişiklik yok.");
            }
        }
    }
}
