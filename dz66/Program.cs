﻿// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int rec(int n, int m) 
{ 
    int sum = m; 
    if (m == n) 
        return sum; 
    return sum += rec(n, m - 1) ; 
} 
 
 
Console.Write("Введите число m: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число n: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(rec(n, m));
