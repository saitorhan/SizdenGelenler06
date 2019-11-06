using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizdenGelenler06
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam = 0;

            sayiGirisi:
            Console.WriteLine("Test Edilecek Sayıyı Giriniz:");
            string okunan = Console.ReadLine();

            // string sayi dönüşüm işlemleri için https://youtu.be/IjuDU5AMTOI linkinden ilgili videomu izleyebilirsiniz. 
            if (!Int32.TryParse(okunan, out sayi) || sayi < 0)
            {
                Console.WriteLine("Girilen değer doğru formatta değil.");
                goto sayiGirisi;
            }

            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                }
            }

            if (sayi == toplam)
            {
                Console.WriteLine("{0} Sayısı Mükemmel Sayıdır", sayi);
            }
            else
            {
                Console.WriteLine("{0} Sayısı Mükemmel Sayı Değildir", sayi);
            }

            Console.ReadLine();
        }
    }
}
