/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/*void SecondNum(int number)
{
    if (number > 99 && number < 1000)
    {
        int newnum = (number % 100)  / 10; 
        Console.WriteLine($"Вторая цифра числа {number}: {newnum}");
    }
    else
    {
        Console.WriteLine("Число не трёхзначное, повторите попытку используя трёхзначное число!"); 
    }
}

Console.WriteLine("Bведите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
SecondNum(number);
*/


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
//        ПЕРВЫЙ вариант решения
//  для третьей цифры СПРАВА (19586'9'47)

/*void ThirtNum(int num)
{
    num = num / 100;
    if(num > 0)
    {
        num = num % 10;
        Console.WriteLine($"Третья цифра вашего числа: {num}");
    }
    else
    {
        Console.WriteLine("третьей цифры в числе нет");
    } 
}

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirtNum(number);
*/

//        ВТОРОЙ вариант решения
//  для третьей цифры СЛЕВА (78'9'524556)

/*int ThirtNum(int num)
{
    int newnum = -1;
    while(num > 999)
    {
        num = num / 10;   
    }
    if(num > 99)
    {
        num = num % 10;
        newnum = num;
    }
    return newnum;
}

Console.WriteLine("ВВедите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = ThirtNum(number);
if(newNumber == -1)
{
    Console.WriteLine("Третьей цифры в вашем числе нет");
}
else
    Console.WriteLine($"Третья цифра вашего числа {newNumber}");
*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

/*void  Weekend ( int weekday )
{
    if ( weekday == 6 || weekday == 7 )
    {
            Console.WriteLine ( "Ура! это выходной день!" );
    }
    else
        Console.WriteLine ("это рабочий день");
}
int NotWeekDay ( int wkday )
{
     while ( wkday > 7 )
    {
        Console.WriteLine ( "Введите цифру обозначающую день недели от 1 до 7, где 1 - это понедельник, 7 - воскресенье" );
        wkday = Convert.ToInt32 ( Console.ReadLine() );
    }  
    return wkday;  
}

Console.WriteLine ( "Введите цифру обозначающую день недели: " );
int wday = Convert.ToInt32 ( Console.ReadLine() );

if ( wday > 7 )
{
    wday = NotWeekDay ( wday );
    Weekend ( wday );
}
    
else 
    Weekend ( wday );
*/