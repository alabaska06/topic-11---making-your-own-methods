using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_11___making_your_own_methods
{
    static class MyMethods
    {
        /// <summary>
        /// This method returns the length of the hypotenuse of a right triangle when two legs are provided.
        /// </summary>
        /// <param name="a">>A double value representing the length of one leg in a right triangle.</param>
        /// <param name="b">>A double value representing the length of one leg in a right triangle.</param>
        /// <returns></returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        /// <summary>
        /// This method returns the length of the remaining leg of a right triangle when the hypotenuse and one leg is provided.
        /// </summary>
        /// <param name="a">A double value representing the length of one leg in a right triangle.</param>
        /// <param name="c">A double value representing the length of the hypotenuse in a right triangle.</param>
        /// <returns></returns>
        public static double GetLeg(double a, double c)
        {
            return Math.Sqrt(c * c - a * a);
        }

        /// <summary>
        /// This method takes in two double values, representing y-coordinates, and returns the rise (the change in y).
        /// </summary>
        /// <param name="y1"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double GetRise(double y1, double y2)
        {
            return y2 - y1;
        }

        /// <summary>
        /// This overloaded version of 'GetRise' internally extracts the y-coordinates from the 'Point' objects then calculates the rise using the previous version of the method that takes two 'double' values.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y);
        }

        /// <summary>
        /// This method takes in two double values, representing x-coordinates, and returns the run (the change in x).
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        public static double GetRun(double x1, double x2)
        {
            return x2 - x1;
        }

        /// <summary>
        /// This overloaded version of 'GetRun' internally extracts the x-coordinates from the 'Point' objects then calculates the run using the previous version of the method that takes two 'double' values.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double GetRun(Point p1, Point p2)
        {
            return GetRun(p1.X, p2.X);
        }

        /// <summary>
        /// This method with four 'double' parameters calculates the rise (difference in y-coordinates) and run (difference in x-coordinates) between the two points specified by coordinates and then calls the 'GetHypotenuse' method to calculate the distance.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            double rise = y2 - y1;
            double run = x2 - x1;
            return GetHypotenuse(rise, run);
        }

        /// <summary>
        /// This overloaded version of 'GetDistance' takes 'Point' objects and internally calculates the rise and run between the two points specified by the 'Point' ojects and then calls the 'GetHypotenuse' method to calculate the distance.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double GetDistance(Point p1, Point p2)
        {
            double rise = p2.Y - p1.Y;
            double run = p2.X - p1.X;
            return GetHypotenuse(rise, run);
        }

        /// <summary>
        /// This method with four 'double' parameters calculates the rise (difference in y-coordinates) and run (difference in x-coordinates) between the two points specified by coordinates, then it divides the rise by the run to calculate the slope.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double GetSlope(double x1, double y1, double x2, double y2)
        {
            double rise = y2 - y1;
            double run = x2 - x1;

            if (run == 0)
            {
                throw new ArgumentException("The slope is undefined for vertical lines where the run is zero.");
            }

            return rise / run;
        }

        /// <summary>
        /// This overloaded version of 'GetSlope' takes 'Point' objects and internally calculates the rise (difference in y-coordinates) and run (difference in x-coordinates) between the two points specified by coordinates, then it divides the rise by the run to calculate the slope.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double GetSlope(Point p1, Point p2)
        {
            double rise = p2.Y - p1.Y;
            double run = p2.X - p1.X;

            if (run == 0)
            {
                throw new ArgumentException("The slope is undefined for vertical lines where the run is zero.");
            }
            return rise / run;
        }
    }
}
