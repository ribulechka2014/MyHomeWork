/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int RevNum(int num)
{
int result = 0;
while (num > 0) 
    {
        result *= 10;
        result += num % 10;
        num /= 10;
    }
return result;
}

bool IsPalindrom(int num)
{
  return num == RevNum(num); 
}

if (IsPalindrom(num))
Console.Write(num + " - палиндром.");
else
Console.Write(num + " - не является палиндромом.")
*/