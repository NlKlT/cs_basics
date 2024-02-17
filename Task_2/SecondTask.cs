using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter coordinates of point 1 (x y): ");
        string[] point1 = Console.ReadLine().Split();
        int x1 = int.Parse(point1[0]);
        int y1 = int.Parse(point1[1]);

        Console.Write("Enter coordinates of point 2 (x y): ");
        string[] point2 = Console.ReadLine().Split();
        int x2 = int.Parse(point2[0]);
        int y2 = int.Parse(point2[1]);

        Console.Write("Enter coordinates of point 3 (x y): ");
        string[] point3 = Console.ReadLine().Split();
        int x3 = int.Parse(point3[0]);
        int y3 = int.Parse(point3[1]);

        // Check if the first and second points define a horizontal side
        if (y1 == y2)
        {
            // Third point must define a vertical side
            if (x3 == x1 || x3 == x2)
            {
                // Calculate the coordinates of the fourth point
                int x4 = x1 == x3 ? x2 : x1;
                int y4 = y1 == y2 ? y3 : y2;

                Console.WriteLine($"The fourth point has coordinates ({x4}, {y4})");
            }
            else
            {
                Console.WriteLine("The given points do not form a rectangle.");
            }
        }
        else if (x1 == x2)
        {
            // Third point must define a vertical side
            if (y3 == y1 || y3 == y2)
            {
                // Calculate the coordinates of the fourth point
                int x4 = x1 == x3 ? x2 : x3;
                int y4 = y1 == y3 ? y2 : y3;

                Console.WriteLine($"The fourth point has coordinates ({x4}, {y4})");
            }
            else
            {
                Console.WriteLine("The given points do not form a rectangle.");
            }
        }
        else
        {
            Console.WriteLine("The given points do not form a rectangle.");
        }
    }
}