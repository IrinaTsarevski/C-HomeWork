//Урок8. Двуиерные массивы.

/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например задан массив:
147236
592387
842415
В итоге получается вот такой массив:
123467
235789
124458*/

/*int[,] Create2dArray(int numOfrows, int numOfColumns, int minValue, int maxValue)
{
    int[,] array = new int[numOfrows,numOfColumns];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(minValue, maxValue);
    return array;    
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10)
                Console.Write("  " + array[i,j] + " ");
            if(array[i,j] > 9 && array[i,j] < 100) 
                Console.Write(" " + array[i,j] + " ");
            if(array[i,j] > 99)
                Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArrangingArrayElements(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int x = 0; x < array.GetLength(1); x++)
            for(int j = 0; j < array.GetLength(1); j++)
                if( array[i,x] < array[i,j])
                {
                    temp = array[i,x];
                    array[i,x] = array[i,j];
                    array[i,j] = temp;
                }
}

Console.WriteLine("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[,] my2dArray = Create2dArray(rows, columns, minVal, maxVal);
Show2dArray(my2dArray);
ArrangingArrayElements(my2dArray);
Show2dArray(my2dArray);
*/



/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
Например задан массив:
1472
5923
8424
5267
Программа считает сумму элементов в каждой строке и выдает номер строки с наименьшей суммой элементов:
строка №1*/ 

/*int[,] FillRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    
    while(rows == columns)
    {
        Console.WriteLine("The number of rows must not equal the number of columns");
        Console.WriteLine("Input a numbers of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a numbers of columns: ");
        columns = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
    int[,] array = new int[rows, columns];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void RowWithMinSumOfElements(int[,] array)
{
    int i = 0;
    int minSum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
        minSum += array[i,j];
    int minRow = i;
    int sum2 = 0;
    i++;
    while(i < array.GetLength(0))         
    {
        sum2 = 0;
        for(int j = 0; j < array.GetLength(1); j++)
            sum2 += array[i,j];
        if(sum2 < minSum)
        {
            minSum = sum2;
            minRow = i;
        }
        i++;
    }
    
    minRow += 1; // это будет номер строки для пользователя
    Console.WriteLine("First Row with min Sum of elements is " + minRow);
}

int[,] myArray = FillRandom2dArray();
Show2dArray(myArray);
RowWithMinSumOfElements(myArray);
*/



/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Нпример даны две матрицы:
24|34
32|33
Результирующая матрица будет:
18 20
15 18*/

/*int[,] Create2dArray(int numrows, int numcolumns, int minValue, int maxValue)
{
    int[,] array = new int[numrows, numcolumns];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;        
}


void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProductOf2Arrays(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    int sum = 0;
    for(int i = 0; i < arrayA.GetLength(0); i++)
    {
        for(int y = 0; y < arrayB.GetLength(1); y++)
        {
            sum = 0;
            for(int j = 0; j < arrayB.GetLength(0); j++)
            {
                sum = sum + arrayA[i,j] * arrayB[j,y];
                arrayC[i,y] = sum;
            }
        }
    }
    return arrayC;
}

Console.WriteLine("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int minV = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int maxV = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myFirstArray = Create2dArray(rows, columns, minV, maxV);
int[,] mySecondArray = Create2dArray(rows, columns, minV, maxV);
Show2dArray(myFirstArray);
Show2dArray(mySecondArray);
int[,] resultArray = ProductOf2Arrays(myFirstArray, mySecondArray);
Show2dArray(resultArray);
*/



/*Задача 60: Сормируйте трехмерный массив из неповторяющихся двухзначных чисел.
Напишите программу, которая будет построчно выводить массив, добвляя индексы каждого элемента.
Массив размером 2*2*2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*int[,,] Create3dArray(int size1, int size2, int size3)
{
    while(size1*size2*size3 > 99)
    {
        Console.WriteLine("The total number of array elements should not exceed 90");
        Console.WriteLine("input size1 of 3d array (): ");
        size1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("input size2 of 3d array: ");
        size2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("input size3 of 3d array: ");
        size3 = Convert.ToInt32(Console.ReadLine());
    }

    int[,,] array = new int[size1, size2, size3];
    int fistnumber = 10;
    {
        for(int i = 0; i < array.GetLength(0); i++)
            for(int k = 0; k < array.GetLength(2); k++)
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j,k] = fistnumber;
                    fistnumber++;
                }
    }
    return array;
}

void Show3dArrayWithIndexes(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int k = 0; k < array.GetLength(2); k++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }   
        Console.WriteLine();   
    }
}

Console.WriteLine("input size1 of 3d array: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input size2 of 3d array: ");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input size3 of 3d array: ");
int size3 = Convert.ToInt32(Console.ReadLine());

int[,,] my3dArray = Create3dArray(size1, size2, size3);
Show3dArrayWithIndexes(my3dArray);
*/



/*Задача 62: Напишите программу, которая заполнит спирально массив 4*4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05 
11 16 15 06
10 09 08 07*/

/*int[,] SpiralFill2dArray(int rows, int columns)
{
    int[,] array = new int[rows,columns];
    int number = 1;
    int length = array.Length;
    
    
    for(int y = 0, x = 0; y < array.GetLength(1) - 1; y++)
    {
       array[x,y] = number;
       number++;
       length--;
    }
    for(int x = 0, y = array.GetLength(1) - 1; x < array.GetLength(0) - 1; x++)
    {
        array[x,y] = number;
        number++;
        length--;
    }
    for(int y = array.GetLength(1) - 1, x = array.GetLength(0) - 1; y > 0; y--)
    {
        array[x,y] = number;
        number++;
        length--;
    }
    for(int x = array.GetLength(0) - 1, y = 0; x > 0; x--)
    {
        array[x,y] = number;
        number++;
        length--;
    }
    
    int i = 1;
    int j = 1;

    while(length > 0)
    {
        while(array[i,j] == 0 && length > 0)
        {
            array[i,j] = number;
            number++;
            length--;
            j++;
        }
        j--;
        i++;
        while(array[i,j] == 0 && length > 0)
        {
            array[i,j] = number;
            number++;
            length--;
            i++;
        }
        i--;
        j--;
        while(array[i,j] == 0 && length > 0)
        {
            array[i,j] = number;
            number++;
            length--;
            j--;
        }
        j++;
        i--;
        while(array[i,j] == 0 && length > 0)
        {
            array[i,j] = number;
            number++;
            length--;
            i--;
        }
        i++;
        j++;
    }
    return array;
}


void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10)
                Console.Write("  " + array[i,j] + " ");
            if(array[i,j] > 9 && array[i,j] < 100) 
                Console.Write(" " + array[i,j] + " ");
            if(array[i,j] > 99)
                Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }  
    Console.WriteLine();
}

Console.WriteLine("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = SpiralFill2dArray(rows, columns);
Console.WriteLine();
Show2dArray(myArray);
*/


