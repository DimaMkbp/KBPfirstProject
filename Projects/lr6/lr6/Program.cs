using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
namespace lr6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] table = new int[8, 8];
			List<int> matchKNumbers = new List<int>();
			int n = 8;
			Random v = new Random ();
			for (int i = 0; i != 8; i++) {

				for (int j = 0; j != 8; j++) {

					table [i, j] = v.Next (-1, 0);

					Console.Write ("{0}\t",  table[i, j]);
				}
				Console.WriteLine ();
			}

			Console.WriteLine ();
			Console.WriteLine ();
			bool match = true; 
			for ( int i = 0 ; i!= 8; i++)
			{
				for (int j = 0 ; j!= 8 ; j++)
					if (table [i,j]!=table[j,i])
						match = false;
			if (match)
				matchKNumbers.Add(i);
		}
		foreach(int number in matchKNumbers)
			Console.WriteLine("k = {0}", number);
				
						
			bool negative = false ;
			for (int i = 0; i != 8; i++) { 
		
				for (int j = 0; j != 8; j++)
					if (table [i, j] < 0)
						negative = true;
				if (negative) {
					int sum = 0;
					for (int j = 0; j != 8; j++)
						sum += table [i, j];
					Console.WriteLine ("Сумма строки {0} равна {1}", i, sum);

				}
			}

				Console.WriteLine ();

	
			}

		}

	}

