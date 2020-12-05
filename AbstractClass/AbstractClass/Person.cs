using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public Person(string name, string family)
        {
            Name = name;
            Family = family;
        }

        abstract public string Display();
    }
}
