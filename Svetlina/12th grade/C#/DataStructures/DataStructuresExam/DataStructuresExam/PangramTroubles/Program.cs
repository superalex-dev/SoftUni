using System;

namespace PangramTroubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "thequickbrownfoxjumpsoverthelazydog";
            string sentence2 = "harrypotter";
            Console.WriteLine(ValidatePangram(sentence));
        }

        public static bool ValidatePangram(string sentence)
        {
            HashSet<char> uniqueChars = new HashSet<char>();

            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    uniqueChars.Add(char.ToLower(c));
                }
            }

            return uniqueChars.Count == 26;
        }   
    }
}