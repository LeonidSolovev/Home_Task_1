// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Write("Введите первое число: ");
string inputA = Console.ReadLine() ?? "";
int numberA = int.Parse(inputA);

Console.Write("Введите второе число: ");
string inputB = Console.ReadLine() ?? "";
int numberB = int.Parse(inputB);

int max = numberA;

if (numberB>max)
{
max = numberB;
}

Console.WriteLine($"a = {numberA}; b = {numberB} -> max = {max}");