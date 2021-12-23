using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7FirstLook
{
    class ExpressionBodiedMembers
    {
        #region Previously in C# 6
        //static private string name = "Jerry Seinfeld";
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}


        //Output is Name: Jerry Seinfeld is 62
        static public string Name => "Jerry Seinfeld";

        #endregion

        static void Main(string[] args)
        {
            // TODO: C# 7 Expression Bodied Function Members
            Person p = new Person(Name);
            p.Age = 62;
            Console.WriteLine($"Name: {p.Name} is {p.Age}");
        }
    }

    class Person
    {

        #region Classic Constructor

        //public Person(string name)
        //{
        //    Name = name;
        //}

        public Person(string name) => Name = name;

        #endregion

        #region Classic Full Properties

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private int _age;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        #endregion

        #region Classic Desctructor

        //~Person()
        //{
        //    Console.WriteLine("Destructor was called!");
        //}

        ~Person() => Console.WriteLine("Destructor was called!");

        #endregion
    }
}
