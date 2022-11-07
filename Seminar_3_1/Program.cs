/* Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
*/
/* void GetXYArea(int chetvert)
{
    
    if (chetvert == 1)
    {
       Console.WriteLine ("coordX > 0 && coordY > 0");
    }
      
    if (chetvert == 2)
    {
       Console.WriteLine ("coordX < 0 && coordY > 0");
    } 
    if (chetvert == 3)
    {
       Console.WriteLine ("ccoordX < 0 && coordY < 0");
    } 
    if (chetvert == 4)
    {
       Console.WriteLine ("coordX > 0 && coordY < 0");
    }


}


Console.Write("Введи четверть:...");
int chetvert = Convert.ToInt32(Console.ReadLine());

GetXYArea(chetvert); */

string GetXYArea(int chetvert)
{
    
    if (chetvert == 1)
    {
       return "coordX > 0 && coordY > 0";
    }
      
    if (chetvert == 2)
    {
       return "coordX < 0 && coordY > 0";
    } 
    if (chetvert == 3)
    {
       return "ccoordX < 0 && coordY < 0";
    } 
    if (chetvert == 4)
    {
       return "coordX > 0 && coordY < 0";
    }
 return "четверти нет";

}


Console.Write("Введи четверть:...");
int chetvert = Convert.ToInt32(Console.ReadLine());

string result = GetXYArea(chetvert);
Console.WriteLine(result);
 
// Console.WriteLine(GetXYArea(chetvert)); 
