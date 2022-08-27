// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
string n2 = Convert.ToString(n1);
if (n2.Length > 2)
{
    Console.WriteLine($"{n1} -> " + n2[2]);
}
else
{
    Console.WriteLine($"{n1} -> третьей цифры нет");
}