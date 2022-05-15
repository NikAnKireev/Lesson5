using System;
using System.Linq;
Console.Clear();

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 26

[-4, -6, 89, 6] -> 85 */

int[] array = new int[5].Select(x => new Random().Next(-100, 100)).ToArray();

int summa = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        summa = summa + array[i + 1];
    }
}
Console.WriteLine($"{String.Join(" ", array)} -> {summa}");