// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// вызов функции Аккермана
void AkkermanFunction(int n, int m)
{
    Console.Write(Akkerman(n, m)); 
}

// функция Аккермана
int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n > 0)
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return (Akkerman(n - 1, Akkerman(n, m - 1)));
    }
}

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(n,m);
