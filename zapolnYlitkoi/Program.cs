using System;
using MyLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zapolnYlitkoi
{
    class Program
    {
        public void create(int[,] mass)
        {
            int i = 0;
            int j = -1;
            int numRow = mass.GetLength(0);
            int numCol = mass.GetLength(1);
            Random rnd = new Random();
         
        
            int x = mass.GetLength(0) * mass.GetLength(1);
            int check = 0;
            do
            {
                for (j = j + 1; j < numRow; j++)
                {
                    mass[i, j] = rnd.Next(1, 10);
                    check++;
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }
                
                j--;
                for (i = i+1; i < numCol; i++)
                {
                    check++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }

                i--;
                numCol--;

                for (j = j - 1; j > mass.GetLength(0) - numRow; j--)
                {
                    check++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }

                numRow--;

                for (i = i; i > mass.GetLength(1)-numCol-1; i--)
                {
                    check++;
                    mass[i, j] = rnd.Next(1, 10);
                    Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
                    Console.ReadLine();
                }

                i++;
                
            } while (check != x);
            
            
        }
        static void Main(string[] args)
        {
            int [,] mass = new int[5,5];
            Program t = new Program();
            t.create(mass);
       
            Class1.WriteDoubleMass(mass.GetLength(0), mass.GetLength(1), mass);
            Console.ReadLine();
        }
    }
}
