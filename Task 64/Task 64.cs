// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string PrintNumbers (int start, int end)
{
// Базовый случай
if (start == end) return start.ToString();
// Рекурсивный случай
return (start + ", " + PrintNumbers(start+1, end));
}

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(M, N));
