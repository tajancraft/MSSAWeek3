/*
Write a function that takes 4 numbers as input to calculate the total and average.
(Make use of params array to pass arguments and out parameters to return both total 
and average to main method).
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the fourth number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18.75
The total is 75
*/

using System;
using System.Numerics;

int total = 0;
double average = 0;

Console.Write($"Enter the First number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write($"Enter the Second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write($"Enter the Third number: ");
int num3 = int.Parse(Console.ReadLine());

Console.Write($"Enter the Fourth number: ");
int num4 = int.Parse(Console.ReadLine());

CalculateAvgAndTotal(out total, out average, num1, num2, num3, num4);

Console.WriteLine();
Console.WriteLine($"The average of {num1} {num2} {num3} {num4} is: {average}");
Console.WriteLine($"The total is {total}");
Console.WriteLine();

void CalculateAvgAndTotal(out int total, out double average, params int[] numbers)
{
    total = 0;
    foreach (int n in numbers)
    {
        total += n;
    }
    average = (double)total / numbers.Length;
}