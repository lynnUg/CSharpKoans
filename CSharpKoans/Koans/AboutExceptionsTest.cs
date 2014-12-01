using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    [TestFixture]
    public static class AboutExceptionsTest
    {
      [Test]
      public static void catchCheckedExceptions()
        {
          String s;
          try
          {
              AboutExecptions.doStuff(null);
              s = "code run successfully";
          }
          catch(ArgumentNullException ex)
          {
              s = "exception happended";
          }
          Console.WriteLine("Assert caught exception");
          Console.WriteLine(s);
          Assert.AreEqual(s, "exception happended");
        }
      [Test]
      public static void useFinally()
      {
          String s="";
          try
          {
              AboutExecptions.doStuff(null);
              s = "code run successfully";
          }
          catch (ArgumentNullException ex)
          {
              s = "exception happended";
          }
          finally
          {
              s += " and it finally run as well";
          }
          Console.WriteLine("Assert used finally");
          Console.WriteLine(s);
          Assert.AreEqual(s, "exception happended and it finally run as well");
         
      }
    }
}
