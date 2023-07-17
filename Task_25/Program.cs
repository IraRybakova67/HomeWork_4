//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число ");
int namberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В какую степень возвести число  {namberA} ?");
int namberB = Convert.ToInt32(Console.ReadLine());
Console.Write($"Число {namberA} в степени {namberB} равно {(int)Math.Pow(namberA, namberB)}");