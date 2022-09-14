/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int uzerNum = Convert.ToInt32(Console.ReadLine());
int SecondDigit(int userNum)
{
    return  (uzerNum / 10 ) % 10;
}

Console.WriteLine("Вторая цифра трезначного числа: " + SecondDigit(uzerNum));
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.Write("Введите число: ");
int uzerNum = Convert.ToInt32(Console.ReadLine());
if (uzerNum < 100)
Console.WriteLine("Нет третьей цифры.");
else
{
    int ThreeDigitNumber(uzerNum)
    {
        int uzerNum;
        int threeDigitNumber;
        while 
        (uzerNum > 999)
        uzerNum/10;
        else
        break;
    }
}


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/