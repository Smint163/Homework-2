/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите любое число");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);


if (number > 99)
{
    string str = number.ToString();
    Console.WriteLine($"{str[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
