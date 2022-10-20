/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введи число:... ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberTxt = Convert.ToString(Number);
if (NumberTxt.Length > 2)
{
  Console.WriteLine("Третья цифра справа на лево ... " + NumberTxt[2]);
}
else {
  Console.WriteLine("Третьей цифры ... нет");
}