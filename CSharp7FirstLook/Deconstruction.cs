using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FirstLook
{
    class Deconstruction
    {
        static void Main(string[] args)
        {
            //Deconstruction is a process of splitting a variable value into parts and storing them in new variables
            //This is useful when a variable multiple values such as in the tuples
            // TODO - Deconstruction Demo
            var (authorName, bookTitle, pubYear) = GetNewCS7_Tuple();

            Console.WriteLine("Author: {0} \nBook: {1} Year: {2}\n",
                authorName, bookTitle, pubYear);

            Comedian comedian = new Comedian("Reynald", "Adolphe");
            var (firstName, lastName) = comedian;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }


        static public (string name, string title, long year) GetNewCS7_Tuple()
        {
            string name = "Reynald Adolphe";
            string title = ".NET Programming";
            long year = 2017;

            // Tuple literal - Returns a tuple type of three values  
            return (name, title, year);
        }
    }
    public class Comedian
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Comedian(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}

//Output
/*
Author: Reynald Adolphe Book: .NET Programming Year: 2017

Reynald
Adolphe
*/
