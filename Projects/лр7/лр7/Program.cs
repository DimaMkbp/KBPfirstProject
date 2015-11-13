using System;
using System.IO;
namespace лр7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (" enter row");
			int row = Convert.ToInt32(Console.ReadLine ());
			Console.WriteLine (" enter col");
			int col = Convert.ToInt32(Console.ReadLine ());
			string[,] arr = new string[row, col];
			for (int i = 0; i != row; i++) {
				for (int j = 0; j != col; i++) {
					Console.WriteLine(arr[i,j]);


						
				}

			}
	}

	}
}
