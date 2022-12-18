//Урок 5. Функции и одномерные массивы
/*
int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);
    return array;
}

void ShowArray( int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

*/
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int numberOfEvenNumbersArray(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count;
}

int minV = 100;
int maxV = 999;
Console.WriteLine("Input  number of elements: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreatRandomArray(sizeArray, minV, maxV);
ShowArray(myArray);
int numEven = numberOfEvenNumbersArray(myArray);
Console.WriteLine("The number of even numbers in the array is  " + numEven);
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int SumOfElementsWithNotEvenIndex(int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);
int result = SumOfElementsWithNotEvenIndex(myArray);
Console.WriteLine("the sum of elements with not even index is " + result);
*/


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76*/

double [] CreatRandomDoubleArray(int size, int minV, int maxV)
{
    double [] array = new double [size];
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minV, maxV) + new Random().NextDouble();   
    
    for(int i = 0; i < array.Length; i++)
       array[i] = Math.Round(array[i], 2);
    return array; 
}

void ShowArray( double [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}
double Difference (double [] array)
{
    double maximum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= maximum) maximum = array[i];
    double minimum = maximum;
    for(int i = 0; i < array.Length; i++)
        if (array[i] < minimum) minimum = array[i];
    double diff = maximum - minimum;
    return diff;
}

Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double [] myArray = CreatRandomDoubleArray(size, min, max);
ShowArray(myArray);
double result = Difference(myArray);
Console.WriteLine("The difference between the max and min elements of the array is " + result);