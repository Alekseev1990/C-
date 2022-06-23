//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System.Text;

bool IsPalindrome(string str)
{
    if (str.Length == 1 || str.Length == 0) return true;
    return str[0] == str[str.Length - 1] && IsPalindrome(str.Substring(1, str.Length - 2));
}

IsPalindrome("1234321");
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

double dist3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.Write("Введите координаты x1: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z1: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты x2: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z2: ");
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Отрезок равен:" + dist3D(x1: xA, y1: yA, z1: zA, x2: xB, y2: yB, z2: zB));


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

void listQube(int n)
{
    int count = 1;

    Console.Write(n + "->");

    while (count <= n)
    {
        Console.Write(Math.Pow(count, 3) + ", ");
        count++;
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

listQube(num);

