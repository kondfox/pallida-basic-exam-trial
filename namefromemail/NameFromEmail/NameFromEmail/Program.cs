﻿using System;

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

            string firstName = firstNameNonCapital.Substring(0, 1).ToUpper() + firstNameNonCapital.Substring(1);
            string lastName = lastNameNonCapital.Substring(0, 1).ToUpper() + lastNameNonCapital.Substring(1);

            return lastName + " " + firstName;
        }
    }
}