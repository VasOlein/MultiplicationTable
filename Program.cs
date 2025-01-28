using System;

namespace МАПО_Пр_01_Васильев_Олейников
{
    class Program
    {
        static void Main()
        {
            PrintMultiplTableUmnaz();
        }

        static void PrintMultiplTableUmnaz()
        {

        Console.WriteLine("Таблица умножения\n--------------------------------------------");

            Console.Write(" |");
            for (int i = 1; i<= 10; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();

            Console.WriteLine(new string('-', 44));
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i, 3}|");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
    }
}
