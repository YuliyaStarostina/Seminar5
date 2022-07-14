// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] array = GetArray(5);
PrintArray(array);

System.Console.WriteLine($"\nРазница между максимальным и минимальным элементом массива равна = {DiffMaxMin(array)}");

void PrintArray(double[] array)
{
    System.Console.WriteLine(string.Join(',', array));
}
double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (500-(-500))+(-500);
        array[i] = Math.Round(array[i],2);
    }
    return array;
}

double DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    double diff = Math.Round(max - min,2);
    return diff;
}


