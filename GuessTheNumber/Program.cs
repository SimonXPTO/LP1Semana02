using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd= new Random();
            int numberToGuess= rnd.Next(31);
            int counter= 0;
            while(true)
            {
                Console.Write("Insert number:");
                string a= Console.ReadLine();
                int b= int.Parse(a);
                

                if (b<0 | b>30)
                {
                    Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                    counter++;
                }
                else if (b<numberToGuess)
                {
                    Console.WriteLine($"The hidden number is higher than {b}. Try Again.");
                    counter++;
                }
                else if (b>numberToGuess)
                {
                    Console.WriteLine($"The hidden number is lower than {b}. Try Again.");
                    counter++;
                }
                else
                {
                    ++counter;
                    Console.WriteLine($"You found the hidden number {numberToGuess} after {counter} tries.");
                    break;
                }
            }
        }
    }
}
