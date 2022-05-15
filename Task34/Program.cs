using System;
using System.Linq;
Console.Clear();

/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] array = new int[5].Select(x => new Random().Next(100, 999)).ToArray();

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        count++;
}
Console.WriteLine($"{String.Join(" ", array)} -> {count}");
