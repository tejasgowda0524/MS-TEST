using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunits
{
    [TestFixture]
     class Class2
    {
        static void Main(string[] args)
        {
            [TestCase]
             void add()
            {
                Console.WriteLine("hello");
            }
            [TestCase]
             void sub()
            {
                Console.WriteLine("hello removed");
            }
        }
        
    }
}
