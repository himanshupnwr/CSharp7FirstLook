using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FirstLook
{
    class RefReturns
    {
        static void Main(string[] args)
        {

            TestRef1();
            TestRef2();
        }

        #region TestRef2
        static void TestRef2()
        {
            string[] actors = {"Ben Affleck", "Jennifer Lawrence", "Tom Cruise",
                "Matt Damon", "Jackie Chan" };
            int positionInArray = 2;

            ref string actor3 = ref new RefReturns().FindActor(positionInArray, actors);

            Console.WriteLine($"Original actor:{actor3}");

            actor3 = "Dwayne Johnson";

            Console.WriteLine($"Replaced actor with :{actors[positionInArray]}");

            Console.ReadKey();

        }

        public ref string FindActor(int index, string[] names)
        {

            if (names.Length > 0)
                return ref names[index]; // return the storage location, not the value    
            throw new IndexOutOfRangeException($"{nameof(index)} not found.");

        }
        #endregion

        #region TestRef1
        static void TestRef1()
        {
            long total = 0;
            AddByRef(15, 10, ref total);
            Console.WriteLine(total);
            
        }

        static void AddByRef(long a, long b, ref long total)
        {
            total = a + b;
        }
        #endregion
    }
}

//Output
/*25
Original actor:Tom Cruise
Replaced actor with :Dwayne Johnson*/
