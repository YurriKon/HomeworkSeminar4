
// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел
// и выводит отсортированный по модулю массив.

int[] mas = new int[8];
Random r = new Random();
int sum = 0;

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = r.Next(10);
    Console.WriteLine(mas[i] + " ");
    sum = sum + mas[i];
}
Console.WriteLine($"Сумма: {sum}");