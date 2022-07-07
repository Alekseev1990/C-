// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] a = new double[4, 4];

Random random = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,4}", a[i, j]);
    }
    Console.WriteLine();
}


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] mas = new double[4, 4];
Random random = new Random();
for (int i = 0; i < 4; i++)
{
    int result = 0;
    for (int t = 0; t < 4; t++)
    {
        mas[i, t] = random.Next(100);
        result += (int)mas[t, i];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)result / 4}");
}