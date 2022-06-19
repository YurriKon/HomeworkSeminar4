
// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел
// и выводит отсортированный по модулю массив.

int[] array = new int[8];
Random rand = new Random();

void PrintArrayRand(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = rand.Next(-10, 10);
        Console.Write($"{array[i]} ");
    }
}

PrintArrayRand(array);

void SortArray(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
       if (Math.Abs(array[j]) < Math.Abs(array[minPosition]))
       {
        minPosition = j;
       }
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
}
}

void PrintArraySorted(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

SortArray(array);
Console.WriteLine();
PrintArraySorted(array);

