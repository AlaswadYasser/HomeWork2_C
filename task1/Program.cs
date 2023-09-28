// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt("Введите трехзначное число");
if (num >=100 && num <1000)
{
 int mid = (num % 100 - num % 10) / 10;
 System.Console.WriteLine($"Вторая цифра здесь {num} -> это {mid}");
}
else
System.Console.WriteLine("число не трехзначное");