using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите фамилию, имя и отчество:");
        string fullName = Console.ReadLine();

        // Преобразование в код личности
        int personalCode = CalculatePersonalCode(fullName);

        Console.WriteLine("Код личности: " + personalCode);
    }

    static int CalculatePersonalCode(string fullName)
    {
        // Очистка строки от пробелов и перевод в верхний регистр
        fullName = fullName.Replace(" ", "").ToUpper();

        int sum = 0;

        // Преобразование каждой буквы в числовое значение и сложение
        foreach (char c in fullName)
        {
            if (c >= 'А' && c <= 'Я')
            {
                sum += (c - 'А' + 1); // Порядковый номер в русском алфавите
            }
        }

        // Складывание чисел до получения однозначного числа
        while (sum > 9)
        {
            sum = SumOfDigits(sum);
        }

        return sum;
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}  