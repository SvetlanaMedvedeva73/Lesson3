/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int b;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);

string str = b.ToString();

if (str[0] == str[4] && str[1] == str[3])
    Console.Write($"Число является палиндромом");
else
     Console.Write($"Число не является палиндромом");


