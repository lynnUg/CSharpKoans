using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    [TestFixture]
    public static class AboutConstructorTest
    {
        [Test]
        public static void simpleConstructorOrder()
        {
            Console.WriteLine("creating simple constructors");
            Console.WriteLine(new B().someString);
            Assert.AreEqual(new B().someString, "axg");
        }
        [Test]
        public static void complexConstructorOrder()
        {
            Console.WriteLine("creating complex constructors");
            Console.WriteLine(new Bb().someString);
            Assert.AreEqual(new Bb().someString, "aBoog");
        }

    }
}
