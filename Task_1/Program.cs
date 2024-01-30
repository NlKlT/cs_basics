using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Programm
    {
        static void Main(string[] args)
        {
            #region Инициализация переменных
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            #endregion

            int sum = firstNumber + secondNumber;
            Console.WriteLine("{2} + {1} = {0}", sum, firstNumber, secondNumber);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}