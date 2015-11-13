using System;

namespace lr3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double x1,x2,x3; 
			double e = 0.00001;
			Console.WriteLine ("x  начальное ");
			x1 = Convert.ToDouble (Console.ReadLine ());
			Console.WriteLine ("x  конечное ");
			x2 = Convert.ToDouble (Console.ReadLine ());
			Console.WriteLine ("step ");
			x3 = Convert.ToDouble (Console.ReadLine ());
			Console.WriteLine ("x\ty\tarcctg(x)");
			for (double i = x1; i != x2; i += x3) {
				double ii =   1/Math.Atan(i);
			/*	double h = 0;
				double sum = 0;
				int p = 1; 
				double e1 = i;
				while (e1 > e) {
					if (i % 2 != 0) {

						e1 = (Math.PI / 2) - (Math.Pow ((-1), p + 1) * Math.Pow (i, 2 * p + 1)) / 2 * p + 1;
						sum += e1;
						p += 2;

					}  else {
						e1 = (Math.PI / 2) + (Math.Pow ((-1), p + 1) * Math.Pow (i, 2 * p + 1)) / 2 * p + 1;
						sum += e1;
						p += 2;		

					}

				}*/

				Console.WriteLine ("{0}\t{1}", i,ii);

			}

		}
	}
}
