﻿// Принимает два числа и выдаёт, какое число большее,
double num1, num2;
string input1, input2;

Console.WriteLine("Введите 2 числа:");
input1 = Console.ReadLine();
input2 = Console.ReadLine();

num1 = double.Parse(input1);
num2 = double.Parse(input2);

double max;
max = num1;
if (max < num2)
{
    max = num2;
}
Console.WriteLine("max число = " +max);
