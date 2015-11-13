using System;

namespace lr5
{
	class MainClass
	{
		public static void Main (string[] args)
		{int[] table = new int[]{0,1,2,3,4,5,0,3,4};
			for (int i = 0; i!=8; i++) {


					Console.Write ("{0}\t",  table[i]);

				}
			int max = table[0];
			int maxi = 0;
			for (int i = 0; i!=8; i++) {
				if (table [i] > table[maxi]) {
					maxi = i;
				}
				if (i % 2 != 0) {
					Console.Write (table [i]+" ");
				}
			}
			Console.WriteLine ();
			Console.WriteLine("индекс максимального элемента : {0}", maxi);
			int startIndex = Array.IndexOf(table, 0) + 1;
			int endIndex = Array.IndexOf(table, 0, startIndex);
			int result = 1;
			for (int i = startIndex; i < endIndex; ++i)
				result *= table[i];
			Console.WriteLine("произведение элементов массива между нулями " + result);
		

					
				

		
			
		}
	}
}
