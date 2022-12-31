//Урок 9. Рекурсия

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*void ShowDigits(int number)
{
    Console.Write(number + " ");
    if(number > 1) ShowDigits(number - 1);
    
}

Console.WriteLine("input  number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowDigits(num);
*/



/*Задача 66: Задайте значения M и N. Напишите программу, 
  которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*int SumOfElements(int numberM, int numberN)
{
    if(numberM < numberN) return SumOfElements(numberM + 1, numberN) + numberM; // промежуток [M,N)
    //if(numberM < numberN) return SumOfElements(numberM, numberN - 1) + numberN; // промежуток (M,N]
    else if(numberM > numberN) return SumOfElements(numberM -1, numberN) + numberM; // промежуток [M,N)
    //else if(numberM > numberN) return SumOfElements(numberM, numberN + 1) + numberN; // промежуток (M,N]
    else return 0;
}

Console.WriteLine("Input first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write(SumOfElements(firstNum, secondNum) + " ");
*/



/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

/*int Ack(int m, int n)
{
    if(m == 0) return n + 1;
    else if(n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}
Console.WriteLine("Input first number: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.Write(Ack(numM, numN));
*/