﻿// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void CubeTable(int N)
{
    int count = 1;
    while(count<=N)
    {
        double result = Math.Pow(count,3);
        Console.Write(result + ",");
        count++;
    }
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
CubeTable(n);

