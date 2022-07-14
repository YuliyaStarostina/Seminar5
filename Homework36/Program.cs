// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] newArray = new int[4]; 
CreateArray(newArray);
Console.WriteLine($"Массив:[{String.Join(",", newArray)}]");
SumNumbersEvenPosition(newArray);
int[] CreateArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(201);
    }
    return size;
}

void SumNumbersEvenPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i] ;
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum}");
}



