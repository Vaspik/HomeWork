// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    
        array[i] = new Random().Next(100, 1000);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int EvenNum(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = EvenNum(myArray);
Console.WriteLine();  
Console.WriteLine("Чётных чисел в массиве: " + result);

*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int NotEvenNum(int[] array) // Сумма нечётных чисел в массиве
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1)
            sum += array[i];
    
    }
    return sum;
}

int NotEnenNumIndex(int[] array) // Сумма индексов с нечётными числами
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1)
            sum += i;
    }
    return sum;
}

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posibal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posibal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int result = NotEvenNum(myArray);
Console.WriteLine();
Console.WriteLine("Сумма всех нечётных чисел: " + result);

int result2 = NotEnenNumIndex(myArray);
Console.WriteLine("Сумму индексов с нечётными числами: " + result2);

*/


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double Difference(double[] array)
{
    double sum = 0;
    double min = array[0];
    double max = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];

        if(array[i] > max)
            max = array[i];
        
        sum = max - min;
    }
    return sum;
}


Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posibal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posibal value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

double result = Difference(myArray);
Console.WriteLine();
Console.WriteLine("Разница между минимальным и максимальным значением в массиве: " + result);