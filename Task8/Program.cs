﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

int counter = 0;

Console.Write($"{numberA} -> ");
while (counter<numberA){
    counter++;
    if (counter%2==0)
    Console.Write($"{counter}, ");
}