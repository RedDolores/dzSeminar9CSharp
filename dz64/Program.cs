// Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string PrintNumbers(int n)
{
    if (n == 0 || n == 1) return ("1 ");
    return $"{n} " + PrintNumbers(n - 1);
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(N));