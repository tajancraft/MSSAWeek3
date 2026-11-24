/*
Sum digits in string

Given a string, write a method which returns sum of all digits in that string. 
Assume that string contains only single digits.

Expected input and output

SumDigitsInString("1q2w3e") → 6 SumDigitsInString("L0r3m.1p5um") → 9

SumDigitsInString("") → 0
*/

using System;
using System.Globalization;

int sum = 0;

Console.WriteLine($"Write a string to sum all digits :");
string readText = Console.ReadLine();
SumOfAllDigits(readText);
Console.WriteLine($"Sum of all digits in your string \"{readText}\" is : {sum}");

int SumOfAllDigits(string readText)
{
    if (string.IsNullOrEmpty(readText))
        return 0;
    
    for (int i = 0; i < readText.Length; i++)
    {
        if (char.IsDigit(readText[i]))
        {
            sum += readText[i] - '0';
        }    
    }
    /*
    foreach (char c in readText)
    {
        if (char.IsDigit(c))
        {
            sum += c - '0'; 
        }
    }
    */
    return sum;    
} 
