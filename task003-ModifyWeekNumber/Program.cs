﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели: ");

int number = Convert.ToInt32(Console.ReadLine());
switch ((number - 1) % 7 + 1) // выдает с любого числа день недели
{
    case 1:
        {
            System.Console.WriteLine("Понедельник - рабочий день");
            break;
        }
    case 2:
        {
            System.Console.WriteLine("Вторник - рабочий день");
            break;
        }
    case 3:
        {
            System.Console.WriteLine("Среда - рабочий день");
            break;
        }
    case 4:
        {
            System.Console.WriteLine("Четверг - рабочий день");
            break;
        }
    case 5:
        {
            System.Console.WriteLine("Пятница - рабочий день");
            break;
        }
    case 6:
        {
            System.Console.WriteLine("Суббота - выходной день");
            break;
        }
    case 7:
        {
            System.Console.WriteLine("Воскресенье - выходной день");
            break;
        }

    default:
        {
        }
}