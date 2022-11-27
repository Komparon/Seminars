/* 
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/
// int m = 0;
// int n = 0;

Console.Write("Введите M (начало): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N (конец): ");
int n = Convert.ToInt32(Console.ReadLine());

void FactorialR(int m, int n)

{
    Console.Write(m + " ");
    if (n == m)
    {
        return;
    }
    
        
    // return FactorialR(n - 1); // -1 на каждом шаге
    FactorialR(m + 1, n); // более короткий вариант решения

}




FactorialR(m, n); // завершение метода
