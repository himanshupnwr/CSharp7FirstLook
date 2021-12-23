using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FirstLook
{
    class SwitchExpression
    {
        static void Main(string[] args)
        {
            Performer p = new Performer();
            Actor a = new Actor("Eddie Murphy", 54, "male",
                "Coming to America", 2017);
            Musician m = new Musician("Jen", 25, "female", "singing",
                "Pop");

            // Switch Statement 
            m = null;
            switch (m)
            {
                case Performer performer when (performer.Age == 33):
                    Console.WriteLine($"The performer {performer.Name}");
                    break;
                case Musician musician when (musician.Age == 25):
                    Console.WriteLine($"The performer {musician.Name}");
                    break;
                case Musician musician:
                    Console.WriteLine("The Musician is unknown");
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(m));
            }
        }
    }
}
