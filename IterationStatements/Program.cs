using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000   1-DONE

        //Write a method that will print to the console numbers 3 through 999 by 3 each time   2-DONE

        //Write a method to accept two integers as parameterss and check whether they are equal or not   3-DONE

        //Write a method to check whether a given number is even or odd   4-DONE

        //Write a method to check whether a given number is positive or negative   5-DONE

        //Write a method to read the age of a candidate and determine whether they can vote.   6-DONE
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10   7-DONE

        //Write a method to display the multiplication table(from 1 to 12) of a given integer   8-DONE


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            TwoThousand();
            ByThrees();
            CheckEqual(5, 55);
            EvenOdd();
            PositiveNegative();
            VotingAge();
            CheckRange();
            Multiply(5);



        }

        public static void TwoThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void ByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool CheckEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} equals {num2}");
                return true;
            }
            else
            {
                Console.WriteLine($"{num1} does not equal {num2}");
                return false;
            }

        }
        public static void EvenOdd()
        {
            Console.WriteLine("Give me any whole number and I'll tell you if it's even or odd:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput} is an Even Number");
                
            }
            else
            {
                Console.WriteLine($"{userInput} is an Odd Number");
                
            }
        }

        public static void PositiveNegative()
        {
            Console.WriteLine("Give me any whole number and I'll tell you if it's positive or negative>:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 0)
            {
                Console.WriteLine($"{userInput} is a positive number");
            }
            else if (userInput < 0)
            {
                Console.WriteLine($"{userInput} is a negative number");
            }
            else
            {
                Console.WriteLine($"{userInput} is zero");
            }

        }

        public static void VotingAge()
        {
            Console.WriteLine("Welcome to the polls, what is your age?");
            int voterInput = int.Parse(Console.ReadLine());

            if (voterInput >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("Sorry, you're not old enough to vote yet.");
            }

        }

        public static void CheckRange()
        {
            Console.WriteLine("Type a number between -10 and 10:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"Yes, {userInput} is between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not between -10 and 10.");

            }
        }

        public static void Multiply(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");

            }

                    
        }
        
    }
}
