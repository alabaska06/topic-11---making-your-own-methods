﻿using System;
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

        /// <summary>
        /// Takes 3 side lenghths of a triangle, and determines weather it is a right triangle.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsRight(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        /// <summary>
        /// Takes in a minimum, maximum, and size as parameters, and returns a list of 'size' intergers filled with random numbers between 'min' and 'max'.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static List<int> GetRandomList(int min, int max, int size)
        {
            Random generator = new Random();
            List<int> randomList = new List<int>();

            for (int i = 0; i < size; i++)
            {
                randomList.Add(generator.Next(min, max + 1));
            }

            return randomList;
        }

        /// <summary>
        /// Takes in a minimum, maximum and size as parameters, and returns an array of 'size' intergers filled with random numbers between 'min' and 'max'.
        /// <summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int[] GetRandomArray(int min, int max, int size)
        {
            int[] randomArrayList = new int[min, max];

            for (int i = 0; i<size; i++)
            {
                randomArrayList[i] = generator.Next(1, 101);
            }
            return randomArrayList;
        }

        /// <summary>
        /// This method takes in a string and returns the reversed version.
        /// <summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string Reverse(string word)
        {
            string backwards = "";
            for (int i = word.Length - 1; i >=; i++)
            {
                backwards = backwards + word.Substring(i, 1);
            }

            backwards = "";

            for int i = 0; i < word.Length; i++)
            {
                backwards = word.Substring(i, 1) + backwards;
            }

            return backwards;
        }

        /// <summary>
        /// Takes in a minimum, maximum and size as parameters, and returns the average from the 'size' numbers randomly generated from between the 'min' and 'max'.
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="size"></param>
        /// <param name="average"></param>
        /// <returns></returns>
        public static List<double> Average(double min, double max, double size, double average)
        {
            List<double> numbers = new List<double>();

            for (int i = 0; i < size; i++)
            {
                numbers.Add(generator.Next(min, max + 1));
            }

            var total = 0;

            foreach (double number in numbers)
            {
                total += number;
            }

            average = total / numbers.Length();

            return average;

        }



    }
}
