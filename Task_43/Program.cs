﻿/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


double IntersectionPoint(double k1, double b1, double k2, double b2)
{
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
 
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    return y;
    return x;
}


Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(k1, b1, k2, b2);
double x = IntersectionPoint(k1, b1, k2, b2);
double y = IntersectionPoint(k1, b1, k2, b2);

Console.WriteLine($"Пересечение в точке: ({x};{y})");