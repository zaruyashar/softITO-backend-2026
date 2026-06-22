using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    abstract class Mobilya
    {
        private string Malzeme;
        private string Tür;
        private string Marka;
        private float Fiyat;


        public string malzeme { get { return Malzeme; } set { Malzeme = value; } }
        public string tür { get { return Tür; } set { Tür = value; } }
        public string marka { get { return Marka; } set { Marka = value; } }
        public float fiyat { get { return Fiyat; } set { Fiyat = value; } }

        public abstract float İndirimHesapla(float price, float indirimYuzdesi);

        public abstract bool MarkaSozlesmesiVarMi(string brand, string productType);

        public abstract void MalzemeBilgisiGoster();
    }
}
