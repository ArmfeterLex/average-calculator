using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два любых числа");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        double c = a + b;
        double d = Math.Round(c/2, 2);
        Console.WriteLine("Среднее арифметическое этих чисел {0:f2}", d);
        Console.ReadKey();
    }
}