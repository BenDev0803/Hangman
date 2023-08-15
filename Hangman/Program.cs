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
            const Char YES = 'y';
            const Char NO = 'n';
            List<String> words = new List<String>() { "House", "Room", "Kitchen", "Garden" };
            List<Char> userWord = new List<Char>();
            int computerChoice = randomChoice.Next(0, words.Count);
            string randomWord = words[computerChoice];
            int attempts = randomWord.Length + ADDITIONAL_ATTEMPTS;
            Console.WriteLine($"Hangman game! type a character and see if it matches with a word letter!");

            for (int i = 0; i < randomWord.Length; i++)
            {
                userWord.Add(LINE);
                Console.Write(userWord[i]);
            }

            /*
            while (attempts == 0 || !userWord.Contains('-'))
            {
                Console.WriteLine("would you like to play again? y/n");
                ConsoleKeyInfo userChoiceAnswer = Console.ReadKey();
                Char userAnswer = userChoiceAnswer.KeyChar;
                if (userChoiceAnswer.KeyChar == YES)
                {

                }
                else if (userChoiceAnswer.KeyChar == NO)
                {
                    break;
                }
            }
            */

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