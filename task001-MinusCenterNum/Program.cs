﻿/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Пример:
456 -> 46
782 -> 72
918 -> 98
*/

//Эта задача есть в презентации к уроку, но мы её решали на семинаре. Я на всякий случай просто оставлю её тут.

int randomNumber = new Random().Next(100,1000);
Console.WriteLine($"Сгенерировано случайное трехзначное число: {randomNumber}");
int number1 = (randomNumber / 100) * 10;
int number2 = randomNumber % 10;
int result = number1 + number2;
Console.WriteLine($"После удаления центральной цифры получилось число: {result}");