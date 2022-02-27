// 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

int num = new Random().Next(1, 10);
Console.WriteLine($"Количество элементов массива: {num}");

double[] FillArray(int num)
{
    double[] array = new double[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiff(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальное значение {arr.Min()}, максимальное значение {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
}
PrintDiff(FillArray(num));

