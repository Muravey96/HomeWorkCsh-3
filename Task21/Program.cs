/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


Console.Write("Введите X координату 1й точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y координату 1й точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z координату 1й точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Х координату 2й точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y координату 2й точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z координату 1й точки: ");
double z2 = Convert.ToDouble(Console.ReadLine()); 

double result = DisPoint(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"{result}");

static double DisPoint(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
}


