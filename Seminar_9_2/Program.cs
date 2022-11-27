/* 
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int FactorialR(int n)

{
       
    if (n /10 == 0)
    {
        return n;
    }
       
  return (n % 10) + FactorialR(n / 10);


}



Console.WriteLine(FactorialR(n)); // завершение метода
