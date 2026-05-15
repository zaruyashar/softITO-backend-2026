using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class VipMusteri : Musteri
    {
        private decimal ekstraIndirimOrani;
        private string ozelDanismanAdSoyadi;

        public decimal EkstraIndirimOrani
        {
            get { return ekstraIndirimOrani; }
            set { ekstraIndirimOrani = value; }
        }

        public string OzelDanismanAdSoyad
        {
            get { return ozelDanismanAdSoyadi; }
            set { ozelDanismanAdSoyadi = value; }
        }

        public decimal IndirimliTutarHesapla(decimal sepetTutari)
        {
            decimal indirimMiktari = sepetTutari * EkstraIndirimOrani;
            return sepetTutari - indirimMiktari;
        }
    }
}
