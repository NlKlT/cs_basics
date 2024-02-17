using System;

namespace BranchingAlgorithms3
{
    class BranchingAlgorithms3
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 20 || age > 69)
            {
                Console.WriteLine("Error: Age must be between 20 and 69.");
                return;
            }

            string[] decades = {"двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят"};
            string[] units = {"один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};

            int decade = age / 10 * 10;
            int unit = age % 10;

            if (unit == 0)
            {
                Console.WriteLine($"Ваш возраст: {decades[decade/10 - 2]} лет");
            }
            else if (unit == 1)
            {
                Console.WriteLine($"Ваш возраст: {decades[decade/10 - 2]} год");
            }
            else
            {
                Console.WriteLine($"Ваш возраст: {decades[decade/10 - 2]} года");
            }
        }
    }
}

