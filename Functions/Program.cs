using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        /* Methods */
        // Karesini Alma
        public static int SquareCalc(int n)
        {
            int sqrCalc = n * n;
            return sqrCalc;
        }

        // Login Kontrol
        public static void CredCheck(string nameParam, string pswParam)
        {
            string userName = "admin";
            string password = "123*";

            if (nameParam == userName && pswParam == password)
            {
                Console.WriteLine("Girdiğiniz bilgiler doğru, giriş sayfasına yönlendiriliyorsunuz.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz bilgiler yanlış.");
            }
        }

        // Kur Dönüştürme
        public static double ForeignExchange(double amount, string currency)
        {
            float USD = 45.44f;
            float EUR = 53.33f;
            double convertedAmount = 1;

            if (currency == "USD")
            {
                convertedAmount = amount / USD;
            }
            else
            {
                convertedAmount = amount / EUR;
            }

            Console.WriteLine("Sonuç: " + convertedAmount);
            return convertedAmount;
        }

        // Lüks Oda Hesaplaması
        public static int LuxuyCalc(int room, int days)
        {
            int finalAmount = 0;

            // Kraliyet
            if (room == 1)
            {
                finalAmount = 500 * days;
            }
            else
            {
                finalAmount = 400 * days;
            }
            return (finalAmount);
        }

        // Mid Level Oda Hesaplamaası
        public static void MidLevelRoomCalc(int room, int days)
        {
            float finalAmount = 0;

            // Orta Lüks
            if (room == 1)
            {
                finalAmount = 300 * days;

                if (days >= 7)
                {
                    finalAmount *= 0.8f;
                }
            }

            else
            {
                finalAmount = 200 * days;

                if (days >= 7)
                {
                    finalAmount *= 0.9f;
                }
            }

            Console.WriteLine("Nihai tutar: " + finalAmount);
        }

        // Hocamızın Fonksiyonları + Yeni Case
        public static int BireyselHesap(int gelir, string sgk, int tutar)
        {
            if (sgk == "Bağkur" && gelir > 40000)
            {
                tutar += tutar * 4 / 100;
                return tutar;
            }
            else
            {
                tutar += tutar * 6 / 100;
                return tutar;
            }
        }

        public static void Aylik(int kreditutar)
        {
            Console.WriteLine("Ödemeyi kaç aya bölmek istersiniz: ");
            int ay = Convert.ToInt32(Console.ReadLine());

            double aylik = kreditutar / ay;
            Console.WriteLine("Ödemeniz gereken aylık tutar: " + aylik);
        }

        public static void AnaMenu()
        {
            try
            {
                Console.WriteLine("B - Bireysel Kredi");
                Console.WriteLine("K - Konut kredisi");
                char durum = Convert.ToChar(Console.ReadLine());

                switch (durum)
                {
                    case 'B':
                        Console.WriteLine("Gelirinizi girin: ");
                        int gelir = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Sgk durumunu girin: ");
                        string sgk = Console.ReadLine();

                        Console.WriteLine("Kredi tutarını girin: ");
                        int tutar = Convert.ToInt32(Console.ReadLine());

                        int KrediTutar = BireyselHesap(gelir, sgk, tutar);
                        Console.WriteLine("Ödemeniz gereken kredi tutarı: " + KrediTutar);

                        Aylik(KrediTutar);
                        break;

                    case 'K':
                        Console.WriteLine("Yaşınızı girin: ");
                        int yas = Convert.ToInt32(Console.ReadLine());

                        // 1. Metot
                        double krediSonuc = KonutKrediHesapla(yas);
                        Console.WriteLine("Hesaplanan faizli kredi tutarı: " + krediSonuc);

                        if (krediSonuc > 0)
                        {
                            // 2. Metot
                            double yillikOdeme = YillikOdemeHesapla(krediSonuc);
                            Console.WriteLine("Yıllık ödeme tutarı: " + yillikOdeme);

                            // 3. Metot
                            OtvHesaplaVeYazdir(yillikOdeme);
                        }
                        break;
                }
            }

            catch
            {
                Console.WriteLine("Bir hata meydana geldi.");
            }

            finally
            {
                Console.WriteLine("\n");
                Console.WriteLine("Sayfamızı ziyaret ettiğiniz için teşekkür ederiz.");
            }
        }


        // Yaşa göre faiz hesabı - 1. metot
        public static double KonutKrediHesapla(int yas)
        {
            if (yas >= 65)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Kredi tutarını girin: ");
                double tutar = Convert.ToDouble(Console.ReadLine());
                return tutar * 1.04;
            }
        }

        // Yıllık ödeme hesabı - 2. metot
        public static double YillikOdemeHesapla(double faizliTutar)
        {
            return faizliTutar;
        }

        // Ötv hesabı - 3. metot
        public static void OtvHesaplaVeYazdir(double miktar)
        {
            double otv = miktar * 0.20;
            Console.WriteLine("Hesaplanan ÖTV tutarı: " + otv);
        }


        // ALG 5 Fonksiyonları
        public static double GetItemPrice(int userInput)
        {
            double price = 0;

            if (userInput == 1)
            {
                price = 1000;
            }
            else if (userInput == 2)
            {
                price = 600;
            }
            else if (userInput == 3)
            {
                price = 350;
            }

            return price;
        }

        public static bool PotentiallyNewPurchase()
        {
            Console.WriteLine("Alışverişe devam etmek istiyor musunuz (E/H): ");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'H' || c == 'h')
            {
                Console.WriteLine("Bizi tercih ettiğiniz için teşekkür eder, sizleri tekrar görmeyi bekleriz.");
                return false;
            }

            return true;
        }

        public static void WelcomeScreen()
        {
            Console.WriteLine("E-ticaret platformumuza hoş geldiniz! Alışveriş için seçiminizi yapın.");
            Console.WriteLine("1 - Pantolon (1000 TL)");
            Console.WriteLine("2 - Etek (600 TL)");
            Console.WriteLine("3 - Kravat (350 TL)");
        }


        // ALG 6 Fonksiyonları
        public static double BigScreenNewPrice(double price)
        {
            double initialTotal = price *= 1.1d;

            Console.WriteLine($"TV için ekran boyutuna göre zamlı tutar şimdilik {initialTotal} olarak hesaplandı.");

            return initialTotal;
        }

        public static double SmallScreenNewPrice(double price)
        {
            double initialTotal = price *= 0.9d;

            Console.WriteLine($"TV için ekran boyutuna göre indirimli tutar şimdilik {initialTotal} olarak hesaplandı. Diğer vergileri de eklemekteyiz.");

            return initialTotal;
        }

        public static double CalculateAdditionalTax(double otvAddedAmount)
        {
            double finalTaxedAmount = otvAddedAmount * 1.075d;

            Console.WriteLine($"Vergiler sonrasında oluşan nihai tutar: {finalTaxedAmount}");

            return finalTaxedAmount;
        }

        public static double CheckMembershipAndDisplayFinalPrice(double finalTaxedAmount)
        {
            double finalMostPrice = 0;

            Console.WriteLine("Üyelik kaydınız var mıydı (E/H):");
            char membership = Convert.ToChar(Console.ReadLine());

            if (membership == 'E')
            {
                finalMostPrice = finalTaxedAmount * 0.95d;
                Console.WriteLine($"Üye indirimli nihai tutar: {finalMostPrice}");
                Console.WriteLine("Fişiniz yazdırılıyor...");
            }

            else
            {
                Console.WriteLine("İndirim avantajlarından yararlanmak için üye olmak ister misiniz (E/H): ");
                char pref = Convert.ToChar(Console.ReadLine());

                if (pref == 'E')
                {
                    finalMostPrice = finalTaxedAmount * 0.8d;
                    Console.WriteLine($"Yeni üyelere özel indirimli tutar: {finalMostPrice}");
                    Console.WriteLine("Fişiniz yazdırılıyor...");
                }
                else
                {
                    finalMostPrice = finalTaxedAmount;
                    Console.WriteLine($"Ödenecek toplam tutar: {finalMostPrice}");
                    Console.WriteLine("Fişiniz yazdırılıyor...");
                }
            }

            return finalMostPrice;
        }



        /* -------------------------------- MAIN -------------------------------- */
        static void Main(string[] args)
        {
            // ALG 1
            /*
            Console.WriteLine("Karesini hesaplatmak istediğiniz sayı: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç: " + SquareCalc(n));
            */


            // ALG 2
            /*
            Console.WriteLine("Kullanıcı adınız: ");
            string nameParam = Console.ReadLine();

            Console.WriteLine("Şifreniz: ");
            string pswParam = Console.ReadLine();

            CredCheck(nameParam, pswParam);
            */


            // ALG 3
            /* 
            Console.WriteLine("Döviz almak istediğiniz TL tutar: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Para birimi (USD/EUR): ");
            string currency = Console.ReadLine();

            ForeignExchange(amount, currency);
            */


            // ALG 4
            /*
            Console.WriteLine("Ne tür bir oda tercih edersiniz?");
            Console.WriteLine("1 - Lüks Odalar");
            Console.WriteLine("2 - Orta Kademedeki Odalar");
            Console.WriteLine("3 - Ekonomik Odalar");
            int userPref = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç gece kalmayı düşünüyorsunuz: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            switch (userPref)
            {
                case 1:
                    Console.WriteLine("Kraliyet Odaları için 1, VIP Odalar için 2 yazın: ");
                    int roomPref = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(LuxuyCalc(roomPref, duration));
                    break;


                case 2:
                    Console.WriteLine("Orta Lüks Odalar için 1, Orta Ekonomi Odalar için 2 yazın: ");
                    int roomPref2 = Convert.ToInt32(Console.ReadLine());

                    MidLevelRoomCalc(roomPref2, duration);
                    break;


                case 3:
                    break;


                default:
                    Console.WriteLine("Bir hata oluştu.");
                    break;
            }
            */

            // TRY-CATCH-FINALLY
            /*
            spawnHere:
            Console.WriteLine("Bankamıza hoş geldiniz.");

            AnaMenu();

            try
            {
                Console.WriteLine("Tekrar denemek ister misiniz? Evet için 1'i, hayır için 2'yi seçin: ");
                int repeatProcess = Convert.ToInt16(Console.ReadLine());

                if (repeatProcess == 1)
                {
                    goto spawnHere;
                }
                else
                {
                    Console.WriteLine("Tercihiniz kaydedilmiştir.");
                }
            }
            catch
            {
                Console.WriteLine("En kısa sürede tekrar bekleriz!");
            }
            */


            // ALG 5
            /*
            double total = 0;
            bool continueShopping = true;

            while (continueShopping)
            {
                WelcomeScreen();
                int userChoice = Convert.ToInt16(Console.ReadLine());

                total += GetItemPrice(userChoice);

                continueShopping = PotentiallyNewPurchase();
            }

            Console.WriteLine($"Ödenmesi gereken toplam tutar: {total}");
            */



            // ALG 6
            Console.WriteLine("Mağazamıza hoş geldiniz! Alışveriş için seçiminizi yapın.");
            Console.WriteLine("1 - TV");
            Console.WriteLine("2 - Bilgisayar");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                // TV
                case 1:
                    Console.WriteLine("TV'nizin etiket fiyatını girin: ");
                    double tvInitialPrice = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("HD TV'nizin ekran boyutunu girin: ");
                    int screenSize = Convert.ToInt32(Console.ReadLine());

                    double initialTotal = 0;

                    if (screenSize >= 50 && screenSize < 100)
                    {
                        initialTotal = BigScreenNewPrice(tvInitialPrice);
                    }
                    else if (screenSize >= 20 && screenSize < 50)
                    {
                        initialTotal = SmallScreenNewPrice(tvInitialPrice);
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir ekran boyutu girmediniz.");
                    }

                    double otvAddedAmount = initialTotal *= 1.18d;

                    double finalTaxedAmount = CalculateAdditionalTax(otvAddedAmount);

                    CheckMembershipAndDisplayFinalPrice(finalTaxedAmount);

                    break;

                
                // Bilgisayar
                case 2:

                    break;


                default:
                    Console.WriteLine("Bir hata oluştu.");
                    break;
            }

        }
    }
}
