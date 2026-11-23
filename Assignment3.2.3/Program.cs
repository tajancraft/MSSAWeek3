/*
Create a console application to overload “+” and “-“ operator for adding 
the areas of 2 circles and getting their area difference respectively.
*/

Console.Write("Enter radius of the first circle : ");
Circle firstCir = new Circle(double.Parse(Console.ReadLine()));

Console.Write("Enter radius of the second circle : ");
Circle secondCir = new Circle(double.Parse(Console.ReadLine()));

Console.WriteLine();
Console.WriteLine($"Area of first circle   : {firstCir.Area():F2}");
Console.WriteLine($"Area of second circle  : {secondCir.Area():F2}");
Console.WriteLine($"Sum of the areas       : {(firstCir + secondCir):F2}");
Console.WriteLine($"Difference of the areas: {(firstCir - secondCir):F2}");

public class Circle
{
    public double Radius {get; set;}
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public static double operator +(Circle firstCir, Circle secondCir)
    {
        return firstCir.Area() + secondCir.Area();
    }

    public static double operator -(Circle firstCir, Circle secondCir)
    {
        return Math.Abs(firstCir.Area() - secondCir.Area());
    }
}