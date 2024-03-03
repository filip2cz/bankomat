using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            string input;
            int castka = 0;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Tento kód napodobuje fungování bankomatu při výběru, kdy Vy zadáte částku a on Vám vydá Vaše peníze v co největších bankovkách / mincích");
                Console.Write("Zadejte částku: ");
                input = Console.ReadLine();

                try
                {
                    castka = Convert.ToInt32(input);

                    Console.WriteLine();
                    Console.WriteLine("Vaše bankovky a mince:");

                    if (castka <= 0)
                    {
                        Console.WriteLine("Po bankomatu nemůžete chtít nulové nebo záporné množství peněz");
                    }
                    while (castka >= 5000)
                    {
                        Console.WriteLine(5000);
                        castka -= 5000;
                    }
                    while (castka >= 2000)
                    {
                        Console.WriteLine(2000);
                        castka -= 2000;
                    }
                    while (castka >= 1000)
                    {
                        Console.WriteLine(1000);
                        castka -= 1000;
                    }
                    while (castka >= 500)
                    {
                        Console.WriteLine(500);
                        castka -= 500;
                    }
                    while (castka >= 200)
                    {
                        Console.WriteLine(200);
                        castka -= 200;
                    }
                    while (castka >= 100)
                    {
                        Console.WriteLine(100);
                        castka -= 100;
                    }
                    while (castka >= 50)
                    {
                        Console.WriteLine(50);
                        castka -= 50;
                    }
                    while (castka >= 20)
                    {
                        Console.WriteLine(20);
                        castka -= 20;
                    }
                    while (castka >= 10)
                    {
                        Console.WriteLine(10);
                        castka -= 10;
                    }
                    while (castka >= 5)
                    {
                        Console.WriteLine(5);
                        castka -= 5;
                    }
                    while (castka >= 2)
                    {
                        Console.WriteLine(2);
                        castka -= 2;
                    }
                    while (castka >= 1)
                    {
                        Console.WriteLine(1);
                        castka -= 1;
                    }
                }
                catch (Exception)
                {
                    if (input == "exit" || input == "quit")
                    {
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("CHYBA");
                        Console.WriteLine("Ujistěte se, že jste zadali opravdu pouze číslo");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Stiskněte jakýkoliv znak pro restartování programu");
                Console.ReadKey();
            }
        }
    }
}
