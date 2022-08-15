// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Решить без использования строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int num1 = (number / 10) % 10;
int result = num1;
Console.WriteLine($": {result}");

