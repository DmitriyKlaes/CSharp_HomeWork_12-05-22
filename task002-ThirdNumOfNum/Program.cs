/*
Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Пример:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    for (int div = 10; div <= number / 10; div = div * 10)
    {
        if (div > number / 100)
        {
        int result = (number % div) / (div / 10);
        Console.WriteLine($"Третья цифра числа {number} является {result}");
        break;
        }
    }
}
else
{
    Console.WriteLine($"В числе {number} третьей цифры нет!");
}
