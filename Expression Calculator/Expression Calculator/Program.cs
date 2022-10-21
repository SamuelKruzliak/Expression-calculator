using System;
using System.Collections.Generic;
using System.Linq;

namespace Expression_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueParser.getValues("1+1");
            Console.WriteLine(Logic.result);
            Console.ReadLine();
        }
    }
}
