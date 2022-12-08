/*               Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

 /*void Polindrom(int number)
{
    int nummer1 = number / 10000;
    int nummer2 = (number / 1000) % 10;
    int nummer5 = number % 10;
    int nummer4 = (number % 100) / 10;

    if (nummer1 == nummer5 && nummer2 == nummer4) Console.WriteLine($"Число {number} является полиндромом");
    else Console.WriteLine("Ваше число не полиндром");
}
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
Polindrom(num);
*/


/*               Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*double LenthAB(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double length = Math.Sqrt (Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB -zA, 2));
    return Math.Round(length, 2);
}


Console.WriteLine("Введите координаты точки A (x,y,z):  ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());    

Console.WriteLine("Введите координаты точки B (x,y,z):  ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine()); 

double length = LenthAB(xA, yA, zA, xB, yB, zB);
Console.WriteLine(length);
*/   


/*               Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/*void Cub (double N)
{
    int count = 0;
    int NN = 1;
    while(count < N)
    {
        double newN = Math.Pow(NN, 3);
        Console.WriteLine(newN);
        NN++;
        count++;
    }
}
Console.WriteLine("Введите любое число");
double num = Convert.ToDouble(Console.ReadLine());
Cub(num);
*/
