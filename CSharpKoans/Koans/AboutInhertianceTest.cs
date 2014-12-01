using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    [TestFixture]
    public static class AboutInhertianceTest
    {
        [Test]
        public static void differenceBetweenOverloadingAndOverriding()
        {
         Parent firstParent =new Parent(); 
         Child  firstChild= new Child();

         Assert.AreEqual(firstParent.doStuff(), "parent");
         Console.WriteLine("Assert Parent");
         Console.WriteLine(firstParent.doStuff()=="parent");

         Assert.AreEqual(firstChild.doStuff(), "child");
         Console.WriteLine("Assert child");
         Console.WriteLine(firstChild.doStuff()=="child");

         Assert.AreEqual(firstChild.doStuff("hello world"),"hello world");
         Console.WriteLine("Assert child overide");
         Console.WriteLine(firstChild.doStuff("hello world") == "hello world");
        }
        public static void overriddenMethodsMayReturnSubType()
        {
            ChildTwo secondChild=new ChildTwo();
            List<string> list =(List<string>) secondChild.doStuff<string>();
            Assert.AreEqual((list is List<string>), true);
            Console.WriteLine("Assert is subtype");
            Console.WriteLine((list is List<string>)==true);
        }
    }
}
