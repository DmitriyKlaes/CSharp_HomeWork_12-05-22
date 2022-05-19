/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        {
            Console.Write("Понедельник - ");
            break;
        }
    case 2:
        {
            Console.Write("Вторник - ");
            break;
        }
    case 3:
        {
            Console.Write("Среда - ");
            break;
        }
    case 4:
        {
            Console.Write("Четверг - ");
            break;
        }
    case 5:
        {
            Console.Write("Пятница - ");
            break;
        }
    case 6:
        {
            Console.Write("Суббота - ");
            break;
        }
    case 7:
        {
            Console.Write("Воскресенье - ");
            break;
        }
    default:
        {
            break;
        }
}
if (day == 6 || day == 7)
{
    Console.Write("это выходной");
}
else if (day > 7)
{
    Console.WriteLine("Дней недели всего 7!");
}
else if (day < 1)
{
    return;
}
else
{
    Console.Write("это рабочий день");
}