﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Пользователь, напишите, пожалуйста, 1, 2 и 3 число");
int a = int.Parse (Console.ReadLine());
int b = int.Parse (Console.ReadLine());
int c = int.Parse (Console.ReadLine());
int max = a;
if(b > max) 
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.WriteLine($"Из чисел {a}, {b}, и {c} максимальное {max}");