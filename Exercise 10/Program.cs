/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
string num= Console.ReadLine();
int number = Convert.ToInt32(num);

{
    int result = ((number - (((number / 100) * 100) + (number % 10))) / 10);
    Console.WriteLine($"{result}");
}
