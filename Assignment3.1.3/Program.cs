/*
Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
*/

using System.Text;

Console.WriteLine("Please write the text to count spaces");
StringBuilder inputText = new StringBuilder(Console.ReadLine());

int numSpace = CountTheSpaces(inputText);
Console.WriteLine($"\"{inputText}\" contains {numSpace} spaces");

int CountTheSpaces(StringBuilder inputText)
{
    int countSpace = 0;
    for (int i = 0; i < inputText.Length; i++)
    {
        if (inputText[i] == ' ')
        {
            countSpace++;
        }
    }
    return countSpace;
}