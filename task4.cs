//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using System.Text;

// Console.WriteLine("Введите два числа: ");
// int a, b;


// void stepen(int a, int b){
//     Console.WriteLine("Введи первое число - ");
//     a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введи второе число (степень первого числа) - ");
//     b = Convert.ToInt32(Console.ReadLine());
//     int res = 1;
//     for (int i = 1; i <= b; i++) {
//         res *= a;
//     }
//     //return res;
// }


// stepen(a, b);

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int numbers = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(numbers > 0)
{
    sum = sum + numbers % 10;
    numbers = numbers / 10;
}

Console.WriteLine(sum);

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void showArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
}

int[] randomArray = CreateRandomArray(8, 0, 100);
showArray(randomArray);
Console.WriteLine();


