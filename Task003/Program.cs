/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Write("Enter count of numberd for array: ");
int countNumbers = int.Parse(Console.ReadLine());
int[] arr = FillArray(countNumbers);
Console.Write(Max(arr) - Min(arr));

int[] FillArray(int a)
{
    Console.Write("[ ");
    int[] arr = new int[a];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 101);
        Console.Write(arr[i] + " ");
    }
    Console.Write("] -> ");
    return arr;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

int Max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}