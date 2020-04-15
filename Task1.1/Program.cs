using System;

namespace Task1_from_simpleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1; 
            double number2;
            double middle;
            
            Console.WriteLine("Enter the first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            middle = (number1 + number2) / 2;

            Console.WriteLine("Middle number = " + middle);
            Console.ReadLine();
            


        }
    }
}
