using System;

namespace Hangman // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static readonly Random randomChoice = new Random();
        static void Main(string[] args)
        {
            List<String> words = new List<String>() { "House" };// , "Room", "Kitchen", "Toilet" };
            List<Char> userWord = new List<Char>();
            int computerChoice = randomChoice.Next(0, words.Count);
            string randomWord = words[computerChoice];
            Console.WriteLine($"Hangman game! type a letter and see if it matches with a word letter!");
            Char line = '-';


            for (int i = 0; i < randomWord.Length; i++)
            {
                userWord.Add(line);
            }
            userWord.ForEach(Console.Write); //TODO: maybe write with a for loop / foreach loop

            int attempts = randomWord.Length + 5;
            //foreach (var item in collection)
            //{

            //}

                

            for (int j = attempts; j >= 0 ; j--)
            {
                ConsoleKeyInfo userChoiceKeyInfo = Console.ReadKey();
                Char userChoiceChar = userChoiceKeyInfo.KeyChar;
                for (int i = 0; i < randomWord.Length; i++)
                {
                    
                    if (userChoiceChar == randomWord[i])
                    {
                        userWord[i] = randomWord[i];
                        
                    }
                    else
                    {
                        userWord[i] = line;
                    }

                    //Console.WriteLine(userWord);
                    
                }
                userWord.ForEach(Console.Write);
            }
            

            
            

           // Console.ReadKey();
        }
    }
}