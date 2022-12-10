﻿// 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Ведите координату b1: ");
Double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите координату k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = -(b1 - b2)/ (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Пересечение в точке: ({x};{y})");