using System;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }

        public static string NameFromEmail(string email)
        {
            string[] emailSplitted = email.Split('.', '@');
            string firstNameNonCapital = emailSplitted[0];
            string lastNameNonCapital = emailSplitted[1];

            string firstName = Camelizer(firstNameNonCapital);
            string lastName = Camelizer(lastNameNonCapital);

            return string.Format("{0} {1}", lastName, firstName);
        }

        private static string Camelizer(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
        }
    }
}