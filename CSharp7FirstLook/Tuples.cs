using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FirstLook
{
    public class Tuples
    {
        static void Main(String[] args)
        {
            //Example 1
            Create3Tuple();
            //Example 2
            Create5Tuple();
            //Example 3
            CreateNestedTuple();
            //Example 4
            TupleInMethod1();
            //Example 5
            TupleInMethod2();
            // Ex 6
            CS7_TupleDemo(); // Comming soon...

            //From c# 7 tuples are value type 

            //Dotnet Supports tuple upto 7 elements inside a tuple
            //but we can use the 8th element using the keyword rest

            //A tuple is useful when we need to pass data set as a single parameter to a method
            //without using ref or out parameters

        }

        private static void CS7_TupleDemo()
        {
            TupleSamples ts = new TupleSamples();
            var person = ts.GetNewCS7_Tuple();
            Console.Write($"\n C# 7 Tuple - Author {person.Item1} {person.Item2} {person.Item3}");
        }

        private static void Create3Tuple()
        {
            var person = new Tuple<string, string, int>("1. 3 tuples - Reynald Reynolds", "C# design patterns", 2021);

            Console.WriteLine($"{person.Item1} released his popular book {person.Item2} course in {person.Item3}");
        }

        private static void Create5Tuple()
        {
            var reynald = Tuple.Create("\n2. 5 tuples - Reynald", "C# 6: First Look",
                "Lynda.com", 2016, 30.00);
            Console.WriteLine("{0} shot his 1st course titled {1} for {2} in {3}." +
                              " 2016 rate less than ${4}", reynald.Item1, reynald.Item2,
                reynald.Item3, reynald.Item4,
                reynald.Item5);
        }

        private static void CreateNestedTuple()
        {
            var myNestedTuple = new Tuple<int, int, int, int, int, int, int,  Tuple<string, string, double>>(2, 4, 6, 8, 10, 12, 14,
                Tuple.Create("\n3. Nested Tuples - Testing ", "Tuples for $", 10.00));
            Console.WriteLine("{0}{1}{2}.", myNestedTuple.Rest.Item1, myNestedTuple.Rest.Item2, myNestedTuple.Rest.Item3);
        }

        private static void TupleInMethod1()
        {
            TupleSamples ts = new TupleSamples();
            ts.SetTupleMethod(new Tuple<string, string, int>("Reynald Adolphe",
                ".NET Programming", 2017));
        }

        private static void TupleInMethod2()
        {
            var person = TupleSamples.GetTupleMethod();
            Console.WriteLine("\n5. Tuples in methods II - Person:{0}, Title:{1}, Year:{2}.",
                person.Item1, person.Item2, person.Item3);
        }
    }

    class TupleSamples
    {
        public void SetTupleMethod(Tuple<string, string, int> tuplePerson)
        {
            var Person = tuplePerson;
            Console.WriteLine("\n 4. Tuple in methods Person: {0}, Title:{1}, Year:{2}", Person.Item1, Person.Item2,
                Person.Item3);
        }
        public static Tuple<string, string, int> GetTupleMethod()
        {
            // Create a 3-tuple and return it  
            var person = new Tuple<string, string, int>(
                "Reynald Adolphe", "Test Driven Development in C#", 2016);
            return person;
        }

        public (string name, string title, long year) GetNewCS7_Tuple()
        {
            string name = "Reynald Adolphe";
            string title = ".Net Programming";
            long year = 2017;

            return (name, title, year);
        }
    }
}
//Output
/* 1. 3 tuples - Reynald Reynolds released his popular book C# design patterns course in 2021
   
   2. 5 tuples - Reynald shot his 1st course titled C# 6: First Look for Lynda.com in 2016. 2016 rate less than $30
   
   3. Nested Tuples - Testing Tuples for $10.
   
   4. Tuple in methods Person: Reynald Adolphe, Title:.NET Programming, Year:2017
   
   5. Tuples in methods II - Person:Reynald Adolphe, Title:Test Driven Development in C#, Year:2016.
   
   C# 7 Tuple - Author Reynald Adolphe .Net Programming 2017*/
