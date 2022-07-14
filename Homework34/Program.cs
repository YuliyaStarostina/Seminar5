// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine($"Введите число, определяющее количество рандомных чисел в массиве: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[number];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) count += 1;
}
Console.WriteLine($"Массив:[{String.Join(";", array)}]");
Console.WriteLine($"Количество четных чисел в массиве {count}");
