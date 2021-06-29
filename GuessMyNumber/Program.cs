using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool found = false;

            Console.WriteLine("Guess my number!");
            Console.WriteLine("Pick one between 1-100");
            int number = rnd.Next(100);//sets the number as a random number between 1-100
            while (!found)
            {//while the number hasn't been found
                int guess = Convert.ToInt32(Console.ReadLine());//allows the user to continue guessing
                if (guess == number)
                {
                    Console.WriteLine("You guessed my number!");
                    found = true;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Guess higher!");
                }
                else
                {
                    Console.WriteLine("Guess lower!");
                }
            }
            Console.ReadLine();//Lets the user read the victory message, press Enter to exit
        }
    }
}
