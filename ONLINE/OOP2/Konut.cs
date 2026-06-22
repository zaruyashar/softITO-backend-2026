using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Konut : Emlak
    {
        public double brutM2 { get; set; }
        public bool balkonluMu { get; set; }
        public string cephe { get; set; }
        public int bulunduguKat { get; set; }
        public string enerjiKimlik { get; set; }
        public double depremPuan { get; set; }


        // Methods
        public override double FiyatHesapla()
        {
            double temelFiyat = brutM2 * m2Fiyat;

            if (balkonluMu && cephe == "Güney")
            {
                temelFiyat = temelFiyat * 1.125;
            }

            return temelFiyat;
        }

        public override double ToplamFiyatHesapla()
        {
            double temelFiyat = FiyatHesapla();
            komisyon = temelFiyat * 0.02;
            return temelFiyat + komisyon;
        }

        public void KrediVer()
        {
            if (enerjiKimlik == "A++" && depremPuan == 100)
            {
                double toplamTutar = ToplamFiyatHesapla();
                double aylikTaksit = toplamTutar / 120;
                double yillikTaksit = toplamTutar / 10;

                Console.WriteLine("Tebrikler! Size ön onaylı bir kredi limiti tanımlandı.");
                Console.WriteLine($"Alabileceğiniz toplam kredi: {toplamTutar} TL");
                Console.WriteLine($"10 yıllık vadede aylık taksit tutarı: {aylikTaksit} TL");
                Console.WriteLine($"Yıl başına toplam ödeme: {yillikTaksit} TL");
            }
            else
            {
                Console.WriteLine("Enerji belgesi veya deprem puanı yetersiz olduğundan kredi verilemez.");
            }
        }
    }
}
