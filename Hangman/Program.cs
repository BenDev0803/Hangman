using System;

namespace Hangman // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static readonly Random randomChoice = new Random();
        static void Main(string[] args)
        {
            List<String> words = new List<String>() { "House", "Room", "Kitchen", "Garden" };
            List<Char> userWord = new List<Char>();
            int computerChoice = randomChoice.Next(0, words.Count);
            string randomWord = words[computerChoice];
            Console.WriteLine($"Hangman game! type a character and see if it matches with a word letter!");
            Char line = '-';

            for (int i = 0; i < randomWord.Length; i++)
            {
                
                userWord.Add(line);
            
            }

            userWord.ForEach(Console.Write); //TODO: maybe write with a for loop / foreach loop
            const int additionalAttempts = 5;
            int attempts = randomWord.Length + additionalAttempts;
            
            for (int j = attempts; j >= 0 ; j--)
            {

                string combinedString = string.Join("", userWord.ToArray());

                ConsoleKeyInfo userChoiceKeyInfo = Console.ReadKey();

                Char userChoiceChar = userChoiceKeyInfo.KeyChar;
                
                Console.Clear();

                if (randomWord == combinedString)
                {
                    Console.WriteLine(" you won!");
                    break;
                }
                

                for (int i = 0; i < randomWord.Length; i++)
                {
                    
                    if (userChoiceChar == randomWord[i])
                    {
                        
                        userWord[i] = randomWord[i];
                        
                    }
                }

                userWord.ForEach(Console.Write);
                Console.Write($" remaining attempts {j}"); 

                if (j == 0) 
                {
                    Console.WriteLine(" you lost!");
                }
            }
        }
    }
}