using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    
        public class Parent
        {
            public virtual String doStuff() { return "parent"; }
        }
        public class Child : Parent
        {
            public override String doStuff()
            {
                return "child";
            }
            public String doStuff(String s)
            {
                return s;
            }
        }

       public abstract class ParentTwo
       {
           abstract public IList<T> doStuff<T>();
       }
       public  class ChildTwo :ParentTwo
        {
           public override IList<T> doStuff<T>()
            {
                return new List<T>();
            }
           
        }
    
}
