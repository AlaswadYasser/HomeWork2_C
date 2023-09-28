// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt("Введите число");

int fnum(int num)
{
 while (num > 999)
{
  num /= 10;
}
 return num % 10;
}

bool check(int num)
{
 if (num < 100)
 return false;
 else return true;
}

if (check(num) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine($"Третья цифра этого числа {num} -> {fnum(num)}");