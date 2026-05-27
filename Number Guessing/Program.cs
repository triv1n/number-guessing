using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
           
            string input;
            bool success;

            int attempts = 0;

            int lastTry;
            int CurrentTry;

            int number = random.Next(101);

            Console.WriteLine("Try to guess a number between 0 and 100");

            while (true)
            {
                input = Console.ReadLine();
                success = int.TryParse(input, out int UserChoice);
                CurrentTry = UserChoice;

                if (!success)
                {
                    Console.WriteLine("You must enter a number");
                    continue;
                }

                if (success)
                {
                    attempts++;
                }


                if (CurrentTry == number)
                {
                    Console.WriteLine($"Win! Number of attempts: {attempts}");
                    break;
                }
                
                switch (UserChoice)
                {
                    case int n when n < number:
                        Console.WriteLine("A random number that is bigger than yours.");
                        lastTry = CurrentTry;
                        break;
                    case int n when n > number:
                        Console.WriteLine("A random number that is smaller than yours.");
                        lastTry = CurrentTry;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
