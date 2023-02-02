// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
double firstNumber = double.Parse(Console.ReadLine()!)!;

Console.Write("Введите второе число: ");
double secondNumber = double.Parse(Console.ReadLine()!)!;

if (firstNumber > secondNumber)
{
    Console.WriteLine("Максимальное число из введённых - " + firstNumber);
}
else
{
    Console.WriteLine("Максимальное число из введённых - " + secondNumber);
}