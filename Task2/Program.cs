// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("{0} - большее число, {1} - меньшее число", a, b);
}
else
{
    Console.Write("{0} - большее число, {1} - меньшее число", b, a);
}
