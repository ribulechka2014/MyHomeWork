
/*
//Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input a, b number: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (b > a)
{
max  = b;
min = a;
}

Console.WriteLine($"Из чисел a={a}, b={b}, максимальное {max} минимальное {min}");
*/

/*
//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Input a, b, c number: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c  = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (b > a)
{
max  = b;
min = a;
}

if (c > max)
{
    max = c;
}

if (c < min)
{
  min = c;
}


Console.WriteLine($"Из чисел a={a}, b={b}, c={c} максимальное {max} минимальное {min}");
*/

/*
//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} - четное число");
}

else
{
    Console.WriteLine($"{number}- нечетное число");
}
*/

/*
//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;
while (number < N)
{
    if (number % 2 == 0)
        {
         Console.WriteLine($"{number} - четное число");
        }

    
number++;
}
*/