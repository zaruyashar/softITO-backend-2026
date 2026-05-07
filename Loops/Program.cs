using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ALG 1
            /*
            Console.WriteLine("başlangıç değerini giriniz");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş değerini  giriniz");
            int bitiş = Convert.ToInt32(Console.ReadLine());

            for (int sayac = i; sayac <= bitiş; sayac += 5)
            {
                if (sayac % 2 == 0)
                {

                    Console.WriteLine("çift degeri olan sayac : " + sayac);
                }
                else
                {
                    Console.WriteLine(" tek degeri olan sayac : " + sayac);
                }
            }
            */


            // ALG 2
            /* 
            double product = 1;

            for (int i = 20; i >= 10; i--)
            {
                product = product * i;
            }
            Console.WriteLine("Çarpım: " + product);
            */


            // ALG 3
            /*
            double factorial = 1;

            Console.WriteLine("Faktöriyelini hesaplatmak istediğiniz sayıyı girin (1 ile 10 arasında): ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            for(double i = userInput; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Cevap: " + factorial);
            */


            // ALG 4
            /*
            int posNumCount = 0;
            int negNumCount = 0;
            int zeroCount = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("10 adet tam sayı girin: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput < 0)
                {
                    negNumCount++;
                }
                else if (userInput > 0)
                {
                    posNumCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine("Pozitif sayı adedi: " + posNumCount);
            Console.WriteLine("Negatif sayı adedi: " + negNumCount);
            Console.WriteLine("Sıfır (0) adedi: " + zeroCount);
            */


            // ALG 5
            /*
            int total = 0;
            int specialNumCount = 0;

            Console.WriteLine("Bir pozitif tam sayı girin: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= counter; i++)
            {
                if (i % 7 == 0)
                {
                    total = total + i;
                    specialNumCount++;
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("7'nin katları olan sayıların adedi: " + specialNumCount);
            Console.WriteLine("7'nin katları olan sayıların toplamı: " + total);
            */

            // ALG 6
            /*
            int hundredsCount = 0;
            double othersTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir tam sayı girin: ");
                long userInput = Convert.ToInt64(Console.ReadLine());

                if (userInput > 99 && userInput < 1000)
                {
                    hundredsCount++;
                }
                else
                {
                    othersTotal = othersTotal + userInput;
                }
            }
            Console.WriteLine("3 basamaklı sayı adedi: " + hundredsCount);
            Console.WriteLine("Kalan sayıların toplamı: " + othersTotal);
            */


            // ALG 7
            /*
            int oddTotal = 0;
            int evenTotal = 0;
            int counter = 0;

            Console.WriteLine("Bir pozitif tam sayı girin: ");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                if (i % 2 == 1)
                {
                    oddTotal = oddTotal + i;
                }
                else
                {
                    evenTotal = evenTotal + i;
                }
            }
            Console.WriteLine("Tek sayılar toplamı: " + oddTotal);
            Console.WriteLine("Çift sayılar toplamı: " + evenTotal);
            */


            // ALG 8
            /*
            long largest = 0;
            long smallest = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir tam sayı girin: ");
                long userInput = Convert.ToInt64(Console.ReadLine());

                if (userInput > largest)
                {
                    largest = userInput;
                }
                else if (userInput < smallest)
                {
                    smallest = userInput;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Girdiğiniz sayılardan en büyüğü: " + largest);
            Console.WriteLine("Girdiğiniz sayılardan en küçüğü: " + smallest);
            */



            // ALG 9
            /*
            Console.WriteLine("1'den 9'a kadar bir rakam girin: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                int result = i * (i + 1);
                Console.WriteLine(i + " * " + (i + 1) + " = " + result);
            }
            Console.WriteLine("İşleminiz tamamlandı.");
            */



            // ALG 10
            /*
            int fiveTimesTotal = 0;
            int otherEvenTotal = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int rnd = random.Next(1, 100);
                Console.WriteLine(rnd);

                if (rnd % 5 == 0)
                {
                    fiveTimesTotal = fiveTimesTotal + rnd;
                }

                else if (rnd %5 != 0 && rnd % 2 == 0)
                {
                    otherEvenTotal = otherEvenTotal + rnd;
                }
            }
            Console.WriteLine("Beşin katları olan sayıların toplamı: " + fiveTimesTotal);
            Console.WriteLine("Beşin katı olmayan çift sayıların toplamı: " + otherEvenTotal);
            */


            // ALG 11
            /*
            int divisibleCount = 0;

            Console.WriteLine("1 ile 25 arasında bir tam sayı girin: ");
            int divider = Convert.ToInt32(Console.ReadLine());

            for (int i = 75; i <= 300; i++)
            {
                if (i % divider == 0)
                {
                    Console.WriteLine(i);
                    divisibleCount++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("75 ile 300 arasındaki sayılardan girdiğiniz sayıya kalansız bölünenlerin adedi: " + divisibleCount);
            */


            // ALG 12
            /*
            float totalAmount = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Mal fiyatı: ");
                float initialAmount = Convert.ToSingle(Console.ReadLine());

                if (initialAmount < 50)
                {
                    initialAmount = initialAmount * 1.03f;
                    totalAmount = totalAmount + initialAmount;
                    Console.WriteLine("Komisyon uygulanmış fiyat: " + initialAmount);
                    Console.WriteLine("\n");
                }
                else if (initialAmount >= 50)
                {
                    initialAmount = initialAmount * 1.02f;
                    totalAmount = totalAmount + initialAmount;
                    Console.WriteLine("Komisyon uygulanmış fiyat: " + initialAmount);
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("5 ürün için toplam komisyonlu fiyat: " + totalAmount);
            */


            // ALG 13
            /*
            int result = 1;

            Console.WriteLine("Taban sayısını girin: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üs değerini girin: ");
            int exponential = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < exponential; i++)
            {
                result = result * baseNumber;
            }
            Console.WriteLine("Sonuç: " + result);
            */


            // ALG 14
            /*
            int total = 0;
            int fifthNum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir tam sayı girin: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                total = total + userInput;

                if (i == 4)
                {
                    fifthNum = userInput;
                }
            }

            float result = total / fifthNum;
            Console.WriteLine("Sonuç: " + result);
            */


            // ALG 15
            /*
            int bacteriaCount = 1;

            Console.WriteLine("Bakteri sayısı 4 dk.da bir ikiye katlanır.");
            Console.WriteLine("Başlangıçtaki bakteri sayısı: 1");

            for (int i = 0; i < 15; i++)
            {
                bacteriaCount = bacteriaCount * 2;
            }

            Console.WriteLine("Bir sa. sonra oluşacak kolonideki bakteri sayısı: " + bacteriaCount);
            */


            // ALG 16
            /*
            Console.WriteLine("Bir tam sayı girin: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userInput; i++)
            {
                for (int j = 1; j < userInput + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            */


            // MANTIĞI DÜZELTİLECEK
            /*
            Console.WriteLine("1'den 9'a kadar bir rakam girin: "); 
            int userInput = Convert.ToInt32(Console.ReadLine()); 
            
            for (int i = 1; i < userInput; i++)
            {
                for (int j = i + 1; j <= userInput; j++)
                {
                    int result = i * j;

                    Console.WriteLine(i + "*" + j + "=" + result);
                }
            }
            Console.WriteLine("İşleminiz tamamlandı.");
            */


            // ALG 17
            /*
            int counter = 1;
            int oddTotal = 0;

            while (counter <= 10)
            {
                if (counter % 2 == 1)
                {
                    oddTotal = oddTotal + counter;
                    Console.WriteLine("Toplama dahil edilen tek sayı: " + counter);
                }
                counter++;
            }
            Console.WriteLine("0-10 aralığındaki tek sayıların toplamı: " + oddTotal);
            */


            // ALG 18
            /*
            int year = 2016;
            float rent = 30000;

            while (year <= 2026)
            {
                rent *= 1.25f;
                year++;
            }
            Console.WriteLine("2026 yılındaki kira: " + rent);
            */



            // ALG 19
            /*
            int total = 0;
            bool status = true;

            while (status)
            {
                Console.WriteLine("Bir tam sayı girin: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput < 0)
                {
                    status = false;
                }
                else
                {
                    total += userInput;
                }
            }
            Console.WriteLine("Girilen pozitif sayıların toplamı: " + total);
            */


            // ALG 20
            string finalResult = "";
            bool status = true;

            while (status)
            {
                Console.WriteLine("Bir harf girin: ");
                char c = Convert.ToChar(Console.ReadLine());

                if (c == 'i' || c == 'İ')
                {
                    status = false;
                }

                finalResult += c;
            }
            Console.WriteLine("Girdiğiniz karakterler: " + finalResult);
            


            // ALG 21
            /*
            int grandTotal = 0;
            Random random = new Random();

            while (grandTotal <= 1000)
            {
                int rnd = random.Next(1, 101);

                grandTotal += rnd;

                Console.WriteLine(rnd);
            }
            Console.WriteLine("Toplam: " + grandTotal);
            */


        }
    }
}
