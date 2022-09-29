/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет
 вторую цифру этого числа. 
 456 -> 46 
 782 -> 72 
 918 -> 98
*/

int number = new Random().Next(100,1000);

void getDeleteTwoDigitFromNumber(int number)
{
    int firstNumber = number / 100;
    int thirdNumber = number % 10;
    Console.Write(firstNumber);
    Console.Write(thirdNumber);
}
Console.WriteLine(number);
getDeleteTwoDigitFromNumber(number);