using System;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize two interger variables
            
            int a = 17;
            int b = 4;

            // Perform arithmetic operations

            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            // Perform divison and modulus operations

            int quotient = a / b;
            int remainder = a % b;

            // Display the results using string interpolation

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {difference}");
            Console.WriteLine($"{a} * {b} = {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}.");

            Console.WriteLine("Enter the radius of the circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }

        // Define a method - Which performs some functionality that can be used over and over

        public static double AreaOfCircle(double radius)
        {
            // Scope of this method
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
