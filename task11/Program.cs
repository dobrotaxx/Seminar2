/*
Напишите программу, которая будет принимать на вход два числа и 
выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите два числа A: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите два числа B: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


 int result = firstNumber % secondNumber;
if(result > 0)
{
    Console.WriteLine($"Не кратно, остаток {result}");
}
else
{
    Console.WriteLine("Кратно");
}