using System;

namespace First_on_the_mac
{
	public class EmptyClass
	{
		public static void Empty ()
		{int[] nums = new int[19];
			int r = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine (" таблица значений функции");
			for( int i = 0 ; i!=5 ; i++){
				int b = nums [i] *0 +3; 
				Console.WriteLine ("      x = " + nums [i] + "  y = " + b);

		}

			for (int i = 5; i != 7; i++) {
				int b = (r * r - nums [i] * nums [i]) / 2; 
				Console.WriteLine ("      x = " + nums [i] + "  y = " + b);
			}
			for (int i = 7; i != 11; i++) {
				int b = (r * r - nums [i] * nums [i]) / 2; 
				Console.WriteLine ("      x =  " + nums [i] + "  y = " + b);
			}
			for (int i = 11; i != 14; i++) {
				int b = -2 * nums [i] + 9;  
			
				Console.WriteLine ("      x =  " + nums [i] + "  y = " + b);
			}
			for (int i = 14; i != 17; i++) {
				int b =  nums [i] - 9;  

				Console.WriteLine ("      x =  " + nums [i] + "  y = " + b);
			}
			for (int i = 17; i != 19; i++) {
				int b =  nums [i] - 9;  

				Console.WriteLine ("      x =  " + nums [i] + " y = " + b);
			}
	}
}
}
