// The Question;
// Implement function findRoots to find the roots of the quadratic equation
// ax^2 + bx + c = 0. The function should return an array 
// containing both roots in any order. If the equation has only one solution,
// the function should return that solution as both elements of the array.
// The equation will always have at least one solution.
// The roots of the quadratic equation can be found with the quadratic 
// equation formula x1,2 = (-b +- sqrt(b^2 - 4ac)) / 2a.

using System;

public class CalculateQuadraticEquation
{
    static double[] FindRoots(double a, double b, double c) 
    {
        double discriminant = (b * b) - (4 * a * c);
        double root1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
        double root2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
        return new double[] { root1, root2 };
    }

    static void Main() 
    {
        double a = 2;
        double b = 10;
        double c = 8;
        double[] roots = FindRoots(a, b, c);
        Console.WriteLine("Roots: [{0}, {1}]", roots[0], roots[1]);
    }
}