// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечётных/чётных чисел.

int[] array = new int[10];

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);

int even = 0;
int not_even =0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0) even++;
    else not_even++;
}
Console.WriteLine($"Количество четных чисел: {even},Количество не четных чисел: {not_even}");