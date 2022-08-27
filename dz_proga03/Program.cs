// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру деня недели: ");
int dayNumb = Convert.ToInt32(Console.ReadLine());

void CheckingDayTheWeek(int dayNumb)
{
    if (dayNumb == 6 || dayNumb == 7)
    {
        Console.WriteLine($"{dayNumb} -> да, выходной");
    }
    if (dayNumb > 0 && dayNumb < 6)
    {
        Console.WriteLine($"{dayNumb} -> нет, не выходной");
    }
    else
     { Console.WriteLine($"{dayNumb} -> это не день недели"); }
}
CheckingDayTheWeek(dayNumb);
