/*  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.Write("Введи число А:...");
int F = Convert.ToInt32(Console.ReadLine());

int mex = F/2;

if (F == mex*2)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
