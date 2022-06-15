
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа: ");
int a, b;
Console.WriteLine("Введи свое первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число - ");
b = Convert.ToInt32(Console.ReadLine());
    bool condition1 = a > b;
    bool condition2 = a == b;
    bool condition3 = a < b;
    if (condition1)
    {
        Console.WriteLine($"Число {a} больше чем {b}");
    }
    else if (condition2)
    {
        Console.WriteLine($"Числа {a} и {b} равны");
    }
    else
    {
        Console.WriteLine($"Число {b} больше чем {a}");
    }

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int a, b, c;
Console.WriteLine("Введи свое первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое второе число - ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи свое третье число - ");
c = Convert.ToInt32(Console.ReadLine());
    bool condition1 = a > b && a > c;
    bool condition2 = b > a && b > c;
    if (condition1)
    {
        Console.WriteLine($"Число {a} наибольшее");
    }
    else if (condition2)
    {
        Console.WriteLine($"Число {b} наибольшее");
    }
    else
    {
        Console.WriteLine($"Число {c} наибольшее");
    }



//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;
Console.WriteLine("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0)
    {
        Console.WriteLine($"Число - четное");
    }
    else
    {
        Console.WriteLine($"Число - нечетное");
    }

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a;
Console.WriteLine("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
for (int x = 0; x < a; x++)       
    if (x % 2 == 0)            
    Console.WriteLine(x);