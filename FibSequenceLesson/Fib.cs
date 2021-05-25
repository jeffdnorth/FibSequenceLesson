using System;
using System.Collections.Generic;
using System.Text;

namespace FibSequenceLesson
{
    class Fib
    {
        //method static is a variable, but this is a static method (properties can be static as well)
        //this is a static method   you can execute them without creating a sequence of a class
        public static List<int> GenerateSequence(int last = 200)
        {
            var fibs = new List<int>();
            var a = 0;
            fibs.Add(a);
            var b = 1;
            fibs.Add(b);
            int c = 0;
            while(c < last)
            {
                c = a + b;
                fibs.Add(c);
                a = b;
                b = c;
            }
            return fibs;
        }
    }
}
