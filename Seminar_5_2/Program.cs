/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да */

//  int[] array = new int[6] {6, 7, 19, 345, 3, 778};

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo, n, c = 0;
            string s;
            Console.WriteLine("Ввод массива целых чисел и проверка числа(входит ли это число в массив).");
            Console.Write("Введите число, которое соответствует колличеству чисел в массиве: ");
            s = Console.ReadLine();
            n = Convert.ToInt32(s);
            Console.WriteLine("Вводите массив: ");
            int i;
            int[] x = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("-> ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                c = x[i];
            }
            Console.Write("Введите число какое вы хотите проверть, находится ли он в массиве или нет: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы вели число: " + chislo + " ,теперь ищем есть ли это число в массиве!");
            bool flag = false;//Объявляем переменную - флаг
            for(i=0;i<n;++i)
            {
                 if (x[i]==chislo)
                {
                    Console.WriteLine("Да ваше число совпадает с числом из массива!");
                    Console.WriteLine(x[i] + " = " + chislo);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Такого числа нет");
                return;
            }
            Console.ReadKey();
        }
    }
}