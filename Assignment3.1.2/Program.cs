/*
If year is leap

Given a year as integer, write a method that checks if year is leap.

Expected input and output

IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false
*/
Console.WriteLine("Enter the year you would like to test");
Console.WriteLine(IfYearIsLeap(int.Parse(Console.ReadLine())));

static bool IfYearIsLeap(int year)
{
    return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
}