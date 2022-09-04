﻿// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int sizeArray = 4;

int[,] numbers = new int[sizeArray, sizeArray];

int num = 1;
int i = 0;
int j = 0;

while (num <= numbers.GetLength(0) * numbers.GetLength(1))
{
    numbers[i, j] = num;
    if (i <= j + 1 && i + j < sizeArray - 1)
        ++j;
    else if (i < j && i + j >= sizeArray - 1)
        ++i;
    else if (i >= j && i + j > sizeArray - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}