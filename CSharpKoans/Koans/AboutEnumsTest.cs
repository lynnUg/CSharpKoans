using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    [TestFixture]
    public static class AboutEnumsTest
    {
        [Test]
        public static void basicEnums()
        {
            Colors blue = Colors.Blue;

            Assert.AreEqual(blue == Colors.Blue, true);
            Console.WriteLine("Assert enum blue");
            Console.WriteLine(blue == Colors.Blue);

            Assert.AreEqual(blue == Colors.Red, false);
            Console.WriteLine("Assert enum isnot red");
            Console.WriteLine(blue == Colors.Red);

            Assert.AreEqual((blue is Colors), true);
            Console.WriteLine("Assert is enum ");
            Console.WriteLine((blue is Colors));
        }
    }
}
