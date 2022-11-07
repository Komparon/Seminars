/* 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.*/
// <возвращаемый тип данных><Наименование метода>(Переменные){собственно операции(тело) метода-функции}
int GetPointArea(int coordX, int coordY)
{
     int NumberArea = 0;
    if (coordX > 0 && coordY > 0)
    {
        NumberArea = 1;
    }
     if (coordX < 0 && coordY > 0)
    {
        NumberArea = 2;
    }
     if (coordX < 0 && coordY < 0)
    {
        NumberArea = 3;
    }
     if (coordX > 0 && coordY < 0)
    {
        NumberArea = 4;
    }

return NumberArea;
}
int NumberArea = 0;
Console.Write("Введи число X:...");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи число Y:...");
int y = Convert.ToInt32(Console.ReadLine());

NumberArea = GetPointArea(x, y);
Console.WriteLine(NumberArea);
