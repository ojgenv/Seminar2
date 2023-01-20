/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 6 || x == 7)
{
    Console.WriteLine("да");
}
else if (x > 7 || x < 1)
{
    Console.WriteLine("не день недели");
}
else
{
    Console.WriteLine("нет");
}