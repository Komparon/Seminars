/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "5, 4, 3, 2, 1"
N = 6 -> "1, 2, 3, 4, 5, 6"

*/

void FactorialR(int n)

{
    Console.Write(n);
    if (n == 1)
    {
        return;
    }
    
        
    // return FactorialR(n - 1); // -1 на каждом шаге
    FactorialR(n - 1); // более короткий вариант решения
}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

FactorialR(n); // завершение метода
