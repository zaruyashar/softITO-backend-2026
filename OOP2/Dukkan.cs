using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Dukkan : Emlak
    {
        public int vitrinGenisligi { get; set; }

        // class implementation
        public override double FiyatHesapla()
        {
            throw new NotImplementedException();
        }

        public override string KullanimAmaciniBelirt()
        {
            Console.WriteLine("Ticari faaliyetler ve perakende satış için uygundur.");
        }

        public override double ToplamFiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
