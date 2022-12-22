//Урок 7. Двумерные массивs
/*int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
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



int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*double[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

   double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
        }
    }
    return array;
}

void Show2dDoubleArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(array[i,j], 1);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }  
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dDoubleArray(myArray);*/


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
  и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/

/*int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
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

int ValueOfElement(int[,] array, int row, int col)
{
    int element = 0;
    
    if(row < array.GetLength(0) && row >= 0 && col < array.GetLength(1) && col >= 0)
        for(int i = 0;i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
                element = array[row,col];
        
    else
        Console.WriteLine("No element"); //можно заменить условный ноль element = array[-1,-1]
      
    return element;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine("Enter a nummer of the row: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of index of element: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int result = ValueOfElement(myArray, rowIndex, columnIndex);
Console.WriteLine(result);
Console.WriteLine();
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

double[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }  
    Console.WriteLine();
}

void ShowArray( double [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

double[] SumNumbersInColumns(double[,] array)
{
    double[] newArray = new double[array.GetLength(1)];    
    int j = 0;
    while(j < newArray.Length)  
    {
        double sum = 0;  
        for(int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j];             
        newArray[j] = Math.Round(sum / array.GetLength(0), 1);
        j++;
    }           
    return newArray;
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] result = SumNumbersInColumns(myArray);
ShowArray(result);

