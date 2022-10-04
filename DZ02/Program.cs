/*
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ThirdDigit(int arg1)
{
    if (arg1 < 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (arg1 >= 999)// Делим число на 10 пока оно не станет трехзначным
        {
            arg1 = arg1 / 10;
        }
        int temp3 = arg1 % 100;
        temp3 = temp3 % 10;
        Console.WriteLine($"{number} -> {temp3}");
    }
}
ThirdDigit(number);