using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hangi aydayız? (1-12):");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hangi yarım küredeyiz? (K/G):");
            string yariküre = Console.ReadLine();

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine(yariküre == "K" ? "Kış" : "Yaz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine(yariküre == "K" ? "Ilkbahar" : "Sonbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine(yariküre == "K" ? "Yaz" : "Kış");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine(yariküre == "K" ? "Sonbahar" : "Ilkbahar");
                    break;
                default:
                    Console.WriteLine("Geçersiz ay.");
                    break;
            }
            Console.ReadLine();
            Main(args);
        }
    }
}
