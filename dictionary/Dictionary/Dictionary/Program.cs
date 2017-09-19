using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static Dictionary<string, string> Dictionary;

        static void Main(string[] args)
        {
            Dictionary = new Dictionary<string, string>
            {
                { "alma", "apple" },
                { "fa", "tree" }
            };

            //add more words to your dictionary
            AddWord("korte", "pear");
            RemoveWord("fa");

            string testHunWord = "korte";
            Console.WriteLine("HUN --> EN translation of {0} is {1}.", testHunWord, TranslateToEnglish(testHunWord));

            string testEngWord = "pear";
            Console.WriteLine("EN --> HUN translation of {0} is {1}.", testEngWord, TranslateToHungarian("pear"));

            Console.ReadLine();
        }

        // Implement this method. It should add the given key-value pair to the the dictionary
        public static void AddWord(string hungarianWord, string englishWord)
        {
            if (Dictionary.ContainsKey(hungarianWord))
            {
                Dictionary[hungarianWord] = englishWord;
            }
            else
            {
                Dictionary.Add(hungarianWord, englishWord);
            }
        }

        // Implement this method. It should remove the key-value pair by the given key from the dictionary
        public static void RemoveWord(string hungarianWord)
        {
            Dictionary.Remove(hungarianWord);
        }

        // Implement a method which works as a translator from Hungarian to English
        // Example: you give it a parameter "fa" and it's output is "tree"
        public static string TranslateToEnglish(string hungarian)
        {
            return Dictionary[hungarian];
        }

        // Implement a method which works as a translator from English to Hungarian
        // Example: you give it a parameter "apple" and it's output is "alma"
        public static string TranslateToHungarian(string english)
        {
            string notFoundString = "No translation found";
            if (!Dictionary.ContainsValue(english))
            {
                return notFoundString;
            }

            foreach (var translation in Dictionary)
            {
                if (translation.Value == english)
                {
                    return translation.Key;
                }
            }
            return notFoundString;
        }
    }
}