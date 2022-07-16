﻿// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Пользователь вводит две пары вещественных чисел: k1,b1 и k2,b2. Составить
// функцию для определения точки пересечения двух прямых y=k1x+b1 и y=k2x+b2, которая
// получает введенные числа в качестве параметров. Координаты найденной точки
// пересечения функция возвращает в качестве двух других параметров.
// Результат, который возвращает сама функция, должен позволять отслеживать
// следующие случаи(зависящие от значений введенных чисел): прямые параллельны(нет
// точек пересечения), прямые совпадают(бесконечное число точек пересечения).
System.Console.Write("Задайте значения k1, b1, k2, b2 :\t");
string[] numbers = Console.ReadLine()!.Split(",");
double k1 = double.Parse(numbers[0]);
double b1 = double.Parse(numbers[1]);
double k2 = double.Parse(numbers[2]);
double b2 = double.Parse(numbers[3]);

void FindCrossPoint(double k1, double b1, double k2, double b2)
{ if (k1 == k2)
    {
        if (k1 == k2 && b1 == b2) Console.WriteLine($"Прямые совпадают"
                                         + " и имеют бесконечное множество точек пересечения.");
        else Console.WriteLine($"Прямые параллельны друг другу и не имеют точек пересечения.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);;
        double y = k2 * x + b2;
        Console.WriteLine($"Точки пересечения двух прямых [{x};{y}].");
        if (k1 * k2 == 0) Console.WriteLine("Прямые перпендикулярны.");
    }
}

FindCrossPoint(k1, b1, k2, b2);