using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        // Находим индекс первого вхождения символа '*'
        int starIndex = text.IndexOf('*');

        // Если символ '*' найден в строке
        if (starIndex != -1)
        {
            // Проходим по строке, начиная с символа после '*'
            for (int i = starIndex + 1; i < text.Length; i++)
            {
                // Если символ является прописной буквой, заменяем его на заглавную
                if (char.IsLower(text[i]))
                {
                    text = text.Substring(0, i) + char.ToUpper(text[i]) + text.Substring(i + 1);
                }
            }
        }

        // Выводим измененный текст
        Console.WriteLine("Измененный текст:");
        Console.WriteLine(text);
    }
}
