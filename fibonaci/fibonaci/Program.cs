using System;

namespace fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul termenilor");
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 1, secondNumber = 1, fNumber;

            Console.WriteLine("Number (0) = 1 ");
            Console.WriteLine("Number (1) = 1 ");

            for (int i = 2; i < n; i++)
            {
                fNumber = firstNumber + secondNumber;
                secondNumber = firstNumber;
                firstNumber = fNumber;

                Console.WriteLine($"Number ({i}) = {fNumber} " );
            }

            Console.Read();

        }
    }
}
