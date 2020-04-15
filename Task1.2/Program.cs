using System;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            double number3;
            double sum;
            double mult;

            Console.WriteLine("Enter the first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            sum = number1 + number2 + number3;
            mult = number1 * number2 * number3;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Multiplication = " + mult);
        }
    }
}
