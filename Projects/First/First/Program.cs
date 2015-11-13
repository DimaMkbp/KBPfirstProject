using System;

namespace First
{
	class MainClass
	{
		public static void Main ()
		{
			Console.WriteLine ("Введите число a !");
			double a, b;
			a = Convert.ToDouble (Console.ReadLine ());


			Console.WriteLine ("Введите число b !");

			b = Convert.ToDouble (Console.ReadLine ());
			double z1, z2; 
			z1 = (Math.Sin (a) + Math.Cos (2 * b - a)) / (Math.Cos (a) - Math.Sin (2 * b - a));
			Console.WriteLine (z1);
			z2 = (1 + Math.Sin (2 * b)) / Math.Cos (2 * b);
			Console.WriteLine (z2);
			if (z1 == z2) {
				Console.WriteLine ("z1 и z2 равны");

			} else
				Console.WriteLine ("z1 и z2 не равны");
			
			{
			
			}
	
		}
	}
}
