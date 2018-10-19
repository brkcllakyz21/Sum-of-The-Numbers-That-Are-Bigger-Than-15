using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_The_Numbers_That_Are_Bigger_Than15
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayaç = 0, toplam = 0, sayı = 0;

            while (sayaç < 20)
            {
                Console.Write("Sayıyı Giriniz = ");
                sayı = Convert.ToInt32(Console.ReadLine());
                if (sayı > 15)
                {
                    toplam += sayı;
                }
                sayaç += 1;
            }

            Console.WriteLine("Girdiğiniz sayılardan 15'den büyük olanlarının toplamı = " + toplam);

        }
    }
}
