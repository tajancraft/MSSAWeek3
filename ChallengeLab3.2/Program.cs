/*
Sum digits in string

Given a string, write a method which returns sum of all digits in that string. 
Assume that string contains only single digits.

Expected input and output

SumDigitsInString("1q2w3e") → 6 SumDigitsInString("L0r3m.1p5um") → 9

SumDigitsInString("") → 0
*/

using System.Linq.Expressions;

int sum = 0;

Console.WriteLine($"Write a string to sum all digits :");
string readText = Console.ReadLine();
sumOfAllDigits(readText);

int SumOfAllDigits(string readText)
{
    for (int i = 0; i < readText.Length; i++)
    {
            
    }
}