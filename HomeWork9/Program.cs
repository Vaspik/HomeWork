// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*

void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1 ) ShowNums(num - 1);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);

*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);

}
int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"{m}, {n} ->");
PrintSum(m, n, temp = 0);

*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;

    if (numberM != 0 && numberN == 0)
        return AckermannFunction(numberM - 1, 1);

    if (numberM > 0 && numberN > 0)
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));

    return AckermannFunction(numberM, numberN);
}

Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");