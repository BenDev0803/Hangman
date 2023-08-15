using System;

namespace Hangman // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static readonly Random randomChoice = new Random();
        static void Main(string[] args)
        {
            const Char LINE = '-';
            const int ADDITIONAL_ATTEMPTS = 5;
            List<String> words = new List<String>() { "House", "Room", "Kitchen", "Garden" };
            List<Char> userWord = new List<Char>();
            int computerChoice = randomChoice.Next(0, words.Count);
            string randomWord = words[computerChoice];
            Console.WriteLine($"Hangman game! type a character and see if it matches with a word letter!");

            for (int i = 0; i < randomWord.Length; i++)
            {
                userWord.Add(LINE);
                Console.Write(userWord[i]);
            }

            int attempts = randomWord.Length + ADDITIONAL_ATTEMPTS;
            
            for (int j = attempts; j >= 0 ; j--)
            {
                ConsoleKeyInfo userChoiceKeyInfo = Console.ReadKey();

                Char userChoiceChar = userChoiceKeyInfo.KeyChar;
                
                Console.Clear();

                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (userChoiceChar == randomWord[i])
                    {
                        userWord[i] = randomWord[i];
                    }
                    Console.Write(userWord[i]);
                }

                if(!userWord.Contains('-'))
                {
                    Console.WriteLine(" You Won");
                    break;
                }

                Console.Write($" remaining attempts {j}");
            }
            if (userWord.Contains('-'))
            {
                Console.WriteLine(" you lost!");
            }            
        }
    }
}