using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class OfisMobilyasi : Mobilya
    {
        public string Model;
        public bool ErgonomikMi;
        public bool AyarlanabilirMi;


        public override void MalzemeBilgisiGoster()
        {
            // malzemenin niteliğiyle ilgili bilgilendirme yapılsın
        }

        public override bool MarkaSozlesmesiVarMi(string brand, string productType)
        {
            // brand ve ürün için sözleşme varsa true dönsün
            // true koşulu sağlandığında ürünü pazarlama ekibine bildirsin (tanıtım afişi çıkmaları için)
            return true;
        }

        public override float İndirimHesapla(float price, float indirimYuzdesi)
        {
            // black friday'de tüm ürünlere; tüm kampanyalara ek %7 indirim eklensin
            // güncel fiyat bilgisi ürün listeleme ekranında buradan çekilsin
            return 1;
        }
    }
}
