/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница */

Console.WriteLine("Введите число дня недели: ... ");
int namberWeek = Convert.ToInt32(Console.ReadLine());
if (namberWeek > 7 || namberWeek < 1  )
{
     Console.WriteLine("Дней недели всего 7");
}
else    
{
if (namberWeek == 1)
{
    Console.WriteLine("Сегодня понедельник");
}
if (namberWeek == 2)
{
    Console.WriteLine("Сегодня вторник");
}
if (namberWeek == 3)
{
    Console.WriteLine("Сегодня среда");
}
if (namberWeek == 4)
{
    Console.WriteLine("Сегодня четверг");
}
if (namberWeek == 5)
{
    Console.WriteLine("Сегодня пятница");
}
if (namberWeek == 6)
{
    Console.WriteLine("Сегодня суббота");
}
if (namberWeek == 7)
{
    Console.WriteLine("Сегодня Воскресенье");
}
}