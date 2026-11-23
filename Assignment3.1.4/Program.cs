/*
Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s 
and changes their value to 0.

For e.g: Input : [0,2,1,1,9,1,1]

Output: [0,2,0,0,9,1,1]
*/



/*
Console.Write("Enter numbers separated by spaces or commas : ");
string inputText = Console.ReadLine();
int[] result = inputText
    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
*/


int[] myArr = new int[]{0,2,1,1,9,1,1};
int[] result = (FirstTwoOnesToZero(myArr));

Console.WriteLine("[" + String.Join(",", result) + "]");

int[] FirstTwoOnesToZero(int[] myArr)
{
    for (int i = 0; i < myArr.Length -1; i++)  // moving window along the array
    {
        if (myArr[i] == 1 && myArr[i + 1] == 1)
        {
            myArr[i] = 0;
            myArr[i + 1] = 0;
            break;
        }
    }
    return myArr;
}