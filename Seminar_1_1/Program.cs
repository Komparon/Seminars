// Напишите программу, которая принимает на вход два числа и вычиляет не является ли одно квадратом другого.
Console.WriteLine("Введите число №1: ... ");
int namberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: ... ");
int namberB = Convert.ToInt32(Console.ReadLine());
if (namberA == namberB*namberB)
{
    Console.WriteLine($"True: число А = {namberA} является квадратом Б = {namberB}");
}
else
{
    Console.WriteLine($"False: число А = {namberA} НЕ является квадратом Б = {namberB}");
}