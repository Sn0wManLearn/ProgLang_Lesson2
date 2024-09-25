using System;
class MyClass
{
    public static void Main()
    {
        Console.WriteLine("Введите число");
        if (!Int32.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Число введено не корректно.");
            return;
        }
        if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"Число {num} кратно 7 и 23");
        else Console.WriteLine($"Число {num} некратно 7 и 23");
    }
}