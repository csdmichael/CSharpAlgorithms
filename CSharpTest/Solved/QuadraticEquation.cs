using System;

public class QuadraticEquation
{
    public static Tuple<double, double> FindRoots(double a, double b, double c)
    {
        
        double x1, x2;
        x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        Tuple<double, double> roots;

        roots = new Tuple<double, double>(x1, x2);

        return roots;
    }

    /*
    public static void Main(string[] args)
    {
        Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
        Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
        Console.ReadLine();
    }
    */
}