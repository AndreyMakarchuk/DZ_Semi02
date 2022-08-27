// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int des = num / 10 % 10;
if (num > 99 && num < 1000)
{
        Console.WriteLine($"{num} -> {des}");
}
else
{
    Console.WriteLine($"{num} -> неверное число");
}