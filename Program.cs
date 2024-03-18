using System.Drawing;

namespace topic_11___making_your_own_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetHypotenuse Method:");
            Console.WriteLine(MyMethods.GetHypotenuse(3, 4));
            //or
            Double hypotenuse = MyMethods.GetHypotenuse(3, 4);
            Console.WriteLine($"The hypotenuse is {hypotenuse} cm\n");

            Console.WriteLine("GetLeg Method:");
            Console.WriteLine(MyMethods.GetLeg(3, 5));
            //or
            Double remainingLeg = MyMethods.GetLeg(3, 5);
            Console.WriteLine($"The remaining leg is {remainingLeg} cm\n");

            Console.WriteLine("GetRise Method (double values):");
            double rise1 = MyMethods.GetRise(10.0, 15.0);
            Console.WriteLine($"Rise between y1 and y2: {rise1}\n");

            Console.WriteLine("GetRise Method (point objects):");
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            double rise2 = MyMethods.GetRise(p1, p2);
            Console.WriteLine($"Rise Between p1 and p2: {rise2}\n");

            Console.WriteLine("GetRun Method (double values):");
            double run1 = MyMethods.GetRun(3.0, 7.0);
            Console.WriteLine($"Run between x1 and x2: {run1} \n");

            Console.WriteLine("GetRun Method (point objects):");
            //Im using the same set variable for Point p1 and p2 as the GetRise Method
            double run2 = MyMethods.GetRun(p1, p2);
            Console.WriteLine($"Run between p1 and p2: {run2}\n");

            Console.WriteLine("GetDistance Method (double values):");
            double distance1 = MyMethods.GetDistance(3.0, 4.0, 7.0, 1.0);
            Console.WriteLine($"Distance between (x1, y1) and (x2, y2): {distance1}\n");

            Console.WriteLine("GetDistance Method (point objects):");
            //Im using the same set variable for Point p1 and p2 as the GetRise Method
            double distance2 = MyMethods.GetDistance(p1, p2);
            Console.WriteLine($"Distance between p1 and p2: {distance2}\n");

            Console.WriteLine("GetSlope Method (double values):");
            double slope1 = MyMethods.GetSlope(3.0, 4.0, 7.0, 1.0);
            Console.WriteLine($"Slope between (x1, y1) and (x2, y2): {slope1}\n");

            Console.WriteLine("GetSlope Method (point objects):");
            //Im using the same set variable for Point p1 and p2 as the GetRise Method
            double slope2 = MyMethods.GetSlope(p1, p2);
            Console.WriteLine($"Slope between p1 and p2: {slope2}\n");

            Console.WriteLine("IsRight Method:");
            if (MyMethods.IsRight(3, 4, 5))
            {
                Console.WriteLine("The triangle is a right triangle.");
            }
            else
            {
                Console.WriteLine("The triangle is not a right triangle.");
            }
            Console.WriteLine();

            Console.WriteLine("GetRandomList Method:");
            List<int> randomNumbers = MyMethods.GetRandomList(1, 100, 10);
            Console.WriteLine("Random Numbers:");
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
