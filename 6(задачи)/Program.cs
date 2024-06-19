using System;

class Program
{
    static void Main()
    {
        // Запрос числа
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        // Преобразование введенного значения в число
        if (int.TryParse(input, out int number))
        {
            // Проверка, равно ли число 5 или 10
            if (number == 5 || number == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число.");
            }
        }
        else
        {
            // Сообщение об ошибке при некорректном вводе
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        }
    }
}
