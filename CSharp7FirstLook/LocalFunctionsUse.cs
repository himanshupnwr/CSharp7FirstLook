using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FirstLook
{
    class LocalFunctionsUse
    {
        static void Main(string[] args)
        {
            //Example 3 - Recursion
            int myValue = 1;
            int Calc(int n) => (n < 2) ? myValue : Calc(n - 1) + Calc(n - 2);
            Console.WriteLine(Calc(8));
        }

        #region Iterator

        public IEnumerable<T> Filter<T>(IEnumerable<T> source, Func<T, bool> filter)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (filter == null) throw new ArgumentNullException(nameof(filter));

            return Iterator();

            IEnumerable<T> Iterator()
            {
                foreach (var element in source)
                {
                    if (filter(element))
                    {
                        yield return element;
                    }
                }
            }
        }

        #endregion
    }
}
//Output - 34