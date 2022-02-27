// Задача 34: Написать программу для замены элементов массива на противоположные.

int[] array = new int[5];

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = array[i] * -1;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}