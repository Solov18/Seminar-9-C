/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int n, m;
Console.Write($" Введите число: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($" Введите число: ");
int.TryParse(Console.ReadLine()!, out n);
Summa(m, n);
Console.Write(Summa(m - 1, n));

/*string Numbers(int m, int n)
{
    if (m >= n)
        return m.ToString();
    return $"{m.ToString()}, {Numbers(m + 1, n)}";
}*/

int Summa(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Summa(m, n);
        return res;
    }
}