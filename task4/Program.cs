// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число: ");
double firstNumber = double.Parse(Console.ReadLine()!)!;

double maxNumber = firstNumber;

Console.Write("Введите второе число: ");
double secondNumber = double.Parse(Console.ReadLine()!)!;
if (secondNumber > maxNumber) maxNumber = secondNumber;

Console.Write("Введите третье число: ");
double thirdNumber = double.Parse(Console.ReadLine()!)!;
if (thirdNumber > maxNumber) maxNumber = thirdNumber;

Console.WriteLine("Максимальное число из введённых - " + maxNumber);