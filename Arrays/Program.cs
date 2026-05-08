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


        }
    }
}
