// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int Math(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.Write("Input first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input two number: ");
int twoNum = Convert.ToInt32(Console.ReadLine());

int result = Math(firstNum, twoNum);
Console.WriteLine($"The number {firstNum} raised to the power of {twoNum} = {result}");
*/


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int NumberLen(int num)
{
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
}

int SumNumbers(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Input numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = NumberLen(a);
int result = SumNumbers(a, len);
Console.WriteLine($"If you add these {a} numbers together, you get {result}");
*/



// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[8];

    for(int i = 0; i < 8; i++)
    
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

Console.Write("Input number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input min posibal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max posibal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length, min, max);
ShowArray(myArray);