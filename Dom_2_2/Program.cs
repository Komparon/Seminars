/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 6 -> да
 7 -> да
 1 -> нет */

 
Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());


 if (dayNum == 6 || dayNum == 7) {
  Console.WriteLine("Да, этот день выходной");
  }
  else if (dayNum < 1 || dayNum > 7) {
    Console.WriteLine("Дней недели всего семь!");
  }
  else Console.WriteLine("Нет, это рабочий день недели");

