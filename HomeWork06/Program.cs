//Урок 6. Одномерные массивы. Продолжение


//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int Number(int size)
{
    int count = 0;
    Console.WriteLine("Input a numbers: ");
    for(int i = 0; i < size; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) count++;
    }
    return count;
}

Console.WriteLine("Input a number of elements: ");
int numOfElem = Convert.ToInt32(Console.ReadLine());
int result = Number(numOfElem);
Console.WriteLine($"You entered {result} numbers greater than 0");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void PointOfIntersection(double b1, double k1, double b2, double k2)
{
    double [] points = new double[2];
    if(k1 != k2)
    {
        points[0] = (b2 - b1) / (k1 - k2);
        points[1] = k2 * points[0] + b2;
        for(int i = 0; i < points.Length; i++)
            Console.WriteLine(points[i]);
    }
    if(k1 == k2 && b1 == b2) 
        Console.WriteLine("The stright lines match");  
    if(k1 == k2 && b1 != b2)
        Console.WriteLine("The stright lines are parallel");
}
Console.WriteLine("Input b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("The coordintes of the point of intersection are: ");
PointOfIntersection(b1, k1, b2, k2);
