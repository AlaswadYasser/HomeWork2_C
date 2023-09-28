// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string msg)
{

System.Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
 int num = Prompt("какой день недели с (1 _ 7)");
 string n = "в недели только 7 дней)";
 string check(int num)
{
 if (num >= 6 && num < 8) 
     n = " -> да, это выходной"; 
 if (num >= 1 && num < 6) 
     n = " -> нет, это будний день";
 return n;
}
System.Console.WriteLine(check(num));