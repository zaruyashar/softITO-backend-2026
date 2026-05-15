using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        // ALG 1 Fonksiyonları
        /*
        public static float CalculateGpa(int sinav1, int sinav2)
        {
            float total = sinav1 + sinav2;
            return total / 2f;
        }

        public static float CalculateGpa(int sinav1, int sinav2, int proje)
        {
            float total = sinav1 + sinav2 + proje;
            return total / 3f;
        }

        public static float CalculateGpa(int vize, int final, int projeNot, int odev)
        {
            float total = vize + final + projeNot + odev;
            return total / 4f;
        }
        */


        // ALG 2 Fonksiyonları
        /*
        public static int GetUserInput()
        {
            Console.WriteLine("Sabit telefon hattı için 1, cep telefonu için 2 yazın: ");
            int userPhoneType = Convert.ToInt32(Console.ReadLine());

            return userPhoneType;
        }

        public static double CalculateBasePay(double landlineDefaultPrice)
        {
            double basePayPlusVAT = landlineDefaultPrice * 1.18d;
            return basePayPlusVAT;
        }

        public static double AddTelecommunicationTax(double basePayPlusVAT)
        {
            double telecommsTaxAddition = basePayPlusVAT * 1.04d;
            return telecommsTaxAddition;
        }

        public static void PrintCase1Result(double telecommsTaxAddition)
        {
            Console.WriteLine($"Ödenmesi gereken nihai sabit hat fatura tutarı: {telecommsTaxAddition}");
        }

        public static bool CheckSubscriptionStatus()
        {
            bool SubscriptionStatus = false;

            Console.WriteLine("Aktif bir aboneliğiniz mevcut mu (E/H): ");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'E')
            {
                return SubscriptionStatus = true;
            }
            else
            {
                return SubscriptionStatus;
            }
        }

        public static int CheckServiceProvider()
        {
            Console.WriteLine("Telekommünikasyon hizmetini hangi firmadan alıyorsunuz?");
            Console.WriteLine("1 - Türk Telekom");
            Console.WriteLine("2 - TürkNet");
            Console.WriteLine("3 - Turkcell");
            Console.WriteLine("4 - Vodafone");
            int userProvider = Convert.ToInt16(Console.ReadLine());

            return userProvider;
        }
        */






        /* ------------------------------- MAIN ----------------------------- */
        static void Main(string[] args)
        {
            // ALG 1 - Method Overloading
            /*
            Console.WriteLine("Eğitim grubu:");
            Console.WriteLine("1 - İlkokul");
            Console.WriteLine("2 - Lise");
            Console.WriteLine("3 - Üniversite");
            int userGrade = Convert.ToInt16(Console.ReadLine());

            // Array için döngü sayısını belirleme
            int i = 0;
            switch (userGrade)
            {
                case 1:
                    i = 2;
                    break;

                case 2:
                    i = 3; 
                    break;

                case 3:
                    i = 4;
                    break;
            }


            // Notları dizide tutma
            int[] arr = new int[i];

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"{j+1}. not: ");
                int userAddedVal = Convert.ToInt32(Console.ReadLine());

                arr[j] = userAddedVal;
            }


            // Girilen verilere göre ortalamayı hesaplama
            float finalGpa = 0;

            switch (userGrade)
            {
                case 1:
                    finalGpa = CalculateGpa(arr[0], arr[1]);
                    break;

                case 2:
                    finalGpa = CalculateGpa(arr[0], arr[1], arr[2]);
                    break;

                case 3:
                    finalGpa = CalculateGpa(arr[0], arr[1], arr[2], arr[3]);
                    break;
            }

            Console.WriteLine($"Hesaplanan not ortalaması: {finalGpa}");
            */


            // ALG 2
            /*
            int userPhoneType = GetUserInput();

            try
            {
                switch (userPhoneType)
                {
                    // Sabit hat
                    case 1:
                        Console.WriteLine("Aktif bir aboneliğiniz mevcut mu (E/H): ");
                        char c = Convert.ToChar(Console.ReadLine());

                        double landlineDefaultPrice = 500;
                        double basePayPlusVAT = 0;
                        double telecommsTaxAddition = 0;

                        if (c == 'E')
                        {
                            basePayPlusVAT = CalculateBasePay(landlineDefaultPrice);

                            telecommsTaxAddition = AddTelecommunicationTax(basePayPlusVAT);

                            PrintCase1Result(telecommsTaxAddition);
                        }
                        else
                        {
                            PrintCase1Result(landlineDefaultPrice);
                        }
                        break;


                    // Mobil hat
                    case 2:
                        bool subscriptionStatus = false;
                        double mobileDefaultPrice = 300;
                        int serviceProviderName = 0;

                        subscriptionStatus = CheckSubscriptionStatus();

                        if (subscriptionStatus == true)
                        {
                            mobileDefaultPrice += 100; // paket ücreti 100 tl
                        }

                        serviceProviderName = CheckServiceProvider();

                        if (serviceProviderName == 1)
                        {
                            // mobileDefaultPrice üzerinden %3 indirim yap
                            mobileDefaultPrice = mobileDefaultPrice * 0.97d;
                        }

                        PrintCase1Result(mobileDefaultPrice);

                        break;
                }
            }
            catch
            {
                Console.WriteLine("Bir hata meydana geldi.");
            }
            */


            // ALG 3
            /*
            Student student = new Student();

            Console.WriteLine("Öğrencinin numarası: ");
            student.OgrenciNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrencinin adı: ");
            student.FullName = Console.ReadLine();

            Console.WriteLine("Kazanılan kredi sayısı: ");
            student.DersKredisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vize notu: ");
            student.VizeNotu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notu: ");
            student.FinalNotu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bütünleme notu: ");
            student.ButunlemeNotu = Convert.ToInt32(Console.ReadLine());

            
            if((student.VizeNotu + student.FinalNotu) / 2 > 50)
            {
                Console.WriteLine("Tebrikler, geçtiniz!");
            }
            else
            {
                if (student.ButunlemeNotu >= 50)
                {
                    Console.WriteLine("Tebrikler, geçtiniz!");
                }
                else
                {
                    Console.WriteLine("Maalesef kaldınız.");
                }
            }
            */


            // ALG 4
            StandartMusteri stMusteri = new StandartMusteri();

            stMusteri.MusteriNo = 1;
            stMusteri.AdSoyadi = "Ahmet Yılmaz";
            stMusteri.AktifMi = true;
            stMusteri.Bakiye = 100m; // decimal
            stMusteri.UcretsizKargosuVarMi = false;

            stMusteri.BakiyeYukle(50m);

            Console.WriteLine(stMusteri.AdSoyadi + " - Guncel Bakiye: " + stMusteri.Bakiye);

            stMusteri.UyeligiDondur();
            Console.WriteLine("Aktiflik Durumu: " + stMusteri.AktifMi);

            Console.WriteLine("-------------------------");

            VipMusteri vipMusteri = new VipMusteri();
            vipMusteri.MusteriNo = 2;
            vipMusteri.AdSoyadi = "Ayça Demir";
            vipMusteri.AktifMi = true;
            vipMusteri.Bakiye = 5000m;
            vipMusteri.EkstraIndirimOrani = 0.20m;
            vipMusteri.OzelDanismanAdSoyad = "Güliz Can";

            decimal odenecekTutar = vipMusteri.IndirimliTutarHesapla(1000m);

            Console.WriteLine(vipMusteri.AdSoyadi + " - Ozel Danisman: " + vipMusteri.OzelDanismanAdSoyad);
            Console.WriteLine("1000 TL sepet için indirimli tutar: " + odenecekTutar);


            Console.ReadLine();









        }
    }
}
