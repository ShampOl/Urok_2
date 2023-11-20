 {
        Console.WriteLine("Введите натуральное число N:");

        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine($"Цифры числа {n} через запятую: {GetDigitsSeparatedByComma(n)}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите натуральное число.");
        }
    }

    static string GetDigitsSeparatedByComma(int number)
    {
        string result = "";

        // Преобразование числа в строку и перебор каждой цифры
        foreach (char digitChar in number.ToString())
        {
            // Добавление цифры в строку результата
            result += digitChar + ",";
        }

        // Удаление последней запятой, если она есть
        if (result.EndsWith(","))
        {
            result = result.Remove(result.Length - 1);
        }

        return result;
    }