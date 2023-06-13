/*

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
AB = v(x2 - x1 - z1 )^2 + (y2 - y1 - z1)^2
6 координат : А(x1,y1,z1) B(x2,y2,z2) 

Console.Write("Введите кординату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату y2: ");
int y2= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z1-z2,2));
Console.WriteLine($"Расстояние между точками равно A:{x1},{y1},{z1} и B:{x2},{y2},{z2} равно: {Math.Round(d,2)}");

*/

/*

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
/*

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
Console.Write(Math.Pow(i, 3) + "\t"); // i * i
// \t = Tab (1 2 3)
}
// (точка входа)
// int i = 1;
// while (i <= N)
// {
// Console.Write(Math.Pow(i, 2) + "\t"); // i * i
// i++;
// }

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.WriteLine("Задача 19");
Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");