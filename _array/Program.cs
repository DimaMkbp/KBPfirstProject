using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _array
{
    class Program
    {
        static void Main(string[] args)
        {
            arrays matrix1 = new arrays(0, 0);
            arrays matrix2 = new arrays(0, 0);
            arrays matrix3 = new arrays(0, 0);
            int x;
            do
            {
                Console.WriteLine("1- Creat arrays");
                Console.WriteLine("2- Print arrays");
                Console.WriteLine("3- + arrays");
                Console.WriteLine("4- - arrays");
                Console.WriteLine("5- * arrays");
                Console.WriteLine("6- / arrays");
                Console.WriteLine("7 - ^ arrays");
                x = Convert.ToInt16(Console.ReadLine());
                switch (x)
                {
                    case 1://создание и добовление массива
                        {
                            Console.WriteLine("First array");
                            Console.WriteLine("Row:");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Col:");
                            int m = Convert.ToInt32(Console.ReadLine());
                            matrix1 = new arrays(n, m);
                            matrix1.create();
                            Console.WriteLine("Second array");
                            Console.WriteLine("Row:");
                            n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Col:");
                            m = Convert.ToInt32(Console.ReadLine());
                            matrix2 = new arrays(n, m);
                            matrix3 = new arrays(m,n);
                            matrix2.create();
                            break;
                        }
                    case 2://вывод массива
                        {
                            Console.WriteLine(matrix1.print());
                            Console.WriteLine();
                            Console.WriteLine(matrix2.print());
                            Console.WriteLine();
                            Console.WriteLine(matrix3.print());
                            Console.ReadLine();
                            break;
                        }
                    case 3://сложение массивов
                        {   
                            matrix3 = matrix1 + matrix2;
                            break;
                        }
                    case 4://вычитание массивов
                        {
                            matrix3 = matrix1 - matrix2;
                            break;
                        }
                    case 5://умножение массивов
                        {
                            matrix3 = matrix1 * matrix2;
                            break;
                        }
                    case 6:
                        {
                            matrix3 = matrix1 / matrix2;
                            break;
                        }
                    case 7:
                        {
                            int n = Convert.ToInt32(Console.ReadLine());
                            matrix3 = matrix1.exponent(matrix1, n); 
                            break;
                        }
                }
                Console.Clear();
            } while (x != 0);
        }
    }
}
