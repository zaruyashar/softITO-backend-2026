using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Züccaciye
{
    internal class Program
    {
        static void Main(string[] args)
        {
        spawnHere:

            Console.WriteLine("Bir züccaciye ürün kategorisi seçin (rakamı girin).");
            Console.WriteLine("1 (Mutfak Gereçleri)");
            Console.WriteLine("2 (Banyo Gereçleri)");
            Console.WriteLine("3 (Aksesuar)");
            int selection1 = Convert.ToInt32(Console.ReadLine());

            switch (selection1)
            {
                case 1:
                    Console.WriteLine("Ürün fiyatını girin: ");
                    float price = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Defolu ürün tercih ederseniz daha uyguna alışveriş yapabilirsiniz. Ürün defolu olsun mu (E/H): ");

                    char userPreference = Convert.ToChar(Console.ReadLine());
                    userPreference = char.ToUpper(userPreference);

                    if (userPreference == 'E')
                    {
                        price = price * 0.7f;
                        Console.WriteLine("Ödemeniz gereken tutar: " + price);
                    }
                    else
                    {
                        price = price * 0.97f;
                        Console.WriteLine("Ödemeniz gereken tutar: " + price);
                    }
                    break;


                case 2:
                    Console.WriteLine("Ürün türünü seçin.");
                    Console.WriteLine("Seramik için: S");
                    Console.WriteLine("Porselen için: P");
                    Console.WriteLine("Plastik için: K");

                    char userPreference2 = Convert.ToChar(Console.ReadLine());
                    userPreference2 = char.ToUpper(userPreference2);

                    Console.WriteLine("Ürünün markasını girin: ");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Ürün fiyatını girin: ");
                    float price2 = Convert.ToSingle(Console.ReadLine());

                    if (userPreference2 == 'S')
                    {
                        if (brand == "Karaca" || brand == "HM")
                        {
                            price2 = price2 * 0.95f;
                            Console.WriteLine("Ödemeniz gereken %5 indirimli tutar: " + price2);
                        }
                        else
                        {
                            Console.WriteLine("Hediye olarak size bir de sabun gönderilecektir.");
                        }
                    }

                    else if (userPreference2 == 'P')
                    {
                        Console.WriteLine("Cam ürününüz desenli mi (E/H): ");
                        char userPreference3 = Convert.ToChar(Console.ReadLine());
                        userPreference3 = char.ToUpper(userPreference3);

                        if (userPreference2 == 'E')
                        {
                            int prodPrice = 2000;
                            Console.WriteLine("Ödemeniz gereken tutar: " + prodPrice);
                        }
                        else
                        {
                            int prodPrice = 1500;
                            Console.WriteLine("Ödemeniz gereken tutar: " + prodPrice);
                        }
                    }

                    else if (userPreference2 == 'K')
                    {
                        price2 = price2 * 0.975f;
                        Console.WriteLine("Ödemeniz gereken tutar: " + price2);
                    }
                    break;


                case 3:
                    Console.WriteLine("Mağaza üyeliğiniz var mıydı (E/H): ");
                    char userPreference4 = Convert.ToChar(Console.ReadLine());
                    userPreference4 = char.ToUpper(userPreference4);

                    Console.WriteLine("Ürün fiyatını girin: ");
                    float price3 = Convert.ToSingle(Console.ReadLine());

                    if (userPreference4 == 'E')
                    {
                        float memberDiscountedAmount = price3 * 0.9f;
                        float finalAmount = memberDiscountedAmount * 0.98f;

                        Console.WriteLine("Üyelere özel sepet tutarınız: " + finalAmount);
                    }
                    else
                    {
                        // BURADAN DEVAM.
                        // ÜYELİK İSTER MİSİNİZ? E/H CEVABA GÖRE YAZ.
                        //aksesuar seçiminde mağaza üyeliği var mı diye sor  
                        // eğer yoksa kayıt yaptırır ise   ve fiyat üzerinden %7,5 indirim yap +200 hediye çeki ver
                        //eğer kayıt yaptırmazsa %1,5 kdv al fiyat üzerinden
                    }

                    break;


                default:
                    Console.WriteLine("Bir hata oluştu. Tekrar deneyin.");
                    goto spawnHere;
            }
        }
    }
}
