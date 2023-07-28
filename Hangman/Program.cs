using System;

namespace Hangman // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static readonly Random randomChoice = new Random();
        static void Main(string[] args)
        {
            List<String> possibleWords = new List<String>() { "House", "Room", "Kitchen", "Toilet" };
            List<Char> guessedWord = new List<Char>();
            int computerChoice = randomChoice.Next(0, possibleWords.Count);
            string randomWord = possibleWords[computerChoice];
            Console.WriteLine($"Hangman game! type a letter and see if it matches with a word letter!");
            Char line = '-';


            for (int i= 0; i < randomWord.Length; i++)
            {
                guessedWord.Add(line);
                
            }
            guessedWord.ForEach(Console.Write);

            ConsoleKeyInfo userOutput = Console.ReadKey();
            Char userLetter = userOutput.KeyChar;

            for (int i = 0; i < randomWord.Length; i++)
            {
                if (userLetter == randomWord[i])
                {
                    guessedWord[i] = randomWord[i];
                    guessedWord.ForEach(Console.Write);
                }
                else
                {
                    guessedWord[i] = line;
                    guessedWord.ForEach(Console.Write);
                }
            }
            guessedWord.ForEach(Console.Write);

        }
    }
}