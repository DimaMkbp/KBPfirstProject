using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Massive
    {
        public int  n;
        public int[,] mas;
       

        public Massive(int n)
        {
            this.n = 4;
           
            mas = new int[n, n]; 
           
        }

        public void FirstMassiveCreate()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(1, 10);
                   
                }
            }
        }

        public void SecondMassiveCreate()
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = r.Next(1, 9);

                }
            }
        }
        public virtual void PrintMassive()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j]+" " );
                }
               
            }
        }
        public static Massive operator +(Massive first, Massive second)
        {
            Massive addMas = new Massive(first.n);
            for (int i = 0; i < first.n; i++)
            {
                for (int j = 0; j < first.n; j++)
                {
                    addMas.mas[i, j] = first.mas[i, j] + second.mas[i, j];
                }
            }
            return addMas;
        }

        public static Massive operator -(Massive first, Massive second)
        {
            Massive subMas = new Massive(first.n);
            for (int i = 0; i < first.n; i++)
            {
                for (int j = 0; j < first.n; j++)
                {
                    subMas.mas[i, j] = first.mas[i, j] - second.mas[i, j];
                }
            }
            return subMas;
        }

        public static Massive operator *(Massive first, Massive second)
        {
            Massive multMas = new Massive(first.n);
            for (int i = 0; i < first.n; i++)
            {
                for (int j = 0; j < first.n; j++)
                {
                    multMas.mas[i, j] = 0;
                    for (int k = 0; k < first.n; k++)
                    {
                        multMas.mas[i, j]+=first.mas[k, j] * second.mas[i, k];
                    }
                }
            }
            return multMas;
        }


    }


    class Program
    {
        static void Main(string[] args)
        { 
            int n = 4;
            
            Massive first = new Massive(n);
            first.FirstMassiveCreate();
            first.PrintMassive();
            Console.WriteLine();
            Massive second = new Massive(n);
            second.SecondMassiveCreate();
            second.PrintMassive();
            Console.WriteLine();
            Massive addMas = first + second;
            addMas.PrintMassive();
            Console.WriteLine();
            Massive subMas = first - second;
            subMas.PrintMassive();
            Console.WriteLine();

            Massive multMas = first * second;
            multMas.PrintMassive();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
    
}
