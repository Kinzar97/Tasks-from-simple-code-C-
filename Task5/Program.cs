using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {//Нарисовать треугольники с помощью вложенных циклов без условий
            int i = 1;

            Console.WriteLine();

            for (;i<10; i++)
            {
                
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write("#");
                    
                }
                Console.WriteLine();
                
            }

            i--;
 
            Console.WriteLine();
            Console.WriteLine();


            for (; i > 0; i--)
            {
                for (int j = 1; j < i + 1; j++)
                {                    
                    Console.Write("#");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();

            i = 10;
            for (; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int l = 1; l<11-i; l++)
                { 

                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            i = 9;
            for (; i > 0; i--)
            {
                for (int l = 9; l > i; l-- )
                {
                    Console.Write(" ");
                }              
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}
