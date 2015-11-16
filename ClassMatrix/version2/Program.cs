using System;


namespace version2
{


    


    class mainProgramm
    {
        static void Main(string[] args)
        {
            newArray arr1 = new newArray(3, 3);

            newArray arr2 = new newArray(3);

            arr1.FillArray(-1, 5);
            arr2.FillArray(-1, 5);

            arr1.Show();
            Console.WriteLine();
            arr2.Show();
            Console.WriteLine();

            newArray solution = arr1 + arr2;
            solution.Show();
            Console.WriteLine();
            solution = arr1 - arr2;
            solution.Show();
            Console.WriteLine();
            solution = arr1 * arr2;
            solution.Show();
        }
    }
}
