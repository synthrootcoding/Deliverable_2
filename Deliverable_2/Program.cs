using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string headsOrTailsGuess;
            int numberOfFlips;
            int correctCount = 0;
            Random coinFlip = new Random();
            string heads = "heads";
            string tails = "tails";
            int flip;

            Console.WriteLine("Which will have more: heads or tails?");
            headsOrTailsGuess = Console.ReadLine();

                Console.WriteLine("Flip a coin how many times?");
                numberOfFlips = int.Parse(Console.ReadLine());

            if (headsOrTailsGuess.Contains(heads))
            {
                for (int i = 0; i < numberOfFlips; i++)
                {
                    flip = coinFlip.Next(2);
                    if (flip == 0)
                    {
                        Console.WriteLine(heads);
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine(tails);
                    }
                }
            }
            else if (headsOrTailsGuess.Contains(tails))
            {
                for (int i=0; i < numberOfFlips; i++)
                {
                    flip = coinFlip.Next(2);
                    if (flip == 0)
                    {
                        Console.WriteLine(heads);
                    }
                    else
                    {
                        Console.WriteLine(tails);
                        correctCount++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("\nYour guess, " + headsOrTailsGuess + ", hit " + correctCount + " time(s)");
            Console.WriteLine("That is " + Convert.ToDouble(correctCount) / Convert.ToDouble(numberOfFlips) * 100 + "%");
        }
    }
}
