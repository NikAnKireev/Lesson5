using System;
using System.Linq;
Console.Clear();

/* **Задача 39:** Напишите программу, которая перевернёт одномерный 
массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]

[6 7 3 6] -> [6 3 7 6] */

int lenght = 10;
int[] array = new int[lenght].Select(x => x = new Random().Next(0, 20)).ToArray();

Console.WriteLine(string.Join(" ", array));

for (int i = 0; i < lenght / 2; i++)
{
    int k = array[i];
    array[i] = array[lenght - i - 1];
    array[lenght - i - 1] = k;
}
Console.WriteLine(string.Join(" ", array));

int[] array1 = new int[lenght];

for (int i = 0; i < lenght; i++)
{
    array1[lenght - i - 1] = array[i];
}
Console.WriteLine(string.Join(" ", array1));
/* int[] array = new int[5].Select(x => x = new Random().Next(0, 10)).ToArray();
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", array.Reverse())); */
