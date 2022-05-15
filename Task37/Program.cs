using System;
using System.Linq;
Console.Clear();

/* **Задача 37:** Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21 */

int[] array = new int[int.Parse(Console.ReadLine())].Select(x => new Random().Next(1, 10)).ToArray();
Console.WriteLine(String.Join(" ", array));

int sum = 0;

for (int i = 0; i < array.Length / 2; i++)
{
    sum = array[i] * array[array.Length - i - 1];
    Console.Write($"{sum} ");
}
if (array.Length % 2 == 1) Console.Write(array[array.Length/2]);
