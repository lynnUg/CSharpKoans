using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    class A
    {
        public String someString = "a";
        public A()
        {
            someString += "x";
        }
    }
    class B : A
    {
        public B()
        {
            someString += "g";
        }
    }
    class Aa
    {
        public String someString = "a";
        public Aa()
        {
            someString += "x";
        }
        public Aa(String s)
        {
            someString += s;
        }
    }
    class Bb : Aa
    {
        public Bb()
        : base("Boo")
        {
            someString += "g";

        }
    }
}
