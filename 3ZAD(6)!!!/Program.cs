using System;

namespace _3ZAD_6____
{
    class Program
    {
        static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("введите размер массива");
            Console.Write("n = ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            Console.Write("Ошибка, Введите n заново\n");

            Console.Write("m = ");
            while (!int.TryParse(Console.ReadLine(), out m) || m <= 0) 
            Console.WriteLine("Ошибка, Введите m заново\n");

            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                   
                    Console.Write("a[{0},{1}]= ", i, j);
                    while (!int.TryParse(Console.ReadLine(), out a[i, j]))
                    {
                        Console.Write("Ошибка" + $"Введите заново [{i},{j}]: ");
                    }
                }
            Console.WriteLine("До: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    int x = a[i, j];
                    a[i, j] = a[i, (m - 1) - j];
                    a[i, (m - 1) - j] = x;
                }
            }
            Console.WriteLine("После: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
            return a;
        }
        static void Main()
        {
            int n;
            int m;
            int[,] myArray = Input(out n, out m);
        }
    }
}
