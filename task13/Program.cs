/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого. 
5, 25 -> да 
-4, 16 -> да 
25, 5 -> да 
8,9 -> нет
*/

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

string SquareOrNot(int numberA, int numberB)
{
    string YesOrNo = "";
    if (numberA / numberB == numberB || numberB / numberA == numberA)
    {
        YesOrNo = "Да";
    }
    else YesOrNo = "Нет";
    return YesOrNo;
}
string result = SquareOrNot(numberA, numberB);
Console.WriteLine(result);