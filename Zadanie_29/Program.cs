using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8]; // Создание массива из 8 элементов

        Console.WriteLine("Введите 8 чисел, разделенных пробелом:");

        string input = Console.ReadLine();

        // Разделение строки на числа и заполнение массива
        string[] inputNumbers = input.Split(' ');

        // Валидация ввода
        if (inputNumbers.Length != 8)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите 8 чисел, разделенных пробелом.");
            return;
        }

        for (int i = 0; i < 8; i++)
        {
            if (!int.TryParse(inputNumbers[i], out numbers[i]))
            {
                Console.WriteLine("Некорректный ввод числа. Пожалуйста, введите целое число.");
                return;
            }
        }

        // Вывод элементов массива
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("[" + i + "]: " + numbers[i]);
        }

        Console.ReadLine();
    }
}

