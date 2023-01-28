using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace IterationStatements
{
    public class Program
    {
        // Write a method that will print to the console all numbers 1000 through -1000
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        //Write a method to check whether a given number is even or odd
        //Write a method to check whether a given number is positive or negative
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        static void Main(string[] args)
        {
            PrintThousand();
            Threes();
            IsEqual(1, 2);
            IsEqual(1, 1);
            OddOrEven(10);
            OddOrEven(15);
            PositiveOrNegative(2);
            PositiveOrNegative(-100);
            PositiveOrNegative(0);
            AgeCheck();
            InRange();
            MultTable();
        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Threes()
        {
            for (int k = 3; k <=999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        public static bool IsEqual (int a, int b)
        {
            if(a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public static void OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }

        public static void PositiveOrNegative(int num)
        {
            if(num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else
            {
                Console.WriteLine($"{num} is neither positive or negative");
            }
        }

        public static void AgeCheck()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age");

                userAge = int.TryParse(Console.ReadLine(), out result);
            } while (!userAge);

            if (result < 18)
            {
                Console.WriteLine("Very sorry. You are not old enough to vote.");
            }
            else
            {
                Console.WriteLine("Congrats! You can vote!");
            }
        }

        public static void InRange()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an integer");

                userResponse = int.TryParse(Console.ReadLine(), out result);

            } while (!userResponse);

            //if (result >= -10 && result <= 10)
            //{
            //     Console.WriteLine($"{result} is between 10 & -10");
            // }
            //else
            //{
            //    Console.WriteLine($"{result} is NOT between 10 & -10");
            // }

            Console.WriteLine(result >= -10 && result <=10 ? $"{result} is between 10 & -10" : $"{result} is NOT between 10 & -10");
        }

        public static void MultTable()
        {
            bool cont;
            int userInput;

            do
            {
                Console.WriteLine("Enter an integer");

                cont = int.TryParse(Console.ReadLine(), out userInput);
            } while (!cont);

            for(var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {userInput} = {x * userInput}");
            }
        }
    }

}
