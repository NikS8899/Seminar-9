// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

string PrintNumbers (int start, int end)
{

// Базовый случай
if (start == end) return start.ToString();
// Рекурсивный случай
return (start + ", " + PrintNumbers(start+1, end));
}
int SumNumbers (int start, int end)
{
    int sum=0;
    if (start == end) return end;

    return (start +sum + SumNumbers(start+1, end));
}

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Все числа от M до N: {PrintNumbers(M, N)}");
Console.WriteLine();
Console.WriteLine($"Сумма всех чисел от M до N равна: {SumNumbers(M, N)}");

