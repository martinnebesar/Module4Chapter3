using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable declaration    
            int myInteger;
            string myString;

            // names are important
            int iStudentCount;

            iStudentCount = 100;

            decimal decPrice;
            DateTime dBirthDate;
            bool bIsValid;

            // Camel Case
            string firstName;
            string originalPackageNumber;

            // Pascal Case
            int Age;
            string LastName;
            string WintedOfDiscontent;

            int nbr1, nbr2, nbr3;
            string name1 = "Mark", name2 = "Paul";




            // variable assignation
            myInteger = 17;
            myString = "\"myInteger\" is \n this one here will be printed below";

            Console.WriteLine("{0} {1}.", myString, myInteger);
            Console.ReadKey();
        }
    }
}
