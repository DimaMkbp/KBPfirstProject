using System;

namespace snail
{
	class snailClass 
	{
		int[,] snail ;
		int size;
	
		public snailClass(int size)
		{
			this.size = size;
			snail = new int[size,size] ;
		}

		public void Create ()
		{
			int count = 1;
			int temp = 0;
			int i = 0;
			int j = 0;
			int SizeTemp = size;
			while (count <= SizeTemp * SizeTemp)
			{
				for (i = temp; i < size; i++)
					snail[j, i] = count++;
				j=i-1;
				for (i = temp+1; i < size; i++)
					snail[i, j] = count++;
				for (i = size - 2; i >= temp; i--)
					snail[j, i] = count++;
				j=temp;
				for (i = size - 2; i > temp; i--)
					snail[i, j] = count++;
				size--;
				temp++;
				j = temp;
			}
		}
	
		public void Print()
		{
			for (int i = 0; i < snail.GetLength(0); i++)
			{
				for (int j = 0; j < snail.GetLength(1); j++)
					Console.Write("{0,3} ", snail[i, j]);
				Console.WriteLine();
			}
			Console.Read();
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Enter size:");
			int size=int.Parse(Console.ReadLine());
			snailClass snail = new snailClass (size);
			snail.Create ();
			snail.Print ();
		}
	}
}
