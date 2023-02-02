// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int counter;
double firstNumber;
Console.Clear();
Console.Write("Введите число: ");
firstNumber = double.Parse(Console.ReadLine()!)!;
if (firstNumber < 2)
{
    Console.WriteLine("Чётных чисел от 1 до " + firstNumber + " не существует.");
}
else
{
    counter = 2;
    Console.Write("Список чётных чисел от 1 до " + firstNumber + ": ");
    while (counter < (firstNumber - 1))
    {
        Console.Write(counter + ", ");
        counter += 2;
    }
    Console.WriteLine(counter + ".");
}