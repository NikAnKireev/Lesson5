using System;
Console.Clear();

/* **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да */

Console.WriteLine("Введите число: ");
int numbers = int.Parse(Console.ReadLine());

int[] array = GetArray(12, 0, 10);
Console.WriteLine(string.Join(", ", array));
int res = 0;

while (res<12)
{
    
    if (array[res]==numbers)
    {
        Console.WriteLine("Есть");
        res++;
    }
    else
    {
       Console.WriteLine("Нет");
       break;
    }
    res++;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}
