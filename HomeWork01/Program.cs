//Домашняя работа по первому семинару С#

/*
Задача 2.
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"{num1}  is great than {num2}, max = {num1}");
}
if(num1 < num2)
{
    Console.WriteLine($"{num2} is great than {num1}, max = {num2}");
}
if(num1 == num2)
{
    Console.WriteLine($"The numbers are equal, {num1} = {num2}");
}
*/

/*
Задача 4.
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int current = num1;

if(num2 > current)
{
    current = num2;
}
if (num3 > current)
{
    current = num3;
}
Console.WriteLine($"max = {current}");
*/

/*
Задача 6.
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.WriteLine("Input your number to find if it's even! : ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine($"{num} is an even number!");
}
else
{
    Console.WriteLine($"Unfortunatly,{num} is't even, try again with another number!");
}
*/

/*
Задача 8.
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
while(current <= num)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    current++;   
}
