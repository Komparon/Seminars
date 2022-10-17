/* 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит 
остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
 
// int result = a % b;

// Console.WriteLine (result);
if (a % b == 0)
{
    Console.WriteLine("число кратно");
}
else
{
    Console.WriteLine($"число не кратно, остаток = {a % b}");
}

/*
Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
 
double result = (double)a /(double) b;
Console.WriteLine($" число {result}");

Console.WriteLine($"остаток деления {a % b}");
*/