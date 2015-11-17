using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Spiral
    {
        int[,] mass;

        public Spiral(int n, int m)
        {
            mass = new int[n, m];
            DoingSpiral();
        }

        public void DoingSpiral()
        {
            int fill = 0;
            int k = 0;
            int g = 0;

            while (k < mass.GetLength(0) * mass.GetLength(1))
            {
                Console.WriteLine($"цикл while прошел {g} и k = {k}");
                Console.ReadLine();
                for (int j = 0 + g; j < mass.GetLength(1) - g; j++) //слева на право
                {
                    int i = 0 + g;
                    fill++;
                    mass[i, j] = fill;
                    
                    k++;
                }
                Print();
                for (int i = 1 + g; i < mass.GetLength(0) - g - 1; i++) //сверху вниз
                {
                    int j = mass.GetLength(1) - g - 1;
                    fill++;
                    mass[i, j] = fill;
                    
                    k++;
                }
                Print();
                for (int j = mass.GetLength(1) - 1 - g; j > 0 + g; j--) //справа на лево
                {
                    int i = mass.GetLength(0) - g - 1;
                    fill++;
                    mass[i, j] = fill;
                    k++;
                }
                Print();
                for (int i = mass.GetLength(0) - 1 - g; i > 0 + g; i--) //снизу вверх
                {
                    int j = 0 + g;
                    fill++;
                    mass[i, j] = fill;
                    k++;
                }
                Print();
                g++;
            }

        }

        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($"{mass[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
