using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (words.Length < 3)
        {
            Console.WriteLine("Введенное предложение содержит менее трех слов.");
            return;
        }

        // Поменять местами первое и последнее слова
        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;

        // Склеить второе и третье слова
        string mergedWords = words[1] + words[2];

        // Третье слово в обратном порядке
        char[] thirdWordArray = words[2].ToCharArray();
        Array.Reverse(thirdWordArray);
        string thirdWordReversed = new string(thirdWordArray);

        // Удалить первые две буквы первого слова
        string firstWordModified = words[0].Length > 2 ? words[0].Substring(2) : "";

        Console.WriteLine("Первое и последнее слова поменяны местами: " + string.Join(" ", words));
        Console.WriteLine("Второе и третье слова склеены: " + mergedWords);
        Console.WriteLine("Третье слово в обратном порядке: " + thirdWordReversed);
        Console.WriteLine("Первое слово без первых двух букв: " + firstWordModified);
    }
}