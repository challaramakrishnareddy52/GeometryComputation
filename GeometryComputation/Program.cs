﻿namespace GeometryComputation
{
    internal class GeometryLineComputation
    {
        public static double LineDistance()
        {
            Console.WriteLine("Enter the first coordinates x1 and x2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinates y1 and y2");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double d1 = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
            Console.WriteLine($"First coordinates is {x1},{y1} & Second coordinates is {x2},{y2}");
            return d1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line computation Program");
            Console.WriteLine("Takinng You To First Coordinates of Line1");
            double Line1Distance = GeometryLineComputation.LineDistance();
            Console.WriteLine("Found Line 1 Lentgh Value :{Line1Distance}");
            Console.WriteLine("Taking you To Second Coordinates of Line2");
            double Line2Distance = GeometryLineComputation.LineDistance();
            Console.WriteLine("Found Line 2 Lentgh Value :{Line2Distance}");
            Console.WriteLine($"So Finally get Line 1 Lentgh Value :{Line1Distance} & Line 2 Lentgh Value :{Line2Distance}");
              
        }
    }
}