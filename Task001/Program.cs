/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2     */


Console.Write("Enter count of numberd for array: ");
int countNumbers = int.Parse(Console.ReadLine());
int[] arr = FillArray(countNumbers);

Console.Write(ParytiCheck(arr));

int ParytiCheck(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0) count++;
    }
    return count;
}

int[] FillArray(int a)
{
    Console.Write("[");
    int[] arr = new int[a];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
        Console.Write(arr[i] + ",");
    }
    Console.Write("] -> ");
    return arr;
}
