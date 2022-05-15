using System;
using System.Linq;
Console.Clear();

/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] array = new int[6].Select(x => new Random().Next(0, 100)).ToArray();
Console.WriteLine(string.Join(" ", array));

int max = array[0];
int min = array[0];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
    result = max - min;
}
Console.WriteLine($"{max} - {min} = {result}");
