using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Student: Person
    {
        string Group { get; set; }
        
        public Student(string name, string family, string group) : base(name, family)
        {
            Group = group;
        }

        public override string Display()
        {
            return $"{Group} {Name} {Family}";
        }
    }
}
