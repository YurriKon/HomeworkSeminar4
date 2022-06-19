
// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) 
// и возводит число A в степень B.
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{A} в степени {B} равно {Math.Pow(A, B)}");
