﻿// Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


//Мне очень хочется оптимизировать ввод, чтобы через запятую вводить 
//A и B. Только мне не удалось найти способ. Зато нашла способ вывести через
// return в методе. Хотя я плохо понимаю return и его возможности. Понятно, 
//что это результат действий функции, который нам нужно как бы запомнить. 
// Но его возможности для меня пока - тёмный лес. Чудо, что дошла, как
//строкой вывести ответ.

string Exponent(int num, int expo)
{
    return $"{num} в степени {expo} = {Math.Pow(num, expo)}";
}

Console.WriteLine("Введите число и его степень: ");
int number = int.Parse(Console.ReadLine());
int exponenta = int.Parse(Console.ReadLine());

Console.WriteLine(Exponent(number, exponenta));