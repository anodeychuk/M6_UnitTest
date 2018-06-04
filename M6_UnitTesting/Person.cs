using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6_UnitTesting
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<string> Skill { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public abstract double Salary();
    }

}
