using System;

namespace cxcv
{
	class MainClass
	{
		
			public static void Main()
			{
			double r; 
			double x, y, z; 
			for (int i = 1; i != 10; i++) {
				Console.WriteLine ("Enter R: ");



				r = Convert.ToDouble (Console.ReadLine ());
				Console.WriteLine ("Enter X: ");

				x = Convert.ToDouble(Console.ReadLine ());
				Console.WriteLine ("Enter Y: ");

				y = Convert.ToDouble(Console.ReadLine ());
			
				z = x + r; 
				double u = y - r; 
				if (z <= r) { 
					if (u <= r) {
						Console.WriteLine (" point is located inside the circle");	
					}
				} else
					Console.WriteLine (" point isn't located inside the circle");	
				
				if (0 <= x) { 
					if (2 * r >= x) {
						if (-r <= y) {
							if (y <= 0) {

								Console.WriteLine (" point is located inside the square");
							} else
								Console.WriteLine (" point isn't located inside the square");
						} else
							Console.WriteLine (" point isn't located inside the square");
					} else
						Console.WriteLine (" point isn't located inside the square");
		
				} else
					Console.WriteLine (" point isn't located inside the square");			
					
			}	
				}
			}

				}
				

		



