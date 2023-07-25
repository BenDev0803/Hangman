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
            string randomWord = possibleWords[computerChoice];
            Console.WriteLine($"Hangman game! type a letter and see if it matches with a word letter!");
            ConsoleKeyInfo userOutput = Console.ReadKey();
            Char userLetter = userOutput.KeyChar;
            for (int i = 0; i < randomWord.Length; i++)
            { 
                if(userLetter == randomWord[i])
                {
                    Console.WriteLine("true!" + randomWord);
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}