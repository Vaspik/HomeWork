// Задача 1.Напишите программу,
// которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// Первый вариант с рандомными числами.
// int a = new Random().Next(1, 100), b = new Random().Next(1, 100);
// int max = a;
// Console.WriteLine(a);
// Console.WriteLine(b);
// if(max < b) max = b;
// Console.Write("Это большее число "max);

// Второй вариант где запрашивают числа у пользователя.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if(max < b) max = b;
// Console.WriteLine("Это число больше " + max);

//Задача 2.
//Напишите программу,
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Первый вариант с рандомными числами.

// int a = new Random().Next(1, 100), b = new Random().Next(1, 100),
//     c = new Random().Next(1, 100);
// int max = a;
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// if(max < b) max = b;
// if(max < c) max = c;
// Console.WriteLine("Это большее число " + max);

// Второй вариант с запросом чисел от пользователя.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if(max < b) max = b;
// if(max < c) max = c;
// Console.WriteLine("Это большее число " + max);

// Задача 3.
// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// Первый вариант с рандомными числами.

// int a = new Random().Next(1, 100);
// Console.WriteLine(a);
// if((a % 2) == 0)
// {
//     Console.WriteLine($"Число {a} чётное");
// }
// else
// {
//     Console.WriteLine($"Число {a} нечёное");
// }

// Второй вариант с запросом чисел у пользователя.

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if((a % 2) == 0)
// {
//     Console.WriteLine($"Число {a} чётное");
// }
// else
// {
//     Console.WriteLine($"Число {a} нечётное");
// }


// Задача 4.
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// С Числами пользователя.

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int even = 1;
// while(even <= a)
// {
//     if(even % 2 != 1)
//     {
//         Console.Write(even + " ");
//     }
//     even++;
// }

// Рандомные числа.

int a = new Random().Next(1, 100);
Console.WriteLine(a);
int even = 1;
while(even <= a)
{
    if(even % 2 != 1)
    {
        Console.Write(even + " ");
    }
    even++;
}

