using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib, mis hinde kasutaja sai
            // kui kasutaja sai "A", konsool kuvab "Suurepärane",
            //"B", konsool kuvab "Väga hea";
            //"C", konsool kuvab "Hea",
            //"D", "Rahuldav",
            //"E", "Kasin",
            //"F", "puudulik",

            //kasutame Switch

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea");
                    break;
                case 'C':
                    Console.WriteLine("Hea");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Vale väärtus");
                    break;
            }
           
            Console.WriteLine("Kena päeva!");
        }
    }
}
 