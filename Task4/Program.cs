using System;

namespace Task4
{//Подсчёт целых четных и нечтных чисел в диапазоне, который указал пользователь
    class Program
    {
        static void Main(string[] args)
        {
            int numberFirst, numberSec;
            int countEven = 0, countOdd = 0;
            
            Console.WriteLine("Enter range of numbers [a;b]");
            Console.Write("Enter the first number: ");
            numberFirst = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numberSec = int.Parse(Console.ReadLine());

            while (numberFirst<numberSec+1)
            {
                if (numberFirst%2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
                numberFirst++;
            }
            Console.WriteLine("Count even numbers: " + countEven + "\n" + "Count odd numbers: "+ countOdd);
            Console.ReadLine();

        }
    }
}
