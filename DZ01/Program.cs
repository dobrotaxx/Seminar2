/*
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int TwoDigit(int number)
{
    int TwoDigits = number % 100;
    int OneDigit = TwoDigits / 10;
    return (OneDigit);
}
int result = TwoDigit(number);
Console.WriteLine(result);