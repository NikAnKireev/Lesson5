using System;
Console.Clear();

/* **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] array = GetArray(4, -9, 9);
Console.WriteLine(string.Join(" ", array));
int sum = 0;

while (sum < 4)
{
    Console.Write($"{array[sum] * -1} ");
    sum++;
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