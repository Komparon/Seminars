// Напишите программу, которая принимает на вход целое число и выдает его квадрат
Console.WriteLine("Введите число: ... ");
int namberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(namberA*namberA);
int sqrNumber = namberA*namberA;
// Console.WriteLine("Вывод результата на экран. Квадрат вашего числа равен ... ");
// Console.WriteLine(sqrNumber);
Console.WriteLine($"Вывод результата на экран. Квадрат вашего числа равен ... {sqrNumber} "); //  нужно установить после ( значек $ b и после в фигурных скобках можно обратиться к переменной)