// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CrateRandomDouble2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], 2) + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Сколько будет строк?: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько будет колонн?: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myRandomDoubleArray = CrateRandomDouble2dArray(rows, columns, minValue, maxValue);
Show2dArray(myRandomDoubleArray);
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

/*

int[,] CrateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowNumFromTheIndex(int[,] array, int IndexNum, int ColumnsNum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(IndexNum == i && ColumnsNum == j)
            {
                Console.Write($"Ваше число: {array[i,j]}.");
            }   
        }
    }       
}

Console.Write("Сколько будет строк?: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько будет колонн?: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите строку искомого число : ");
int IndexNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонны искомого числа: ");
int ColumnsNum = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CrateRandom2dArray(rows, columns);
Show2dArray(myArray);
ShowNumFromTheIndex(myArray, IndexNum, ColumnsNum);

*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CrateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArithmeticMean(int[,] array)    // У меня sum записывала 4 раза одно и то же значение и не понял из за чего. Надеюсь void сойдёт
{
    int ind = 0;
    double[] sumArr = new double[array.GetLength(1)];
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (ind = 0; ind < array.GetLength(1); ind++)
            {
                sum = array[i,j];
                
                sumArr[ind] = sum / array.GetLength(1);
            }
        }
    }  
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 2) + "\t");
    }
    Console.WriteLine();
}

Console.Write("Сколько будет строк?: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько будет колонн?: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CrateRandom2dArray(rows, columns);
Show2dArray(myArray);
ArithmeticMean(myArray);
