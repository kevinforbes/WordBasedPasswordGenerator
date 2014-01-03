using System;
using System.Linq;

namespace WordBasedPasswordGenerator
{
    public static class WordBasedPasswordGenerator
    {
        private static readonly Random _random = new Random();

        public static string GeneratePassword()
        {
            //get 2 words that are 5 or less characters long

            int count = WordList.Words.Count(x => x.Length <= 5 && x.Length >= 3);
            string word1 = WordList.Words.Where(x => x.Length <= 5 && x.Length >= 3).ElementAt(_random.Next(count));
            string word2 = WordList.Words.Where(x => x.Length <= 5 && x.Length >= 3).ElementAt(_random.Next(count));

            //add a number in between
            return word1 + _random.Next(100) + word2;
        }

    }
}
