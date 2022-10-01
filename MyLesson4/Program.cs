/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int a, int b)
{
    int result = 1;
    int i = 1;
    while (i <= b)
        {
        result *= a;
        i++;
        }
        return result;
};

Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.Write($"{num} в степени {degree} = {Exponentiation(num, degree)}");
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int Sum (int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10; 
        num /= 10;
    }
    return result;
}

Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Количество цифр: {Sum(num)}");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int [] InputElementsArray(int size)
{
    Console.Write("Введите количество элементов массива:\t");

    size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
return array;
}

int [] newArr = InputElementsArray(8);
*/