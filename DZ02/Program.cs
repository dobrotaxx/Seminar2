﻿/*
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int number)
{
    if (number < 99)
    {
       Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        number = number % 100;
        number = number % 10;
        Console.WriteLine($"{number}");
    }
    return number;
}
ThirdDigit(number);