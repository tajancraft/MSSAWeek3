/*
Create a function that finds the index of a given item in the array

Examples

Search([1, 5, 3], 5) ➞ 1

Search([9, 8, 3], 3) ➞ 2

Search([1, 2, 3], 4) ➞ -1

Notes

If the item is not present, return -1.
*/

Console.Write("Enter the number of elements : ");
int size = int.Parse(Console.ReadLine());

int[] myArr = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Enter number{i + 1} : ");
    myArr[i] = int.Parse(Console.ReadLine());
}

Console.Write("Enter the item to search : ");
int pickNum = int.Parse(Console.ReadLine());

int index = FindTheIndexOF(myArr, pickNum);
Console.WriteLine($"Index of {pickNum} : {index}");

int FindTheIndexOF(int[] myArr, int pickNum)
{
    for (int i = 0; i < myArr.Length; i++)
    {
        if (myArr[i] == pickNum)
        {
            return i;
        }
    }
    return -1;
}