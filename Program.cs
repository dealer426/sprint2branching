using System;

namespace sprint2branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool shouldPrint = true;

            while(true)
            {
                Console.WriteLine("What is your favorite Color?");
                string favoriteColor = Console.ReadLine();

                if(favoriteColor == "Blue. No yel-- Auuuuuuuugh!")
                {
                    Console.WriteLine("You're just making Monty Python References.");
                    Console.WriteLine("Get Out");
                    break;
                }

                Console.WriteLine($"Your favorite color is {favoriteColor}");
            }



        }
    }
}
