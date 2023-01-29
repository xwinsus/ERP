using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2 
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaçıncı aydayız? (1-12):");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi yarım küredeyiz? (K/G):");
            string yarimKure = Console.ReadLine();

            if (ay >= 3 && ay <= 5 && yarimKure == "K")
            {
                Console.WriteLine("İlkbahar");
            }
            else if (ay >= 6 && ay <= 8 && yarimKure == "K")
            {
                Console.WriteLine("Yaz");
            }
            else if (ay >= 9 && ay <= 11 && yarimKure == "K")
            {
                Console.WriteLine("Sonbahar");
            }
            else if (ay == 12 || ay == 1 || ay == 2 && yarimKure == "K")
            {
                Console.WriteLine("Kış");
            }
            else if (ay >= 3 && ay <= 5 && yarimKure == "G")
            {
                Console.WriteLine("Sonbahar");
            }
            else if (ay >= 6 && ay <= 8 && yarimKure== "G")
            {
                Console.WriteLine("Kış");
            }
            else if (ay >= 9 && ay <= 11 && yarimKure == "G")
            {
                Console.WriteLine("İlkbahar");
            }
            else if (ay == 12 || ay == 1 || ay == 2 && yarimKure == "G")
            {
                Console.WriteLine("Yaz");
            }
            else
            {
                Console.WriteLine("Hatalı giriş. Lütfen tekrar deneyin.");
            }

            Console.ReadLine();
        }
    }
}