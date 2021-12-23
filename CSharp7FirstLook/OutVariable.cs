using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FirstLook
{
    class OutVariable
    {
        static void Main(string[] args)
        {
            // TODO: Out Variables
            //string firstName;
            //string lastName;

            CreateName(out var firstName, out var lastName);
            Console.WriteLine($"What's up, {firstName} {lastName}!");
        }

        private static void CreateName(out string firstName,
            out string lastName)
        {
            firstName = "Reynald";
            lastName = "Adolphe";
        }
    }
}
//Output - What's up, Reynald Adolphe!
