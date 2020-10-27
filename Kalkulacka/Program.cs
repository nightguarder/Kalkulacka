using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {


            var a = 0;
            var b = 0;


            Console.WriteLine("Super Kalkulačka");
            Console.WriteLine("Napiste prvni cislo");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadejte druhe cislo");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vyberte vaši operaci:");
            Console.WriteLine("\t s - pro soucet");
            Console.WriteLine("\t o - pro odecitani");
            Console.WriteLine("\t m - pro nasobeni");
            Console.WriteLine("\t d - pro dělení");

            float soucet = a + b;
            float odecitani = a - b;
            float nasobeni = a * b;
            float deleni = a / b;

            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Vysledek pro soucet: {a}+{b} = " +soucet);
                    break;
                case "m":
                    Console.WriteLine($"Vysledek pro nasobeni: {a}*{b}=" + nasobeni);
                    break;
                case "d":
                    Console.WriteLine($"Vysledek pro deleni: {a}/{b}=" + deleni);
                    break;
                case "o":
                    Console.WriteLine($"Vysledek pro odecitani: {a}-{b}=" +odecitani);
                    break;
            };

            Console.WriteLine("Kalkulacka se ukonci automaticky");
            System.Environment.Exit(0);
        }
    }
}
