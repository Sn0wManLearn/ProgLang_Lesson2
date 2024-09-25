using System;
class MyClass
{
    public static void Main()
    {
        Console.WriteLine("Введите значения координат, разделенные пробелом");
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Введена пустая строка");
            return;
        }
        string[] nums = input.Split(' ');
        int x = Int32.Parse(nums[0]);
        int y = Int32.Parse(nums[1]);

        string result = "Четверть № ";
        if (x > 0 && y > 0) result += "I";
        if (x < 0 && y > 0) result += "II";
        if (x < 0 && y < 0) result += "III";
        if (x > 0 && y < 0) result += "IV";
        Console.WriteLine(result);
    }
}