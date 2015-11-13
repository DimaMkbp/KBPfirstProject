using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class DefEx : Exception
    {
        private string _Message;

        public DefEx(string message)
        {
            _Message = message;
        }

        public override string ToString()
        {
            return _Message;
        }
    }

    class MatrixFloat
    {
        double[,] mas;

        public MatrixFloat(int n, int m)
        {
            mas = new double[n, m];
            Random r = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = r.Next(3);
                }
            }
        }

        public override string ToString()
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j],5}");
                }
                Console.WriteLine();
            }
            return "";
        }

        public static MatrixFloat operator +(MatrixFloat a, MatrixFloat b)
        {
            if (a.mas.GetLength(0) == b.mas.GetLength(0) && a.mas.GetLength(1) == b.mas.GetLength(1))
            {
                for (int i = 0; i < a.mas.GetLength(0); i++)
                {
                    for (int j = 0; j < a.mas.GetLength(1); j++)
                    {
                        a.mas[i, j] += b.mas[i, j];
                    }
                }
            }
            else { throw new DefEx("\nМатрицы разные!"); }

            return a;
        }

        public static MatrixFloat operator -(MatrixFloat a, MatrixFloat b)
        {
            if (a.mas.GetLength(0) == b.mas.GetLength(0) && a.mas.GetLength(1) == b.mas.GetLength(1))
            {
                for (int i = 0; i < a.mas.GetLength(0); i++)
                {
                    for (int j = 0; j < a.mas.GetLength(1); j++)
                    {
                        a.mas[i, j] -= b.mas[i, j];
                    }
                }
            }
            else { throw new DefEx("\nМатрицы разные!"); }

            return a;
        }

        public static MatrixFloat operator *(MatrixFloat a, MatrixFloat b)
        {
            if (a.mas.GetLength(0) == b.mas.GetLength(0) && a.mas.GetLength(1) == b.mas.GetLength(1))
            {
                for (int i = 0; i < a.mas.GetLength(0); i++)
                {
                    for (int j = 0; j < a.mas.GetLength(1); j++)
                    {
                        double sum = 0;
                        for (int r = 0; r < a.mas.GetLength(1); r++)
                            sum += a.mas[i, r] * b.mas[r, j];
                        a.mas[i, j] = sum;
                    }
                }
            }
            else { throw new DefEx("\nМатрицы разные!"); }

            return a;
        }
        //
    }
}
