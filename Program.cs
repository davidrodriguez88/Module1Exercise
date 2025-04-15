using System;
using System.Security.Principal;

namespace ShapeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for circle radius
            Console.WriteLine("Enter the radius of the circle:");
            //Read what the user types
            string radiusInput = Console.ReadLine();
            //Convert text to number
            double radius = Convert.ToDouble(radiusInput);
            //Call the method
            double circleArea = CalculateCircleArea(radius);
            //Display result to user
            Console.WriteLine($"The area of the circle is: {circleArea}");


            //Prompt user for Triangle base measurement
            Console.WriteLine("Enter the base length measurement of the triangle:");
            //Read base input
            string baseLengthInput = Console.ReadLine();
            double triangleBaseLength = Convert.ToDouble(baseLengthInput);
            //Prompt user for Triangle height measurement
            Console.WriteLine("Enter the height measurement of the triangle:");
            //Read height input
            string heightInput = Console.ReadLine();
            double triangleHeight = Convert.ToDouble(heightInput);
            //Call Triangle area method
            double triangleArea = CalculateTriangleArea(triangleBaseLength, triangleHeight);
            //Display the result
            Console.WriteLine($"The area of the triangle is: {triangleArea}");


            //Prompt the user for rectangle length
            Console.WriteLine("Enter the length of the rectangle:");
            //Read length input
            string lengthInput = Console.ReadLine();
            //Convert text to number
            double length = Convert.ToDouble(lengthInput);
            //Prompt user for width input
            Console.WriteLine("Enter the width of the rectangle:");
            //Read width input
            string widthInput = Console.ReadLine();
            //Convert text to number
            double width = Convert.ToDouble(widthInput);
            //Call the rectangle area method
            double rectangleArea = CalculateRectangleArea(length, width);
            //Display the result
            Console.WriteLine($"The area of the rectangle is: {rectangleArea}");


            //Prompt the user for square side
            Console.WriteLine("Enter the side measurement of the square:");
            //Read side input
            string sideInput = Console.ReadLine();
            //Convert text to number
            double side = Convert.ToDouble(sideInput);
            //Call square area method
            double squareArea = CalculateSquareArea(side);
            //Display the result
            Console.WriteLine($"The area of the square is: {squareArea}");
        }
            
            //Area of a circle method
        public static double CalculateCircleArea(double radius)
        {
            //Area of circle formula: Area = pi * r^2
            return 3.14 * radius * radius;
        }
            //Area of a triangle method
        public static double CalculateTriangleArea(double triangleBaseLength, double triangleHeight)
        {
            return 0.5 * triangleBaseLength * triangleHeight;
        }
            //Area of a rectangle method
        public static double CalculateRectangleArea(double length, double width)
        {
            //Area of a rectangle formula
            return length * width;
        }
            //Area of a square method
        public static double CalculateSquareArea(double side)
        {
            //Area of a square formula
            return side * side;
        }
    }
}

