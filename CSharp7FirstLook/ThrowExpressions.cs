using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FirstLook
{
    class ThrowExpressions
    {
        static private string _name;

        static public string Name
        {
            get => _name;
            set => _name = value ??
                           throw new ArgumentNullException(paramName: nameof(Name),
                               message: "New name must not be null");
        }


        static void Main(string[] args)
        {
            Name = null;

            Console.WriteLine($"Name = {Name}");
        }
    }

    public class NewPerson
    {
        public string Name { get; }

        // Null Coalescing Expression.
        public NewPerson(string name) => Name = name ??
                                                throw new ArgumentException(name);

        // Conditional Expressions
        public string GetFirstName()
        {
            var parts = Name.Split(new string[] { " " }, StringSplitOptions.None);
            return (parts.Length > 0) ? parts[0] :
                throw new InvalidOperationException("No name");
        }

        // Lambda Expression    
        public string GetLastName() =>
            throw new NotImplementedException();
    }
}
