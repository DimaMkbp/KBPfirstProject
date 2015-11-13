using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace lr7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			String [] array = new string[8];

			using (StreamReader reader = new StreamReader("Users/gusejn/Projects/lr7/Shoppinglist.txt", Encoding.Default))
			{
				for (int i = 0; i < 8; i++)
				{
					array[i] =  reader.ReadLine();
					Console.WriteLine (array [i]);
				}
			}

		}
	}
}
