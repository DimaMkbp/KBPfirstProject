using System;

namespace cxcv
{
	class MainClass
	{
		
			public static void Main()
			{
			int r; 
			int x, y, z; 
			Console.WriteLine ("Enter R: ");

			r = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Enter X: ");

			x = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Enter Y: ");

			y = Convert.ToInt32 (Console.ReadLine ());

			z = x + r; 
			int u = y - r; 
			if (z <= r) { 
				if (u <= r) {
					Console.WriteLine (" point is located inside the circle");	
				}
			}
			else 
				Console.WriteLine (" point isn't located inside the circle");	
				
			if (0 <= x) { 
				if (2 * r >= x) {
					if (-r <= y) {
						if (y <= 0) {

							Console.WriteLine (" point is located inside the square");
						}
						else 	
							Console.WriteLine (" point isn't located inside the square");
					}
					else 	
						Console.WriteLine (" point isn't located inside the square");
				}


				else 	
					Console.WriteLine (" point isn't located inside the square");
		
			}
			else 	
					Console.WriteLine (" point isn't located inside the square");			
					
					
				}
			}

				}
				

		
//	}


