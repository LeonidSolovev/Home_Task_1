// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: ");
string inputA = Console.ReadLine() ?? "";
int numberA = int.Parse(inputA);

Console.Write("Введите второе число: ");
string inputB = Console.ReadLine() ?? "";
int numberB = int.Parse(inputB);

Console.Write("Введите третье число: ");
string inputC = Console.ReadLine() ?? "";
int numberC = int.Parse(inputC);


int max = numberA;

if (numberB>max)
{
max = numberB;
}

if (numberC>max)
{
max = numberC;
}


Console.WriteLine($"{numberA}, {numberB}, {numberC} -> {max}");