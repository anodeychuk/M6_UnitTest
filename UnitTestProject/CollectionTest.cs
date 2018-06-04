using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using M6_UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CollectionTest
    {
        [TestMethod]
        public void ListAllItemsAreUniqueTest()
        {
            // create object
            Teacher Tom = new Teacher("Tom Paterson", 38);

            CollectionAssert.AllItemsAreUnique(Tom.Skill);
        }

        [TestMethod]
        public void ListContainsTest()
        {
            // create object
            Student Ivan = new Student("Ivan Pupkin", 22, 110);
            Ivan.Learning("C#", 100);

            CollectionAssert.Contains(Ivan.Skill, "C#");
        }

        [TestMethod]
        public void TypeTest()
        {
            // create object
            Worker Slu = new Worker("Slu Porter", 35 );

            Assert.IsInstanceOfType(Slu , typeof(Person) );
        }
    }
}
