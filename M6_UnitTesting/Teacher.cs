using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6_UnitTesting
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
            Skill = new List<string> { "Teach C#", "Teach CSS", "Teach JavaScript" };
        }

        public override double Salary()
        {
            return 500;
        }

        public string GetSkill()
        {
            return "C#";
        }
    }
}
