using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class EvMobilyasi : Mobilya
    {
        public int UrunKodu;
        public int StokAdet;
        public string Bolge;
        public string Sube;


        public override void MalzemeBilgisiGoster()
        {
            // malzemenin niteliğiyle ilgili bilgilendirme yapılsın
        }

        public override bool MarkaSozlesmesiVarMi(string brand, string productType)
        {
            // brand ve ürün için sözleşme varsa true dönsün
            // true koşulu sağlandığında ürünü %5 ek indirim için indirim metoduna göndersin, ürün sayfasına o fiyat çekilsin
            return true;
        }

        public override float İndirimHesapla(float price, float indirimYuzdesi)
        {
            // marka sözleşmesi olan ancak ofis mobilyası olmayan ürünler %5 indirimli gösterilsin
            return 1;
        }
    }
}
