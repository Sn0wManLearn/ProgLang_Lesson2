using System;
class MyClass
{
    public static void Main()
    {
        Console.WriteLine("Введите число от 10 до 99.");
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Введена пустая строка.");
            return;
        }
        if (!int.TryParse(input, out int num))
        {
            Console.WriteLine("Число введено не корректно");
            return;
        }
        if (num < 10 || num > 99)
        {
            Console.WriteLine("Введенное число не входит в заданный диапазон.");
            return;
        }
        int digit1 = num / 10;
        int digit2 = num % 10;

        int res = digit1 > digit2 ? digit1 : digit2;
        Console.WriteLine($"Во введенном числе {num} наибольшей является цифра {res}.");
    }
}