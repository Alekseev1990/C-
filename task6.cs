//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число: ");
int a;
a = Convert.ToInt32(Console.ReadLine());
string binary = Convert.ToString(a, 2);

Console.WriteLine(binary);


//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше 0: {count}");