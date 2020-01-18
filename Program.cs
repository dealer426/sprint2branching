using System;

namespace sprint2branching
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Neither Pass Go, Nor Collect 200
            bool shouldPrint = true;

            while (shouldPrint)
            {
                Console.WriteLine("I should print!");
                break;
            }
            */

            /*Monty Python and Break
            while (true)
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
            */


            /* Using a continue to skip over the CW
            for (int count = 1; count < 10; count++)
            {
                if (count % 3 == 0)//is a multiple of 3
                {
                    continue;
                }
                Console.WriteLine("Count is " + count);
            }
            */


            Console.WriteLine("Message for 42: " + chooseMessage(42));
            Console.WriteLine("Message for 23: " + chooseMessage(23));

            for (int hours = 1; hours < 3; hours++)
            {
                for (int minutes = 0; minutes < 60; minutes += 5)
                {
                    Console.WriteLine($"The time is {hours:00}:{minutes:00}");
                }
            }


        }

        public static string chooseMessage(int input)
        {
            if(input % 2 == 0)
            {
                return "Even Steven!";
            }

            return "You're odd!";
        }
    }
}
