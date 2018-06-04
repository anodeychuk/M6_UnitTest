using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6_UnitTesting
{
    public class Worker : Person
    {
        public Worker(string name, int age) : base(name, age)
        {
            Skill = new List<string>() { "dig the ground", "brick" };
        }

        public override double Salary()
        {
            return 1000;
        }

    }
}
