using System;

namespace ClassPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax Exercise
            //var answer = 4;
            //var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than nine";

            //if-else statements
            int favNumber = 10;
            if (favNumber < 10)
            {
                Console.WriteLine("Too low.");
            }
            else if(favNumber > 10)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("Nevermind.");
            }

            //switch/case
            int artists = 1;
            switch (artists)
            {
                case 1:
                    Console.WriteLine("Krowe");
                    break;
                case 2:
                    Console.WriteLine("EWOX");
                    break;
                case 3:
                    Console.WriteLine("Common Creation");
                    break;
                case 4:
                    Console.WriteLine("MORS");
                    break;
                default:
                    Console.WriteLine("Matheny");
                    break;
            }
        }
    }
}
