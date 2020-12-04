using System;
using System.IO;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("-- Advent Of Code --");
                Console.WriteLine("1) Dag 1");

                Console.WriteLine("q) Avsluta");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DayOnePartOne();
                        DayOnePartTwo();
                        break;
                    case "q":
                        isRunning = false;
                        continue;
                    default:
                        break;
                }
            }
        }

        static void DayOnePartOne()
        {
            //Deklarera värden
            string input;
            List<int> numbers = new List<int>();
            //Läs in listan
            var file = new StreamReader(@"..\..\..\numbers.txt");

            while ((input = file.ReadLine()) != null)
            {
                numbers.Add(int.Parse(input));
            }

            int first = 0;
            int second = 0;
            int produkt = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 1; j < numbers.Count; j++)
                {
                    if ((numbers[i] + numbers[j]) == 2020)
                    {
                        first = numbers[i];
                        second = numbers[j];
                        produkt = numbers[i] * numbers[j];
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Advent of Code, Dag 1, del 1");
            Console.WriteLine("{0} + {1} = 2020", first, second);
            Console.WriteLine("Produkten av {0} och {1} är {2}", first, second, produkt);
            Console.Write("\nTryck på en tangent för att fortsätta...");
            Console.ReadKey();
        }

        static void DayOnePartTwo()
        {
            //Deklarera värden
            string input;
            List<int> numbers = new List<int>();
            //Läs in listan
            var file = new StreamReader(@"..\..\..\numbers.txt");

            while ((input = file.ReadLine()) != null)
            {
                numbers.Add(int.Parse(input));
            }

            int first = 0;
            int second = 0;
            int third = 0;
            int produkt = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 1; j < numbers.Count; j++)
                {
                    for (int k = 2; k < numbers.Count; k++)
                    {
                        if ((numbers[i] + numbers[j] + numbers[k]) == 2020)
                        {
                            first = numbers[i];
                            second = numbers[j];
                            third = numbers[k];
                            produkt = first * second * third;
                        }
                    }

                }
            }
            Console.Clear();
            Console.WriteLine("Advent of Code, Dag 1, del 2");
            Console.WriteLine("{0} + {1}  + {2} = 2020", first, second, third);
            Console.WriteLine("Produkten av {0} och {1} och {2} är {3}", first, second, third, produkt);
            Console.Write("\nTryck på en tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
