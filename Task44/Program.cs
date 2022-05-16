using System;
using System.Linq;
Console.Clear();

/*
**Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3

Если N = 3 -> 0 1 1

Если N = 7 -> 0 1 1 2 3 5 8
*/

int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
int[] fib = new int[a3];
fib[0] = a1;
fib[1] = a2;

for (int i = 2; i < fib.Length; i++)
{
    fib[i] = fib[i - 1] + fib[i - 2];
}
Console.WriteLine(string.Join(" ", fib));