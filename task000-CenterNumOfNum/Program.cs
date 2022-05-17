/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Пример:
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
int centerNumber = (number % 100) / 10;
if (number > 999 || number < 100)
{
    Console.WriteLine("Неверный ввод! Попробуйте ещё раз.");
    return;
}
Console.WriteLine($"Вторая цифра числа {number} это {centerNumber}");