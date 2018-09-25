using System;


    class Program
    {
        static void Main()
        {
            const int MIN = 1;
            const int MAX = 1000;
            Random r = new Random();
            string ujjatek;
            do
            {
                int gondoltszam = r.Next(MIN, MAX + 1);
                Console.Clear();
                Console.WriteLine(gondoltszam);
                Console.WriteLine("Gondoltam egy számra {0} és {1} között", MIN, MAX);
                Console.WriteLine("Próbld meg kitalálni!");
                int tipp, tippekszama = 0;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    tippekszama++;
                    Console.WriteLine("\nKérem a {0}. tipped", tippekszama);
                    tipp = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (gondoltszam > tipp) Console.WriteLine("Rosszul tippeltél! Nagyobb számra gondoltam");
                    else if (gondoltszam < tipp) Console.WriteLine("Rosszul tippeltél! Kisebb számra gondoltam");
                } while (tipp != gondoltszam);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gratulálok! {0} próbálkozásból eltaláltad.", tippekszama);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nSzeretnél új játékot játszani? (i/n)");
                ujjatek = Console.ReadLine();

            } while (ujjatek == "i");
                
            Console.ReadKey();
        }
    }

