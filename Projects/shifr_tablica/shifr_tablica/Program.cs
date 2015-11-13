using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("¬ведите ключ");
			string key = Convert.ToString(Console.ReadLine());
			Console.WriteLine("¬ведите строку");
			string str = Convert.ToString(Console.ReadLine());
			int keyInt = key.Length;

			char[] kArr = new char[keyInt];
			char[] kArrSort = new char[keyInt];

			str =str.Replace(" ", "_");

			for (int s = 0; s < keyInt; s++)
			{
				if (str.Length % keyInt != 0)
				{
					str=str.Insert(str.Length, "_");
				}
			}

			int StrJ = (str.Length) / keyInt;

			char[,] sArr = new char[StrJ,keyInt];
			char[,] sArrSort = new char[StrJ, keyInt];

			for (int i=0; i<keyInt; i++)
			{
				kArr[i] = key[i];
				kArrSort[i] = key[i];
			}
			int kk = 0;
			for (int i = 0; i < StrJ; i++)
			{
				for (int j=0; j<keyInt;j++)
				{
					sArr[i, j] = str[kk];
					kk++;
				}
			}


			Console.WriteLine();
			for (int i = 0; i < keyInt; i++)
			{
				Console.Write(kArr[i] + " ");
			}
			Console.WriteLine();

			for (int i = 0; i < StrJ; i++)
			{
				for (int j = 0; j < keyInt; j++)
				{
					Console.Write(sArr[i, j] + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine();



			for (int i = 0; i < keyInt; i++)
			{
				for (int j = 0; j < keyInt - 1; j++)
				{
					if (kArrSort[j] > kArrSort[j + 1])
					{
						char temp = kArrSort[j];
						kArrSort[j] = kArrSort[j + 1];
						kArrSort[j + 1] = temp;
					}
				}
			}

			for (int i = 0; i < keyInt; i++)
			{
				for (int j = 0; j < keyInt ; j++)
				{
					if (kArrSort[i] == kArr[j])
					{
						for (int ii=0; ii < StrJ; ii++)
						{
							sArrSort[ii, i] = sArr[ii, j];
						}
					}
				}
			}


			//for (int i = 0; i < keyInt; i++)
			//{
			//    for (int j = 0; j < keyInt - 1; j++)
			//    {
			//        if (kArr[j] > kArr[j + 1])
			//        {
			//            char temp = kArr[j];
			//            kArr[j] = kArr[j + 1];
			//            kArr[j + 1] = temp;
			//        }
			//        for (int ii = 0; ii < StrJ; ii++)
			//        {
			//            char temp1 = sArr[ii, j];
			//            sArr[ii, j] = sArr[ii, j + 1];
			//            sArr[ii, j + 1] = temp1;
			//        }
			//    }
			//}

			for (int i = 0; i < keyInt; i++)
			{
				Console.Write(kArrSort[i]+" ");
			}

			Console.WriteLine();

			for (int i = 0; i < StrJ; i++)
			{
				for (int j = 0; j < keyInt; j++)
				{
					Console.Write(sArrSort[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			string strKod = "";

			for (int i = 0; i < StrJ; i++)
			{
				for (int j = 0; j < keyInt; j++)
				{
					string tempstr = Convert.ToString(sArrSort[i, j]);
					strKod = strKod.Insert(strKod.Length,tempstr);

				}
			}

			Console.Write(strKod);

			Console.ReadKey();
		}
	}
}
