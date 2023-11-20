{
        Console.WriteLine("Введите координаты точки (X и Y):");

        Console.Write("X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        int quadrant = GetQuadrant(x, y);

        Console.WriteLine($"Точка находится в {quadrant} четверти.");
    }

    static int GetQuadrant(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else if (x > 0 && y < 0)
        {
            return 4;
        }
        else
        {
            // Если точка лежит на одной из координатных осей
            return 0;
        }
    }

