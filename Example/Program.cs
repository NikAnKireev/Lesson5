﻿using System;
using System.Linq;

//int[] array=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
//int[] array1=array.Select(x=>x*-1).ToArray();
//int size=int.Parse(Console.ReadLine());
int[] array2=new int[int.Parse(Console.ReadLine())].Select(x=>new Random().Next(0,100)).ToArray();
//Console.WriteLine(String.Join(" ",array));
//Console.WriteLine(String.Join(" ",array1));
Console.WriteLine(String.Join(" ",array2));

/* 
int[] k=new int[20].Select(x=>new Random().Next(0,1000)).Where(x=>x>=9&&x<=100).ToArray();
Console.WriteLine(String.Join(" ",k));
*/