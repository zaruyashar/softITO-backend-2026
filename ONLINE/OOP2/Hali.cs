using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // Teacher's example
    abstract class Hali
    {
        private string Marka;
        private string Model;
        private int Fiyat;


        public string marka { get { return Marka; } set { Marka = value; } }
        public string model { get { return Model; } set { Model = value; } }
        public int fiyat { get { return Fiyat; } set { Fiyat = value; } }


        public abstract int Hesap(int fiyat, string model);

        public void Durum(int fiyat)
        {
            fiyat += fiyat * 2 / 100;

            Console.WriteLine("ödemeniz gereken tutar :" + fiyat);
        }
    }
}
