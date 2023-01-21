﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void input_array(int [] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000); 
}

void release(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i]%2==0)
count++;
Console.WriteLine($"{count}");
}

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
release(array);


