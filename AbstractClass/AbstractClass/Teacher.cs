using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Teacher: Person
    {
        public int Seniority { get; set; }
        
        public Teacher(string name, string family, int seniority) : base(name, family)
        {
            Seniority = seniority;
        }

        public override string Display()
        {
            return $"{Name} {Family} Стаж: {Seniority}";
        }
    }

    
}
