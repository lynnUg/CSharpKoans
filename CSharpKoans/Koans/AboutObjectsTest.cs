using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    [TestFixture]
    public static class AboutObjectsTest
    {
        [Test]
        public static void newObjectInstancesCanBeCreatedDirectly()
        {
            Console.WriteLine("Creating new instance on fly");
            Console.WriteLine(new Object() is Object);
            Assert.AreEqual(new Object() is Object,true);

        }
       [Test]
        public static void allClassesInheritFromObject()
        {
            AboutObjects ob = new AboutObjects();
            Console.WriteLine("Classes inherit from objects");
            List<Type> ancestors = getAncestors(ob);
            Console.WriteLine(ancestors[0]==ob.GetType());
            Console.WriteLine(ancestors[1]==ob.GetType().BaseType );
            Assert.AreEqual(ancestors[0] , ob.GetType());
            Assert.AreEqual(ancestors[1] ,ob.GetType().BaseType);


        }
        
        private static List<Type> getAncestors(Object ob)
        {
		  List<Type> ancestors = new List<Type>();
		  Type clazz = ob.GetType();
		  while(clazz != null) 
          {
			ancestors.Add(clazz);
			clazz = clazz.BaseType;
	
		  }
		  return ancestors;	
	   }

        [Test]
        public static void objectToString()
        {
            AboutObjects ob = new AboutObjects();
            Console.WriteLine("Object to string");
            String expected = ob.GetType().ToString();
            Console.WriteLine(ob.ToString()==expected);
            Assert.AreEqual(ob.ToString(), ob.GetType().ToString());

        }
    }
}
