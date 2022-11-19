using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryComputation
{
    internal class GeometryLineComputation
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Geometry computation on Line Comparison program!\n");
        }
        static void Main(string[] args)
        {
            Welcome();
            Console.WriteLine("Taking you to enter coordinates of Line 1");
            double line1Distance = LineComparsion.LineDistance();         
            Console.WriteLine("Taking you to enter coordinates of Line 2");
            double line2Distance = LineComparsion.LineDistance();
            LineComparsion.EqualsMethod(line1Distance, line2Distance);
            LineComparsion.CompareMethod(line1Distance, line2Distance);        
        }
    }
}
