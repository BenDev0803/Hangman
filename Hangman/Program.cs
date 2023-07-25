using System;

namespace Hangman // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static readonly Random randomChoice = new Random();
        static void Main(string[] args)
        {
            List<String> possibleWords = new List<String>() { "House", "Room", "Kitchen", "Toilet" };
            int computerChoice = randomChoice.Next(0, possibleWords.Count);
            // Console.WriteLine(possibleWords[computerChoice]);
            Console.WriteLine($"Hangman game! type a letter and see if it matches with a word letter!");
            string userOutput = Console.ReadLine();

            for (int i = 0; i < possibleWords[computerChoice].Length; i++)
            {
                if (possibleWords[computerChoice].Contains(userOutput))
                {
                    Console.WriteLine("true!");
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
            
            /*if(userOutput == possibleWords[computerChoice])
            {
                Console.WriteLine("true!");
            }
            else
            {
                Console.WriteLine("try again");
            } 
            */
        }
    }
}