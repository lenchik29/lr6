using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Runtime;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение: ");
            double resultAdd = Class1.Add(4, 53);
            Console.WriteLine(resultAdd);
            Console.ReadLine();

            Console.WriteLine("Вычитание: ");
            double resultSub = Class1.Substract(24, 5);
            Console.WriteLine(resultSub);
            Console.ReadLine();

            Console.WriteLine("Умножение: ");
            double resultMul = Class1.Multiply(2555, 2);
            Console.WriteLine(resultMul);
            Console.ReadLine();

            Console.WriteLine("Деление: ");
            double resultDiv = Class1.Divide(64, 8);
            Console.WriteLine(resultDiv);
            Console.ReadLine();
        }
    }
}

