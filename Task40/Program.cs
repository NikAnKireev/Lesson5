using System;
using System.Linq;
Console.Clear();

/* **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
<aside>
❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

</aside>
 */

int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());

string tringle = (a1 <= a2 + a3 && a2 <= a1 + a3 && a3 <= a1 + a2)? "да":"нет";
Console.WriteLine(tringle);