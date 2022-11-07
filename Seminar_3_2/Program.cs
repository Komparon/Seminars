/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

double GetDistans (int x1, int y1, int x2, int y2)
{
    double Distans =0;
    Distans = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
return Distans;
}
Console.Write("Введи координаты 1 точки X:...");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи координаты 1 точки Y:...");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи координаты 2 точки X:...");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи координаты 2  Y:...");
int y2 = Convert.ToInt32(Console.ReadLine());


double result = GetDistans (x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками {result}");