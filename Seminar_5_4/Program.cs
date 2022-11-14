/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
/* пытались решить с использованием массива, размер которого определяли как половина +1 для нечетных массивов
int[] array = new int[11];
int halfarray = array.Length / 2;
if(halfarray % 2 != 0)
{
    halfarray = halfarray + 1;
}
int[] newarray = new int[halfarray];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
Console.Write("Старый массив [{0}]", string.Join(", ", array));
for (int i = 0; i < halfarray; i++)
{
    int sum = array[i] * array[array.Length - 1 - i];
    newarray[i] = sum;
}
Console.WriteLine();
Console.WriteLine("Новый массив [{0}]", string.Join(", ", newarray));
*/

int[] array = new int[10];
int halfarray = array.Length / 2;
int[] newarray = new int[halfarray];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    // Console.Write(array[i] + " ");
}
Console.WriteLine("Старый массив [{0}]", string.Join(", ", array));
for (int i = 0; i < halfarray; i++)
{
    int sum = array[i] * array[array.Length - 1 - i];
    newarray[i] = sum;
    //Console.Write($" {sum}");
}
Console.WriteLine();
Console.WriteLine("Новый массив [{0}]", string.Join(", ", newarray));

