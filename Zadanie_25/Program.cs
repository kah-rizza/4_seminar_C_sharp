using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число A:");
        double A;
        if (!double.TryParse(Console.ReadLine(), out A))
        {
            Console.WriteLine("Некорректный ввод числа A. Пожалуйста, введите число.");
            return;
        }

        Console.WriteLine("Введите число B:");
        int B;
        if (!int.TryParse(Console.ReadLine(), out B) || B < 0)
        {
            Console.WriteLine("Некорректный ввод числа B. Пожалуйста, введите неотрицательное целое число.");
            return;
        }

        double result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        Console.WriteLine("Результат: " + result);
        Console.ReadLine();
    }
}
