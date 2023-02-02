// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
double firstNumber = double.Parse(Console.ReadLine()!)!;

if ((firstNumber % 2) != 0)
{
    Console.WriteLine("Введённое число нечётное.");
}
else
{
    Console.WriteLine("Введённое число чётное.");
}