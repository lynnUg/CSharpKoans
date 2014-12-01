using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKoans.Koans
{
    public static class AboutExecptions
    {
        public static void doStuff(string value)
        {
            if (value==null)
            {
                throw new ArgumentNullException("value");
            }
        }
    }
}
