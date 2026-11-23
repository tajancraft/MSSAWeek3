/*
Write a program in C# Sharp for addition of two Matrices of same size.

Test Data :

Input the size of the square matrix (less than 5): 2

Input elements in the first matrix :

element - [0],[0] : 1

element - [0],[1] : 2

element - [1],[0] : 3

element - [1],[1] : 4

Input elements in the second matrix :

element - [0],[0] : 5

element - [0],[1] : 6

element - [1],[0] : 7

element - [1],[1] : 8

Expected Output:

The First matrix is:

1 2

3 4

The Second matrix is :

5 6

7 8

The Addition of two matrix is :

6 8

10 12
*/



using System.ComponentModel.DataAnnotations;
using System.Drawing;

Console.Write("Input the size of the square matrix (less than 5): ");
int matrixSize = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Input elements in the first matrix :");
Console.WriteLine();
int[,] firstMatrix = CreateMatrix(matrixSize);

Console.WriteLine("Input elements in the second matrix :");
Console.WriteLine();
int[,] secondMatrix = CreateMatrix(matrixSize);

int[,] sumMatrix = new int[matrixSize, matrixSize];
for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            sumMatrix[i,j] = firstMatrix[i,j] + secondMatrix[i,j];
        }
    }

Console.WriteLine($"The First matrix is:");
Console.WriteLine();
WriteMatrix(firstMatrix);

Console.WriteLine($"The Second matrix is:");
Console.WriteLine();
WriteMatrix(secondMatrix);

Console.WriteLine($"The Addition of two matrix is :");
Console.WriteLine();
WriteMatrix(sumMatrix);

static int[,] CreateMatrix(int size)
{
    int[,] matrix = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write($"element - [{i},{j}] : ");
            matrix[i,j] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }
    return matrix;
}

static void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}