/*
Given a string, write a method that checks if it is a palindrome 
(is read the same backward as forward). 
Assume that string may consist only of lower-case letters.

Expected input and output

IsPalindrome("eye") → true

IsPalindrome("home") → false
*/

Console.WriteLine($"Write a string to check if it is a palindrome");
string readText = Console.ReadLine();

Console.WriteLine(IsPalindrome(readText));

bool IsPalindrome(string readText)
{
    for (int i = 0; i < readText.Length/2; i++)
    {
        if (readText[i] != readText[readText.Length-1-i])
            return false;
        
    }
    return true;
}
