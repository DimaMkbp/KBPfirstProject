using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version2
{
    class newArray
    {
        int[,] arr;
        int rows, columns;
        Random rnd = new Random();
        public newArray()
        {
            rows = 1;
            columns = 1;

            arr = new int[rows, columns];
        }
        public newArray(int aRows_Columns)
        {
            rows = Math.Abs(aRows_Columns);
            columns = Math.Abs(aRows_Columns);

            arr = new int[rows, columns];
        }
        public newArray(int aRows, int aColumns)
        {
            rows = Math.Abs(aRows);
            columns = Math.Abs(aColumns);

            arr = new int[rows, columns];
        }

        public void FillArray(int minV, int maxV)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = rnd.Next(minV, maxV);
                }
            }
        }
        public virtual void Show()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void CheckSizes(newArray aFirstArr, newArray aSecondArr)
        {
            try
            {
                if ((aFirstArr.rows != aSecondArr.rows) | (aFirstArr.columns != aSecondArr.columns))
                {
                    throw new sizeExeption("массивы не одинаковы по размерам");
                }
            }
            catch (sizeExeption)
            {
                throw;
            }
        }

        public static newArray operator +(newArray aFirstArr, newArray aSecondArr)
        {
            try
            {
                CheckSizes(aFirstArr, aSecondArr);

                newArray temp = new newArray(aFirstArr.rows, aFirstArr.columns);

                for (int i = 0; i < aFirstArr.rows; i++)
                {
                    for (int j = 0; j < aFirstArr.columns; j++)
                    {
                        temp.arr[i, j] = aFirstArr.arr[i, j] + aSecondArr.arr[i, j];
                    }
                }
                return temp;
            }

            catch (sizeExeption exn)
            {
                Console.WriteLine(exn.Message);
                Console.WriteLine("будет сгенерирована нулевая матрица");
                return new newArray(aFirstArr.rows, aSecondArr.columns);
            }

        }

        public static newArray operator -(newArray aFirstArr, newArray aSecondArr)
        {
            try
            {
                CheckSizes(aFirstArr, aSecondArr);

                newArray temp = new newArray(aFirstArr.rows, aFirstArr.columns);

                for (int i = 0; i < aFirstArr.rows; i++)
                {
                    for (int j = 0; j < aFirstArr.columns; j++)
                    {
                        temp.arr[i, j] = aFirstArr.arr[i, j] - aSecondArr.arr[i, j];
                    }
                }
                return temp;
            }

            catch (sizeExeption exn)
            {
                Console.WriteLine(exn.Message);
                Console.WriteLine("будет сгенерирована нулевая матрица");
                return new newArray(aFirstArr.rows, aSecondArr.columns);
            }

        }

        static int Continue_Multiply(int aI, int aJ, newArray aFirstArr, newArray aSecondArr)
        {
            int result = 0;
            for (int i = 0; i < aFirstArr.rows; i++)
            {
                result += aFirstArr.arr[aI, i] * aSecondArr.arr[i, aJ];
            }
            return result;
        }
        public static newArray operator *(newArray aFirstArr, newArray aSecondArr)
        {
            try
            {
                CheckSizes(aFirstArr, aSecondArr);

                newArray temp = new newArray(aFirstArr.rows, aFirstArr.columns);

                for (int i = 0; i < aFirstArr.rows; i++)
                {
                    for (int j = 0; j < aFirstArr.columns; j++)
                    {
                        temp.arr[i, j] = Continue_Multiply(i, j, aFirstArr, aSecondArr);
                    }
                }
                return temp;
            }

            catch (sizeExeption exn)
            {
                Console.WriteLine(exn.Message);
                Console.WriteLine("будет сгенерирована нулевая матрица");
                return new newArray(aFirstArr.rows, aSecondArr.columns);
            }

        }
    }
}
