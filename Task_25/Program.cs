//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число ");
int namberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В какую степень возвести число  {namberA} ?");
int namberB = Convert.ToInt32(Console.ReadLine());
Console.Write($"Число {namberA} в степени {namberB} равно {(int)Math.Pow(namberA, namberB)}");

// Тоже самое только цикл


int RaiseDegreeNumber(int numberA, int numberB)
{
    int result = numberA;
    int i =2;
    while (i <= numberB)
    {    
    result = result * numberA;
    i++;
    }
    return result;
}

int GetInput(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetInput("Введите число:  ");
int numberB = GetInput($"Введите степень, в которую нужно возвести число {numberA}:  ");

Console.WriteLine($"Число {numberA} в степени {numberB} равно {RaiseDegreeNumber(numberA, numberB)}");