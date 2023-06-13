using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();

        // Валидация ввода
        if (!IsValidNumber(input))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            return;
        }

        int number = int.Parse(input);

        // Вычисление суммы цифр
        int sum = GetDigitSum(number);

        Console.WriteLine("Сумма цифр в числе: " + sum);
        Console.ReadLine();
    }

    // Проверка валидности числа
    static bool IsValidNumber(string input)
    {
        int number;
        return int.TryParse(input, out number);
    }

    // Вычисление суммы цифр в числе
    static int GetDigitSum(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10; // Получаем последнюю цифру числа
            sum += digit; // Добавляем цифру к сумме
            number /= 10; // Удаляем последнюю цифру числа
        }

        return sum;
    }
}
