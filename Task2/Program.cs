using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer number: ");
            bool result = int.TryParse(Console.ReadLine(), out int num);//Проверяем ввод данных на корректность

            if (result)//если ввели целое число, то выполняем...
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("You entered even number!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You entered odd number!");
                    Console.ReadLine();
                }
            }
            else//если ввели что-то другое, то выполняем...
            {               
                Console.WriteLine("You entered something wrong!");
                Console.ReadLine();
            }
        }
    }
}
