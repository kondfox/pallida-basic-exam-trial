using System;
using System.Collections.Generic;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an OddFilter function that takes a list as a parameter,
            // and returns a new list with every odd element from the orignal list
            List<int> oddElements = OddFilter(new List<int> { 1, 2, 3, 4, 5 });

            // In case of the example input above, the given PrintList function should print 1 3 5 
            PrintList(oddElements);

            Console.ReadLine();
        }

        public static List<int> OddFilter(List<int> numbers)
        {
            var oddNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 1)
                {
                    oddNumbers.Add(number);
                }
            }
            return oddNumbers;
        }

        private static void PrintList(List<int> list)
        {
            foreach (int element in list)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}