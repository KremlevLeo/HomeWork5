/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Write("Enter count of numberd for array: ");
int countNumbers = int.Parse(Console.ReadLine());
int[] arr = FillArray(countNumbers);
Console.Write(SumOfNum(arr));

int[] FillArray(int a)
{
    Console.Write("[");
    int[] arr = new int[a];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-101, 101);
        Console.Write(arr[i] + ",");
    }
    Console.Write("] -> ");
    return arr;
}

int SumOfNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            count += array[i];
        }
    }
    return count;
}