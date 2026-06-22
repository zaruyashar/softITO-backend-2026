using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OOP2
{
    internal class Program
    {
        // ALG 2 - Functions
        /*
        static void PopulateDataDynamically<T>(T newObjToPopulate)
        {
            Type classType = typeof(T);
            PropertyInfo[] attributes = classType.GetProperties();

            foreach (PropertyInfo attribute in attributes)
            {
                // Not the best display UX-wise :D
                Console.WriteLine($"{attribute.Name} ({attribute.PropertyType.Name}) değerini girin: ");
                string userInput = Console.ReadLine();

                try
                {
                    object convertedVal = Convert.ChangeType(userInput, attribute.PropertyType);
                    attribute.SetValue(newObjToPopulate, convertedVal);
                }
                catch
                {
                    Console.WriteLine("Hatalı veri tipi girişi yapıldı.");
                }
            }
        }
        */


        /* ---------------------------- MAIN ----------------------------- */
        static void Main(string[] args)
        {
            // Teacher's example
            /*
            MakineHalisi makineHalisi = new MakineHalisi();
            makineHalisi.Fiyat = 5000;
            makineHalisi.Model = "huzur";
            int tutar = makineHalisi.Hesap(makineHalisi.Fiyat, makineHalisi.Model);
            int vergi = makineHalisi.vergi(tutar);
            makineHalisi.Durum(vergi);

            Console.ReadLine();
            */

            // ALG 1
            /*
            // IT
            IT itDept = new IT();

            itDept.GenelBilgiVer();
            itDept.CalismaSaatleriniGoster();

            // Muhasebe
            Muhasebe muhasebe = new Muhasebe();

            Console.WriteLine("Bir önceki yılın demirbaş sayısı: ");
            int oncekiYilDemirbas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Departmandaki güncel demirbaş sayısı: ");
            int yeniDemirbas = muhasebe.DemirbasSayisi = Convert.ToInt32(Console.ReadLine());

            muhasebe.DemirbasArttiMiAzaldiMi(oncekiYilDemirbas, yeniDemirbas);


            // Pazarlama
            Pazarlama pazarlama = new Pazarlama();

            double marketingROI = Convert.ToDouble(pazarlama.ROIHesapla(1000000, 488000));
            
            Console.WriteLine($"Pazarlama harcamalarının yatırım getirisi: {marketingROI}");
            */


            /* Teacher's example copied over--
            Tasit tasit = new Tasit();

            Console.WriteLine("Taşıt adı : " + tasit.TasitAdi);
            Console.WriteLine("taşıt yılı " + tasit.Tasityil);

            AgirVasita vasita = new AgirVasita("çekici", 15000, "çok çekici");

            Console.WriteLine("vasıta Adı giriniz");
            vasita.Vadi = Console.ReadLine();
            Console.WriteLine("Fiyat giriniz");
            vasita.Fiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vasıta adı : " + vasita.Vadi);
            Console.WriteLine("Vasıta fiyat : " + vasita.Fiyat);
            Console.WriteLine("Vasıta özellik" + vasita.Ozellik);

            Console.ReadLine();*/


            // ALG 2
            Console.WriteLine("=== ARSA ===");
            
            Arsa arsa1 = new Arsa();
            
            arsa1.yapiDurumu = "İmarlı";
            arsa1.emlakCinsi = "Arsa";
            arsa1.belgeNo = 123456;
            arsa1.m2 = 6000;
            arsa1.m2Fiyat = 2000;
            arsa1.tapuAdi = "Ayşe Yılmaz";
            arsa1.tapuNo = 987;
            arsa1.tapuDurumu = "Müstakil";
            arsa1.arsaDurumu = "Şahsi";

            arsa1.SatisaUygunMu();
            Console.WriteLine($"Arsa fiyatı: {arsa1.FiyatHesapla()} TL");
            Console.WriteLine($"Arsanın toplam fiyatı: {arsa1.ToplamFiyatHesapla()} TL");
            arsa1.YapiIzniOrani();



            Console.WriteLine("\n=== KONUT ===");

            Konut konut1 = new Konut();

            konut1.yapiDurumu = "İmarlı";
            konut1.emlakCinsi = "Konut";
            konut1.belgeNo = 654321;
            konut1.brutM2 = 120;
            konut1.m2Fiyat = 25000;
            konut1.balkonluMu = true;
            konut1.cephe = "Güney";
            konut1.enerjiKimlik = "A++";
            konut1.depremPuan = 100;

            Console.WriteLine($"Konut fiyatı: {konut1.FiyatHesapla()} TL");
            Console.WriteLine($"Konutun toplam fiyatı: {konut1.ToplamFiyatHesapla()} TL");
            konut1.KrediVer();



            Console.WriteLine("\n=== VİLLA ===");

            Villa villa1 = new Villa();

            Console.WriteLine($"1. standart villa tipi: {villa1.villaTipi}");

            Villa villa2 = new Villa("İmarlı", 111222, "Konut", 250, 40000, "Dubleks");

            Console.WriteLine($"2. özel villa tipi: {villa2.villaTipi}");
            Console.WriteLine($"2. villa fiyatı: {villa2.FiyatHesapla()} TL");
            Console.WriteLine($"2. villanın toplam fiyatı: {villa2.ToplamFiyatHesapla()} TL");

            Console.ReadLine();


        }
    }
}
