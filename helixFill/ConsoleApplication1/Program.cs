using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив__заполненный_улиткой
{

    class Program
    {
        static void show(int[,] aMas, int aRows, int aColumns)
        {
            for (int i = 0; i < aRows; i++)
            {
                for (int j = 0; j < aColumns; j++)
                {
                    Console.Write("{0,3}", aMas[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void FillHelix(ref int[,] aMas, int aRows, int aColumns)
        {
            int ai = aRows;
            int aj = aColumns;
            int Summ = aColumns * aRows;
            int CorrectY = 0;
            int CorrectX = 0;
            int Count = 1;
            while (aRows > 0)
            {
                for (int y = 0; y < 4; y++)
                {
                    for (int x = 0; x < ((aColumns < aRows) ? aRows : aColumns); x++)
                    {
                        if (y == 0 && x < aColumns - CorrectX && Count <= Summ)
                            aMas[y + CorrectY, x + CorrectX] = Count++;
                        if (y == 1 && x < aRows - CorrectY && x != 0 && Count <= Summ)
                            aMas[x + CorrectY, aColumns - 1] = Count++;
                        if (y == 2 && x < aColumns - CorrectX && x != 0 && Count <= Summ)
                            aMas[aRows - 1, aColumns - (x + 1)] = Count++;
                        if (y == 3 && x < aRows - (CorrectY + 1) && x != 0 && Count <= Summ)
                           aMas[aRows - (x + 1), CorrectY] = Count++;
                        show(aMas, ai, aj);
                    }
                }
                aRows--;
                aColumns--;
                CorrectY += 1;
                CorrectX += 1;
            }
        }
        static void Main(string[] args)
        {
            
            int sizeY = 5;
            int sizeX = 3;
            int[,] arr = new int[sizeY, sizeX];

            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    arr[i, j] = 0;
                }
                Console.WriteLine();
            }
            FillHelix(ref arr, sizeY, sizeX);
        }
    }
}
