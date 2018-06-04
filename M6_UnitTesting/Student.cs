using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6_UnitTesting
{
    public class Student : Person
    {
        public int IQ { get; }

        public Student(string name, int age, int iq) : base(name, age)
        {
            this.IQ = iq;
            Skill = new List<string> { "Drive car", "Play the piano" };
        }

        public override double Salary()
        {
            return 0;
        }

        public bool Learning(string skillName, int needIq)
        {
            if (needIq < IQ)
            {
                Skill.Add(skillName);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
