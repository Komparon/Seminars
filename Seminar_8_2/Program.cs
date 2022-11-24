/* 
Решение в группах задач:
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая запишет нулями строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
4 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
0 0 0 0
0 9 4 2
0 2 2 6
0 3 4 7
*/


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            //Console.Write(array[i, j] + " ");
        }
        //Console.WriteLine();
    }
}

// Вывести двумерный массив в консоль в виде матрицы.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] array)
{
    int min = array[0, 0];
    int minRow = 0; 
    int minCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[minRow, j] = 0;
            array[i, minCol] = 0;
        }
    }
}

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
ChangeArray(arr);
PrintArray(arr);