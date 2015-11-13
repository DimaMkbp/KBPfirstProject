using System;

namespace First_on_the_mac
{
	class MainClass
	{
		public static void Main ()
		{
			int R;
			double x, y;
			string q; 
			q = Convert.ToString
				(Console.ReadLine ());
			switch (q) {
			case "one":
				
				break;
			case "two": 
				EmptyClass.Empty ();
				break;
			}

			x = Convert.ToDouble(Console.ReadLine ());
			if (x>=-7 && -3>=x) {
				y = x * 0 + 3; 	
				Console.WriteLine (" y = " + y);
			
			}
			if (x >=-2 && 3>=x) {
				R = Convert.ToInt32(Console.ReadLine ());	
				y =-(R*R  -x*x / 2);
				Console.WriteLine (" y = " + y);
				
			
		

			} 
		if (x >=4 && 6>=x) {
				y = -2 * x + 9;	
				Console.WriteLine (" y = " + y);
			}

	

		

				}
			}


			

		}
	

