using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            float point1X, point1Y, point2X, point2Y;

            Console.WriteLine("Welcome \n This application will calculate the distance between two points and the angle between those points");


            Console.WriteLine("Enter Point 1 X:");
            point1X = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Point 1 Y:");
            point1Y = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Point 2 X:");
            point2X = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Point 2 Y:");
            point2Y = float.Parse(Console.ReadLine());


            float deltaX, deltaY;

            deltaX = point1X - point2X;

            deltaY = point1Y - point2Y;


        }
    }
}
