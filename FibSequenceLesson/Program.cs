﻿using System;
using System.Collections.Generic;

namespace FibSequenceLesson
{ 
    class Program
    { 

/*You are to calculate the average of the sequence of the fibinacci sequence that
that ends with the first number greater than 200.  Store the generate numbers
in a List<int> collection then calculate the average and display it using a Console.Writeline
statement
code sample
var x = 0;
var y = 1;
var z = x + y;
x = 1;  this was y value
y = 1;  this was z value

x = y;
y = z;

    */
    static void Main(string[] args)
    { 
        List<int> fibs = Fib.GenerateSequence(200);
        var sum = 0;
        foreach (var fib in fibs)
            sum = sum + fib;
        {
            var avg = sum / fibs.Count;
            Console.WriteLine($"The average of the Fib Seq is {avg} ");
        }


    }
    }
}

