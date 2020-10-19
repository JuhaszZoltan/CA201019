using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201019
{
    class Program
    {
        static void Main()
        {
            var nev = "Juhász Zoltán";
            F401(nev);
            F402(nev);
            F403(nev);
            F404(Beker());
            F405(Beker());
            F406(Beker());
            F407(Beker());
            Console.ReadKey();
        }

        private static void F407(string szoveg)
        {
            int c = 0;
            for (int i = 0; i < szoveg.Length - 1; i++)
                if (szoveg[i] == ' ' && szoveg[i + 1] != ' ') c++;
            Console.WriteLine($"A '{szoveg}'-ben {c + 1} db szó van.");
        }

        private static void F406(string szo)
        {
            int c = 0;
            for (int i = 0; i < szo.Length; i++)
                if (szo[i] == 'e' || szo[i] == 'E') c++;
            Console.WriteLine($"A {szo}-ban {c} db 'e' betű van.");
        }

        private static string Beker()
        {
            Console.Write("szó: ");
            return Console.ReadLine();
        }
        private static void F405(string szo)
        {
            for (int i = szo.Length - 1; i >= 0; i--)
                Console.Write($"{szo[i]}");
            Console.Write("\n");
        }

        private static void F404(string szo)
        {
            Console.Clear();
            for (int i = 0; i < szo.Length + 2; i++)
                Console.Write('*');
            Console.WriteLine($"\n*{szo}*");
            for (int i = 0; i < szo.Length + 2; i++)
                Console.Write('*');
            Console.Write("\n");
        }

        private static void F403(string nev)
        {
            for (int i = 0; i < nev.Length; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(" ");
                Console.WriteLine(nev[i]);
            }
        }

        private static void F402(string nev)
        {
            for (int i = 0; i < nev.Length; i++)
                Console.WriteLine($"{nev[i]}");
        }

        private static void F401(string nev)
        {
            for (int i = 0; i < nev.Length; i++)
                Console.Write($"{nev[i]} ");
            Console.Write("\n");
        }
    }
}
