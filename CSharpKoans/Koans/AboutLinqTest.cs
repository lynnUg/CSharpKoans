using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    [TestFixture]
    public static class AboutLinqTest
    {
        [Test]
        public static void simpleLinqQuery()
        {
            string[] strings = { "one", "two", null, "three" };

            IEnumerable<string> ieStrings = strings.Where(s => s != null ? s.Length == 3 : false);

            foreach (string s in ieStrings)
            {
                Console.WriteLine("Processing " + s);
            }
            Assert.AreEqual(ieStrings.ToList().Count, 2);

        }
        [Test]
        public static void addDataAfterLinqQuery()
        {
            List<string> strings = new List<string>();
            strings.Add("one");
            strings.Add("two");
            strings.Add("three");

            IEnumerable<string> ieStrings = strings.Where(s => s.Length == 3);
            foreach (string s in ieStrings)
            {
                Console.WriteLine("Processing " + s);
            }

            Console.ReadKey();
            strings.Add("six");
            Console.WriteLine("source enumerable changed but query is not invoked again");
            
            foreach (string s in ieStrings)
            {
                Console.WriteLine("Processing " + s);
            }
            Assert.AreEqual(ieStrings.ToList().Count, 3);
        }
        [Test]
        public static void complexLinqQuery()
        {

        }
    }
}
