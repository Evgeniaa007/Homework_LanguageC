﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N%2==0)
{
    Console.Write("{0} - четное число", N);
}
else
{
    Console.Write("{0} - нечетное число", N);
}