using System;
class MyClass
{
    public static void Main()
    {
        Console.WriteLine("Введите число.");
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Введена пустая строка.");
            return;
        }

        if (Int32.TryParse(input, out int _))
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write($"{chars[i]}");
                if (i != chars.Length - 1) Console.Write(", ");
            }
        }
    }
}