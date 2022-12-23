

Console.WriteLine("Введите день недели, что бы определить Рабочий это день или Выхондой");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek > 0 && dayWeek < 8)
    {
        if (dayWeek == 7 || dayWeek == 6)
        {
            Console.Write($"Под цифрой {dayWeek} - Выходной");
        }
        else
        {
            Console.Write($"Под цифрой {dayWeek} - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }	