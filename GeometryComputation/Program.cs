namespace GeometryComputation
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
            Console.WriteLine($"Provided co-ordinates (x1,y1):({x1},{y1})  &  (x2,y2):({x2},{y2})");
            return d1;
        }
        public static void EqualsMethod(double line1Distance, double line2Distance)
        {
            bool EqualsStatus = line1Distance.Equals(line2Distance);
            if (EqualsStatus)
            {
                Console.WriteLine("Length value of both Line 1 and Line 2 are EQUAL");
            }
            else
            {
                Console.WriteLine("Length value of Line 1 and Line 2 are NOT equal");
            }
        }

        public static void CompareMethod(double line1Distance, double line2Distance)
        {
            int CompareToStatus = line1Distance.CompareTo(line2Distance);
            if (CompareToStatus == 0)
            {
                Console.WriteLine("Both first and second lines are having Equal Length.");
            }
            else if (CompareToStatus < 0)
            {
                Console.WriteLine("Length of first line is less than second line.");
            }
            else
            {
                Console.WriteLine("Length of first line is greater than second line.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line computation Program");
            Console.WriteLine("Takinng You To First Coordinates of Line1");
            double Line1Distance = GeometryLineComputation.LineDistance();
            Console.WriteLine("Found Line 1 Length Value :{Line1Distance}");
            Console.WriteLine("Taking you To Second Coordinates of Line2");
            double Line2Distance = GeometryLineComputation.LineDistance();
            Console.WriteLine("Found Line 2 Length Value :{Line2Distance}");
            Console.WriteLine();
            Console.WriteLine($"So Finally get Line 1 Length Value :{Line1Distance} & Line 2 Length Value :{Line2Distance}");

            Console.Write("Using Equals Method output is :::: ");
            GeometryLineComputation.EqualsMethod(Line1Distance, Line2Distance);

            Console.WriteLine("Using Compare Method output is ::::");
            GeometryLineComputation.CompareMethod(Line1Distance, Line2Distance);

        }
    }
}