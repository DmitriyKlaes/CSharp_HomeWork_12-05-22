/*
Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Пример:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int numberSave = number;
if (number > 99)
{
    for (int div = 10; number > 1000; number = number / div);
    int result = number % 10;
    Console.WriteLine($"Третья цифра числа {numberSave} является {result}");
}
else if (number < -99)
{
    for (int div = 10; number < -1000; number = number / div);
    int result = number % 10;
    Console.WriteLine($"Третья цифра числа {numberSave} является {Math.Abs(result)}");
}
else
{
    Console.WriteLine($"В числе {numberSave} третьей цифры нет!");
}