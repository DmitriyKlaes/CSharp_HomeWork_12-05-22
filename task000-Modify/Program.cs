/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Пример:
456 -> 5
782 -> 8
918 -> 1
*/

//Трехзначное число можно сгенерировать случайно или ввести вручную.

Console.WriteLine("Сгенерировать случайное положительное трёхзначное число? (введите Y или N): ");
string choice = Console.ReadLine()!;
if (choice.ToLower() == "y" || choice.ToLower() == "n")
{
    int number = 0;
    if (choice.ToLower() == "y")
    {
        number = new Random().Next(100, 1000);
    }
    if (choice.ToLower() == "n")
    {
        Console.WriteLine("Введите положительное трёхзначное число:");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 999 || number < 100)
        {
            Console.WriteLine("Неверный ввод! Попробуйте ещё раз.");
            return;
        }
    }
    int centerNumber = (number % 100) / 10;
    Console.WriteLine($"Вторая цифра числа {number} это {centerNumber}");
}
else
{
    Console.WriteLine("Неверный выбор! Попробуйте ещё раз.");
}