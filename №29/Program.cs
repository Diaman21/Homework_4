﻿//  Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33       -> [6, 1, 33]

int arrayLength = 8;
int[] array = new int[arrayLength];

FillArray(array);
PrintArray(array);
Sorting(array);
PrintArray(array);

void Sorting(int[] array)
{
    int arLength = array.Length;
    for (int j = 0; j < arLength; j++)
    {
        for (int i = 0; i < arLength - 1; i++)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[i + 1]))
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }
    }
}

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 10);
    }
}

void PrintArray(int[] x)
{
    int count = x.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}