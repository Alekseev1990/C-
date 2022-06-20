// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System.Text;

void task1(int a)
{
    bool condition1 = a > 99 && a < 1000;
    if (condition1)
    {
        while (a >= 100) a /= 10;
        int x = a % 10;
        Console.WriteLine($"Вторая цифра - {x}");
    }
    else
    {
        Console.WriteLine($"Число должно быть трехзначным");
    }
}

Console.WriteLine("Введите трехзначное число - ");
int a = Convert.ToInt32(Console.ReadLine());
task1(a);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void task2(int w)
{
    if (w >= 1000)
    {
        while (w >= 1000)
            w /= 10;
        int x = w % 10;
        Console.WriteLine($"третья цифра - {x}");
    }
    else
    {
        Console.WriteLine($"Третьей цифры в введенном числе нет");
    }
}

Console.WriteLine("Введите число - ");
int w = Convert.ToInt32(Console.ReadLine());
task2(w);

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void task3(int q)
{
    bool cond1 = q > 0 && q < 6;
    bool condition2 = q > 5 && q < 8;
    if (cond1)
    {
        Console.WriteLine($"День недели {q} - будний");
    }
    else if (condition2)
    {
        Console.WriteLine($"День недели {q} - выходной");
    }
    else
    {
        Console.WriteLine($"Нужно ввести число от 1 до 7 включительно");
    }
}

Console.WriteLine("Введите цифру дня недели - ");
int q = Convert.ToInt32(Console.ReadLine());
task3(q);