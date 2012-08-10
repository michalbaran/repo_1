using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mcMath;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            long a, b, result;
            a = 5;
            b = 10;

            //new obj
            Class1 cls_obj = new Class1();
               

            //add
            result = cls_obj.Add(a, b);

            //print to console
            Console.WriteLine(result.ToString() );

            //only wait
            Console.ReadLine();

        }
    }
}
