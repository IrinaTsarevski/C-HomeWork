//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*double Pow(double numberA, double numberB)
{
    double count = numberA;
    if(numberB < 0) numberB *= -1;
    for(double i = 1; i < numberB; i++)
    {
        count *= numberA;        
    }
    return count;
}

Console.WriteLine("Input two numbers: ");
double numA = Convert.ToDouble(Console.ReadLine());
double numB = Convert.ToDouble(Console.ReadLine());
double result = Pow(numA, numB);
Console.WriteLine(result);
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*int Sum(int number)
{
    int sumNumbers = number % 10;
    int newNumber = number / 10;
    while(newNumber > 0)
    {
        if(newNumber > 9) sumNumbers += newNumber % 10;
        else sumNumbers += newNumber;
        newNumber = newNumber / 10;
    }
    return sumNumbers;
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int total = Sum(num);
Console.WriteLine($"The sum of all digits of number {num} is {total}");
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*int [] CreateArray(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < array.Length; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}

void ShowArray(int [] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}


Console.WriteLine("input eight elements of array: ");
int sizeArray = 8;
int [] myArray = CreateArray(sizeArray);
Console.WriteLine();
ShowArray(myArray);
*/
