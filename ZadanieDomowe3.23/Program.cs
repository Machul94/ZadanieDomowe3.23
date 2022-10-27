using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe3._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            var los = rng.Next(0, 101);
            var ilośćprób = 0;
            int liczba;
            Console.WriteLine("Program losuje liczbę z przedziału od 0 do 100. \nOdgadnij wylosowaną liczbę");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Podaj liczbę: ");
                liczba = Numer();
                ilośćprób++;
                if (liczba > los)
                {
                    Console.WriteLine("Podana liczba jest za duża, zgaduj dalej");
                    Console.WriteLine();
                }
                else if (liczba < los)
                {
                    Console.WriteLine("Podana liczba jest za mała, zgaduj dalej");
                    Console.WriteLine();
                }
                else
                {
                    
                    Console.WriteLine($"Gratulacje! Udało ci się za {ilośćprób} razem");
                }

            } while (los != liczba);


            Console.ReadKey();
        }
        public static int Numer()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int liczbaZgadującgo))
                {
                    Console.WriteLine("Niepoprawna wartość, Spróbuj ponownie");
                    continue;
                }
                else if (liczbaZgadującgo > 101 || liczbaZgadującgo < 0)
                {
                    Console.WriteLine("Numer z poza zakresu");
                    continue;
                }
                return liczbaZgadującgo;
            }
        }
    }
}



