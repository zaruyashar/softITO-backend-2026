using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ALG 1
            /*
            int[] arr = { 5, 10, 15, 20, 25 };
            int total = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine($"Toplam: {total}");
            */


            // ALG 2
            /*
            string[] arr = { "box", "muay thai", "wrestling" };

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Sport: " + arr[i]);
            }
            Console.ReadLine();
            */


            // ALG 3
            /*
            int[] arr = new int[7];
            int grandTotal = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + ". tam sayıyı girin: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                grandTotal += arr[i];
            }

            float result = grandTotal / arr.Length;
            Console.WriteLine($"Girilen değerlerin ortalaması: {result}");
            */


            // ALG 4
            /*
            int[] arr = new int[5];
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + ". tam sayıyı girin: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine($"Tek sayıların adedi: {oddCount}");
            Console.WriteLine($"Çift sayıların adedi: {evenCount}");
            */


            // ALG 5
            /*
            int[] arr = new int[10];
            int timesTwoAndNineCount = 0;
            int othersTotal = 0;

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int rnd = random.Next(1, 51);
                Console.WriteLine(rnd);

                if (rnd % 2 == 0 && rnd % 9 == 0)
                {
                    timesTwoAndNineCount++;
                }
                else
                {
                    othersTotal += rnd;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"İki ve dokuzun katı olan sayıların adedi: {timesTwoAndNineCount}");
            Console.WriteLine($"Kalan sayıların toplamı: {othersTotal}");
            */


            // ALG 6
            /*
            string[] citiesList = { "samsun", "amasya", "tokat", "sivas", "erzurum" };
            bool status = false;
            string userInput = "";

            do
            {
                Console.WriteLine("Bir şehir tahmini girin: ");
                userInput = Console.ReadLine().ToLower();

                for (int i = 0; i < citiesList.Length; i++)
                {
                    if (userInput == citiesList[i])
                    {
                        status = true;
                        Console.WriteLine("Doğru tahmin ettiniz, tebrikler!");
                        break;
                    }
                }
            }
            while (!status);

            // alternative 1:
            do
            {
                if (metin == dizi[sayac])
                {
                    Console.WriteLine("Girdiğiniz isim dizide " + sayac + " .Sırada");
                    break;
                }
                else
                {
                    if (sayac == dizi.Length - 1)
                    {
                        Console.Write("Yanlış isim girdiniz.");
                        break;
                    }
                }
                sayac++;
            }
            while (sayac < 11);
            Console.ReadLine();

            // alternative 2:
            bool bulundu = false;
            string[] sehirler = { "istanbul", "izmir", "ankara", "kars", "giresun" };
        menu:
            Console.WriteLine("bir şehir giriniz: ");
            string sehir = Console.ReadLine();

            foreach (string s in sehirler)
            {
                if (sehir == s)
                {
                    Console.WriteLine("girilen şehir bulundu: " + sehir);
                    bulundu = true;
                    break;
                }

            }
            if (bulundu != true)
            {
                Console.WriteLine("sehir bulunamadı, tekrar deneyiniz: ");
                goto menu;
            }
            Console.ReadLine();
            */


            // ALG 8
            /*
            int[] arr = new int[10];
            int tenFoldCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Bir tam sayı girin: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput % 10 == 0)
                {
                    tenFoldCount++;
                }
            }
            Console.WriteLine($"Girdiğiniz sayılardan 10 ve katlarında olanların adedi: {tenFoldCount}");
            */



            // ALG 9
            /*
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Negatif veya pozitif bir tam sayı girin: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                arr[i] = userInput;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Pozitif dizi: [" + string.Join(", ", arr) + "]");
            */


            // ALG 10
            /*
            int[] arr = new int[10];
            Random random = new Random();
            int rnd;
            bool unique;

            for (int i = 0; i < arr.Length; i++)
            {
                do
                {
                    rnd = random.Next(1, 20);
                    unique = true;

                    for (int j = 0; j < i; j++)
                    {
                        if (arr[j] == rnd)
                        {
                            unique = false;
                            break;
                        }
                    }
                } while (!unique);

                arr[i] = rnd;
            }
            Console.WriteLine("Benzersiz elemanlı dizi: [" + string.Join(", ", arr) + "]");

            // alternative 1:
            int[] dizi = new int[10];
            Random rast = new Random();
            Console.WriteLine("dizi benzersiz sayılarla dolduruluyor...");

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rast.Next(1, 11);
                for (int y = 0; y < i; y++)
                {
                    if (dizi[y] == dizi[i])
                    {
                        i--;
                        break;
                    }
                }
            }
            Console.WriteLine("dizi dolduruldu ekrana yazılıyor...");
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(dizi[a]);
            }

            Console.ReadKey();

            // alternative 2:
            Random rnd = new Random();
            int[] sayilar = new int[10];

            for (int i = 0; i < sayilar.Length; i++)
            {
                int randomSayi = rnd.Next(1, 11);
                bool varMi = false;

                foreach (int sayi in sayilar)
                {
                    if (sayi == randomSayi)
                    {
                        varMi = true;
                        break;
                    }
                }
                if (varMi)
                {
                    i--;
                }
                else
                {
                    sayilar[i] = randomSayi;
                }
            }

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
            */


            // ALG 11
            /*
            double[] arr = new double[10];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i+1) + ". ürünün fiyatı: ");
                double price = Convert.ToDouble(Console.ReadLine());
                 
                if (price >= 10 && price <= 99)
                {
                    arr[i] = price * 1.2f;
                    Console.WriteLine("Zamlı fiyat: " + arr[i]);
                    Console.WriteLine("\n");
                }
                else if (price >= 100 && price <= 999)
                {
                    arr[i] = price * 1.5f;
                    Console.WriteLine("Zamlı fiyat: " + arr[i]);
                    Console.WriteLine("\n");
                }
                else
                {
                    arr[i] = price;
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine("Nihai fiyatlar: [" + string.Join(", ", arr) + "]");
            */


            // ALG 12
            /*
            int[] arr = new int[5];
            int grandTotal = 0;
            int squaresTotal = 0;
            int numSquare = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Bir tam sayı girin: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                numSquare = userInput * userInput;

                arr[i] = numSquare;

                grandTotal += userInput;

                squaresTotal += numSquare;
            }
            Console.WriteLine("Kareler dizisi: [" + string.Join(", ", arr) + "]");
            Console.WriteLine($"Sayılar toplamı: {grandTotal}");
            Console.WriteLine($"Kareler toplamı: {squaresTotal}");
            */


            // HW
            /*
            // Made for simple use cases. Current 'for' loop algorithm inefficient for larger user inputs (like '1000000').
            bool IsPrime = true;

            // Num to be checked:
            Console.WriteLine("Pozitif bir tam sayı girin: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // If num == 1 or less, never make it to the 'for' loop:
            if (userInput <= 1)
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir veya negatif bir sayıdır.");
                IsPrime = false;
            }

            // If (num % anything other than (2 & num)) produces a result:
            for (int i = 2; i < userInput; i++)
            {
                if (userInput % i == 0)
                {
                    IsPrime = false;
                    Console.WriteLine("Girdiğiniz sayı asal değildir.");
                    break;
                }
            }

            // If num is indeed a prime num:
            if (IsPrime is true)
            {
                Console.WriteLine("Girdiğiniz sayı asaldır.");
            }
            */
            


        }
    }
}
