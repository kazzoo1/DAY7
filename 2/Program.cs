using System;

class Program
{
    static int CountPunctuationErrors(string text)
    {
        char[] punctuations = { '.', ',', '!', '?' };
        int errorsCount = 0;

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (Array.IndexOf(punctuations, text[i]) != -1)
            {
                if (text[i + 1] != ' ' && text[i + 1] != '\n' && text[i + 1] != '\t')
                {
                    errorsCount++;
                }
            }
        }

        // Проверяем, не заканчивается ли текст знаком препинания
        if (Array.IndexOf(punctuations, text[text.Length - 1]) != -1)
        {
            errorsCount++; // Также считаем ошибкой
        }

        return errorsCount;
    }

    static void Main()
    {
        Console.WriteLine("Введите текст для проверки:");
        string text = Console.ReadLine();

        int errors = CountPunctuationErrors(text);
        Console.WriteLine($"Количество ошибок в тексте (отсутствие пробела после знака препинания): {errors}");
    }
}
