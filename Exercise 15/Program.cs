/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);

if ((number >= 1) && (number <= 5))
{
     Console.WriteLine("нет");
}

else if ((number == 6) || (number == 7))
{
    Console.WriteLine("да");
}

else
{
    Console.WriteLine("Такого дня недели нет");
}