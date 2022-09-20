/*Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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

/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = LinSegment("x", "A");
int x2 = LinSegment("x", "B");
int y1 = LinSegment("y", "A");
int y2 = LinSegment("y", "B");
int z1 = LinSegment("z", "A");
int z2 = LinSegment("z", "B");

int LinSegment(string coorName, string pointName)
{
  Console.Write($"Введите координату {coorName} точки {pointName}: ");
  return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
*/

/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
*/