// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akk (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberM > 0 && numberN == 0) return Akk(numberM - 1, 1);
    return (Akk(numberM - 1, Akk(numberM, numberN - 1)));
}



Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Функция аккермана для чисел {m} и {n} равна {Akk(m, n)}");   