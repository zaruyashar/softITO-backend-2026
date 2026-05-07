using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
        spawnHere:

            Console.WriteLine("Banka türünü seçin (rakamı girin).");
            Console.WriteLine("1 - Kamu Bankası");
            Console.WriteLine("2 - Özel Banka)");
            Console.WriteLine("3 - Yurt Dışı Bankaları");
            int selection1 = Convert.ToInt32(Console.ReadLine());

            switch (selection1)
            {
                case 1:
                    Console.WriteLine("Kredi türünü seçin (harf girin).");
                    Console.WriteLine("B - Bireysel Kredi");
                    Console.WriteLine("K - Kobi Kredisi)");
                    char userPreference = Convert.ToChar(Console.ReadLine());
                    userPreference = char.ToUpper(userPreference);

                    Console.WriteLine("Almak istediğiniz tutarı girin: ");
                    double desiredCredit = Convert.ToDouble(Console.ReadLine());

                    if (userPreference == 'B')
                    {
                        Console.WriteLine("Meslek kategoriniz 'beyaz yaka' ise 'X', 'mavi yaka' ise 'Y' yazın:");
                        char userJobCategory = Convert.ToChar(Console.ReadLine());
                        userJobCategory = char.ToUpper(userJobCategory);

                        // Faiz Tutarı = Anapara x Faiz Oranı x Vade

                        switch (userJobCategory)
                        {
                            case 'X':
                                float interestRate = 4;
                                int termInMonths = 6;

                                double totalCreditWithInterest = desiredCredit * (1 + (interestRate / 100) * termInMonths);

                                Console.WriteLine("Faizli Toplam Kredi Tutarı: " + totalCreditWithInterest);
                                Console.WriteLine("Aylık ödemeniz gereken miktar: " + totalCreditWithInterest / 12);
                                break;

                            case 'Y':
                                float interestRate2 = 2.55f;
                                int termInMonths2 = 10;

                                double totalCreditWithInterest2 = desiredCredit * (1 + (interestRate2 / 100) * termInMonths2);

                                Console.WriteLine("Faizli Toplam Kredi Tutarı: " + totalCreditWithInterest2);
                                Console.WriteLine("Aylık ödemeniz gereken miktar: " + totalCreditWithInterest2 / 12);

                                break;
                        }

                    }
                    else if (userPreference == 'K')
                    {
                        Console.WriteLine("Şirketinizde kaç çalışan var: ");
                        int employeeCount = Convert.ToInt32(Console.ReadLine());

                        if (employeeCount < 10)
                        {
                            float interestRate = 4;
                            int termInMonths = 12;

                            // toplam tutarı hesapla + hem aylık hem toplam ödemeyi yazdır
                            double totalCreditWithInterest = desiredCredit * (1 + (interestRate / 100) * termInMonths);

                            Console.WriteLine("Faizli Toplam Kredi Tutarı: " + totalCreditWithInterest);
                            Console.WriteLine("Aylık ödemeniz gereken miktar: " + totalCreditWithInterest / 12);
                        }

                        else if (employeeCount >= 10 && employeeCount < 30)
                        {
                            float interestRate = 2;
                            int termInMonths = 18;

                            double totalCreditWithInterest = desiredCredit * (1 + (interestRate / 100) * termInMonths);

                            Console.WriteLine("Faizli Toplam Kredi Tutarı: " + totalCreditWithInterest);
                            Console.WriteLine("Aylık ödemeniz gereken miktar: " + totalCreditWithInterest / 12);
                        }
                        else if (employeeCount >= 30 && employeeCount < 50)
                        {
                            float interestRate = 1;
                            int termInMonths = 24;

                            double totalCreditWithInterest = desiredCredit * (1 + (interestRate / 100) * termInMonths);

                            Console.WriteLine("Faizli Toplam Kredi Tutarı: " + totalCreditWithInterest);
                            Console.WriteLine("Aylık ödemeniz gereken miktar: " + totalCreditWithInterest / 12);
                        }
                    }

                    break;


                case 2:
                    break;


                case 3:
                    break;


                default:
                    Console.WriteLine("Bir hata oluştu. Tekrar deneyin.");
                    goto spawnHere;
            }
        }
    }
}

