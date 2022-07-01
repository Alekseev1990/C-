// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System.Text;
int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void showArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
}

int[] myArray = CreateRandomArray(10, 100, 1000);
showArray(myArray);

int count = 0;
for (int i = 0; i < 10; i++)
{
    if ((myArray[i] % 2) == 0)
    count++;
}
Console.Write($"Количество четных элементов - {count}");


// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


var rnd = new Random();
var arr = new int[10];
 
for (int i = 0; i < arr.Length; i++)
    Console.Write("{0}\t", arr[i] = rnd.Next(10, 100));
Console.WriteLine();

    var odd = arr.Where((element, index) => index % 2 == 0);

Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());
 
Console.ReadKey();

// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


    int[] d = CreateRandomArray(10, 100, 1000);
    int max=100, min=100;
    for (int i = 0; i < d.Length; i++)
    {
        if (d[i] > max) max = d[i];
        if (d[i] < min) min = d[i];
    }
           
        for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);
            Console.WriteLine();
            Console.WriteLine("max - " + max);
            Console.WriteLine("min - " +min);
            Console.WriteLine("Разница максимального и минимального:  "+(max - min));
            Console.ReadKey();
