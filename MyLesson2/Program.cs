/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int uzerNum = Convert.ToInt32(Console.ReadLine());
int SecondDigit(int userNum)
{
    return  (uzerNum / 10 ) % 10;
}

Console.WriteLine("Вторая цифра трезначного числа: " + SecondDigit(uzerNum));
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 int ThreeDigitNumber(int uzerNum)
    {
        while (uzerNum > 999)
            uzerNum/=10;
        return uzerNum;
    }

Console.Write("Введите число: ");
int uzerNum = Convert.ToInt32(Console.ReadLine());
if (uzerNum < 100)
Console.WriteLine("Нет третьей цифры.");
else
{
   uzerNum = ThreeDigitNumber(uzerNum);
   Console.WriteLine($"Третий знак: {uzerNum%10}");
}
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

byte DayOff(byte dayOfTheWeek)
{
    if(dayOfTheWeek < 6)
    Console.WriteLine("Это будний день");

    else if(dayOfTheWeek > 7)
        Console.WriteLine("Введите цифру < или = 7");
    else
    {
        Console.WriteLine("Это выходной день");
    }

    return dayOfTheWeek;
}

Console.Write("Введите день недели цифрой: ");
byte dayOfTheWeek = Convert.ToByte(Console.ReadLine());

dayOfTheWeek = DayOff(dayOfTheWeek);
*/