// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// int Met(int num)
// {
//     int sot = num / 10;
//     int ed = sot % 10;
//     return ed;
// }

// Console.Write("Введите трёхзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Met(a);
// Console.WriteLine(result);



// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

int Met(int num)
{ 
    int b = 0;
    int a = -1;

    if(num > 1000)
    {
        while(num > 1000)
        {
            num = num / 10;
        }
    }

    else
    {
        if(num < 100)
        {
            Console.WriteLine($"Число {num} не являяется двузначным");
            Console.WriteLine("**Здесь могла бы быть ваша реклама!**");
            return a;
        }
    }

    b = num % 10;
    return b;
}

Console.Write("Введите число трёх или более значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Met(number);
Console.WriteLine("Третье число твоего номера это " + result);





// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// bool Met(int num)
// {
//     if(num == 6 || num == 7)
//     {
//         return true;
//     }

//     if(num > 7)
//     {
//         Console.WriteLine("В неделе 7 дней, а не " + num);
//         return false;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.Write("Введите День недели от 1 до 7: ");
// int a = Convert.ToInt32(Console.ReadLine());
// bool result = Met(a);
// Console.WriteLine(result);

