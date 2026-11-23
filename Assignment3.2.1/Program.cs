/*
Create a 2D array to store integers and print them in matrix format with 
proper formatting.

e. g:

| 2 | 3 | 4 |

| 1 | 4 | 6 |
*/

using System;
using System.Text;

int[,] myArrTwoD = 
{
	{ 2, 3, 4 },
	{ 1, 4, 6 }
};

/*
int largestNum = FindLargestNumber(myArrTwoD);
int digitCount = CountDigits(largestNum);
*/

for (int i = 0; i < myArrTwoD.GetLength(0); i++)
{
    for (int j = 0; j < myArrTwoD.GetLength(1); j++)
    {
        Console.Write($"| {myArrTwoD[i, j]} ");
    }
    Console.WriteLine("|");
    Console.WriteLine();
}

/*
static int FindLargestNumber(int[,] myArr)
{    
    int largest = myArr[0, 0];
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            if (myArr[i, j] > largest)
            {
                largest = myArr[i, j];
            }
        }
    }
    return largest;
}

static int CountDigits(int myNum)
{
    myNum = Math.Abs(myNum);
    if (myNum == 0) return 1;

    int count = 0;
    while (myNum > 0)
    {
        myNum /= 10;
        count++;
    }
    return count;
}
*/