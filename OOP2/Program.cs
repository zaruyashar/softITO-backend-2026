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
        // Using reflection for the first time!
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
            Arsa yeniArsa = new Arsa();

            Console.WriteLine("--- Emlak Kayıt Sistemi ---");

            PopulateDataDynamically(yeniArsa); // Reflection kullandım







        }
    }
}
