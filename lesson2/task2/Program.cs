Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = number;

while (number < 99)
    {
          Console.WriteLine($"В числе {number} третьей цифры нет");
		  Console.WriteLine("Введите любое число: ");
		  number = Convert.ToInt32(Console.ReadLine());
    }
    {
         if (number >= 100 && number <= 1000)
			{
		  	Console.WriteLine($"Третья цифра в числе {number} , будет {number % 10}");
			}
			else
			{
				while (number > 1000)
					number = number / 10;
					Console.WriteLine($"Третья цифра в числе {numberA} , будет {number % 10}");
	
            }
    }