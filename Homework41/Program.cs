// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
System.Console.WriteLine("Введите числа через запятую");
string[] text = Console.ReadLine()!.Split(",");
int count = 0;
for (int i = 0; i < text.Length; i++)
{
 int numbers = int.Parse(text[i]);
 if (numbers > 0) count ++;
}
System.Console.WriteLine($"Количество чисел больше нуля {count}");