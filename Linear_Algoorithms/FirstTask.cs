namespace Task_1
{
    class FirstTask
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());

            double s = Math.Pow(l, 2) / (4 * Math.PI);
            double r = Math.Sqrt(s / Math.PI);
            Console.WriteLine("Радиус окружности равен {0}", r);
            Console.WriteLine("Длина окружности равна {0}", s);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}