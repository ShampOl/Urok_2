Console.WriteLine("Введите число: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (IsMultiple0f7And23(number))
    {
        Console.WriteLine($"{number} кратно 7 и 23");
    }
   else
   {
    Console.WriteLine($"{number} не кратно одновременно 7 и 23");
   }
}

else
{
    Console.WriteLine("Неккоректный ввод. Пожалуйста, введите целое число.");
}


static bool IsMultiple0f7And23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

