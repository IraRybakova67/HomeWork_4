// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число ");
int initial_namber = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int namber = initial_namber;
while (namber >0)
{
    sum = sum + namber % 10;
    namber = namber /10;
}
Console.WriteLine($"Суммы всех цифр в  числе  {initial_namber} равна {sum}");
