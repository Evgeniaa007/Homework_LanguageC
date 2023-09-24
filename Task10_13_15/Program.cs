// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Введи трехзначное число N = ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 99 && N < 1000)
{
    int ost = ((N % 100) - (N % 10))/ 10;
    Console.Write("Вторая цифра трехначного числа - {0}", ost);
}
else
{
    Console.Write("не трехзначное число");
}
*/

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Введите число: "); 
string number = Console.ReadLine(); 
int amount = number.Length; 
if (amount > 3) 
{ 
    Console.WriteLine(number[2]);   
} 
else 
{ 
    Console.WriteLine("Нет третьей цифры"); 
}
*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
if (dayNum == 6 || dayNum == 7)
{
    Console.Write("Ура! Это выходной!");
}
else if (dayNum > 0 && dayNum <6)
{
    Console.Write("Ужас какой, сегодня нужно работать");
}
else
{
    Console.Write("Введите порядковый номер дня недели");
}
*/