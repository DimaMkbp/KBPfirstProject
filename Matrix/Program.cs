using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixFloat mas = new MatrixFloat(5, 5);
            MatrixFloat b = new MatrixFloat(5, 5);
            
            mas.ToString();
            Console.WriteLine();
            b.ToString();

            try
            {
                mas *= b;
                Console.WriteLine();
                mas.ToString();
            }
            catch (DefEx ex) { Console.WriteLine(ex); }
            
            Console.ReadLine();
        }
    }
}
