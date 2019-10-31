using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint p1 = new MyPoint();  // Test constructor
            Console.WriteLine(p1);      // Test toString()
            p1.setX(8);   // Test setters
            p1.setY(6);
            Console.WriteLine("x is: " + p1.getX());  // Test getters
            Console.WriteLine("y is: " + p1.getY());
            p1.setXY(3, 0);   // Test setXY()
            Console.WriteLine(p1.getXY()[0]);  // Test getXY()
            Console.WriteLine(p1.getXY()[1]);
            Console.WriteLine(p1);

            MyPoint p2 = new MyPoint(0, 4);  // Test another constructor
            Console.WriteLine(p2);
            // Testing the overloaded methods distance()
            Console.WriteLine(p1.Distance(p2));    // which version?
            Console.WriteLine(p2.Distance(p1));    // which version?
            Console.WriteLine(p1.Distance(5, 6));  // which version?
            Console.WriteLine(p1.Distance());  
        }
    }
}
