/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Pow(int a, int b)
{
    if(b == 0)
    {
        return 1;
    }

    return  a * Pow(a, b - 1);
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Pow(a, b));


/* еще один вариант
int  GetExponentiation(int a, int b)
{           
            
    if (b == 0)
    {               
        return 1;
    }
    return a * GetExponentiation( a, b - 1);
}

Console.WriteLine("Введите число: A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: B ");
int b = Convert.ToInt32(Console.ReadLine());
int result =  GetExponentiation(a, b);
System.Console.WriteLine($"Числo {a} в степени {b} = {result}");

*/