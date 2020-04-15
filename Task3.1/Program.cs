using System;

namespace Task3._1
    //Калькулятор при помощи switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string sel;
            bool result;

            Console.WriteLine("Enter the first number: ");
            result = double.TryParse(Console.ReadLine(),out num1);
            if (!result) Console.WriteLine("\nYou entered something wrong!");
            else
            {
                Console.WriteLine("\nEnter the second number: ");
                result = double.TryParse(Console.ReadLine(), out num2);
                if (!result) Console.WriteLine("\nYou entered something wrong!");else
                {
                    Console.WriteLine("\nSelect operator: +,-,*,/");
                    sel = Console.ReadLine();

                    switch (sel)
                    {
                        case "+":
                            Console.WriteLine("\nSum = " + (num1 + num2));
                            break;
                        case "-":
                            Console.WriteLine("\nDifference = " + (num1 - num2));
                            break;
                        case "*":
                            Console.WriteLine("\nProduct = " + (num1 * num2));
                            break;
                        case "/":
                            Console.WriteLine("\nQuotient = " + (num1 / num2));
                            break;
                        default:
                            Console.WriteLine("\nYou entered something wrong!");
                            break;
                    }
                }
            }
            Console.WriteLine("\nPress 'Esc' to exit the programm!");
            ConsoleKey End = Console.ReadKey().Key;
            do
            {
                End = Console.ReadKey().Key;
            }
            while (End != ConsoleKey.Escape);








        }
    }
}
