using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine("TYPES OF TRIANGLE");
        Console.WriteLine("Enter the lengths of the three sides of the triangle separated by spaces:");
        string[] parts = Console.ReadLine().Split(' ');
        double a = double.Parse(parts[0]);
        double b = double.Parse(parts[1]);
        double c = double.Parse(parts[2]);

        string triangleType = GetTriangleType(a, b, c);

        Console.WriteLine($"Triangle Type: {triangleType}");
    }

    static string GetTriangleType(double a, double b, double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            return "Invalid";
        }
        else if (a == b && b == c)
        {
            return "Equilateral";
        }
        else if (a == b || a == c || b == c)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}
