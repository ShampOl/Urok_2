     {
        Console.WriteLine("Введите целое число из отрезка [10, 99]:");

        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 10 && number <= 99)
        {
            int maxDigit = GetMaxDigit(number);

            Console.WriteLine($"Наибольшая цифра числа {number} - {maxDigit}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число из отрезка [10, 99].");
        }
    }

    static int GetMaxDigit(int num)
    {
        int maxDigit = 0;

        while (num > 0)
        {
            int digit = num % 10;

            if (digit > maxDigit)
            {
                maxDigit = digit;
            }

            num /= 10;
        }

        return maxDigit;
    }


