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
            Console.WriteLine(possibleWords[computerChoice]);
        }
    }
}