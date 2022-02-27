// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

int[] array = new int[10];

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
    int sum = 0;
    for (int i = 1; i < count; i++)
    {
       if(i % 2 != 0) 
       {sum += array[i];}
       
    }
    Console.WriteLine(sum);
}