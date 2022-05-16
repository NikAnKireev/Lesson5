using System;
using System.Linq;
Console.Clear();

/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/

int[] array = new int[5].Select(x => x = new Random().Next(0, 10)).ToArray();
Console.WriteLine(String.Join(" ", array));

int[] copyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < newArray.Length; i++)
        newArray[i] = arr[i];
    return newArray;

}
Console.WriteLine(String.Join(" ", copyArray(array)));