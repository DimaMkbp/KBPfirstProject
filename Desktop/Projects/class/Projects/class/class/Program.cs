using System;


public class Matrix 
{
	public static bool brake = false;
	int row;
	int column;
	int[,] data; 

	public Matrix(int row, int column)
	{
		this.row = row;
		this.column = column;
		data = new int[row,column];
	}

	public void Create()
	{
		Random rnd = new Random ();
		for (int i = 0; i < row; i++) 
		{ 
			for (int j = 0; j < column; j++) 
			{
				data [i, j] = rnd.Next (1, 10) ;
			}
		}			
	}

	public static Matrix operator +(Matrix first, Matrix second)
	{
		if (first.row != second.row) 
		{
			if (first.column != second.column)
				throw new System.ArgumentException ("matrix sizes don't match!");
		}
		Matrix result = new Matrix (first.row, first.column);
		for (int i = 0; i < first.row; i++) 
		{
			for (int j = 0; j < first.column; j++) 
			{
				result.data [i, j] = first.data [i, j] + second.data [i, j];
			}
		}
		return result;	
	}

	public static Matrix operator -(Matrix first, Matrix second)
	{
		if (first.row != second.row) 
		{
			if (first.column != second.column)
				throw new System.ArgumentException ("matrix sizes don't match!");
		}
		Matrix ResultSub = new Matrix (first.row, first.column);
		for (int i = 0; i < first.row; i++) 
		{
			for (int j = 0; j < first.column; j++) 
			{
				ResultSub.data [i, j] = first.data [i, j] - second.data [i, j];
			}
		}
		return ResultSub;	
	}

	public static Matrix operator *(Matrix first, Matrix second)
	{
		if (first.row != second.column) 
			throw new System.ArgumentException("matrix sizes don't match!");
		Matrix ResultMult = new Matrix(first.row, second.column);  
		for (int i = 0; i < first.row; ++i)
		{
			for (int j = 0; j < second.column; ++j)
			{
				ResultMult.data[i, j] = 0;
				for(int k = 0; k < first.column; ++k)
				{
					ResultMult.data[i, j] += first.data[i, k] * second.data[k, j]; 
				}
			}
		}
		return ResultMult;
	}

	public virtual void Print()
	{
		for (int i = 0; i < row; i++)
		{
			for (int j = 0; j < column; j++) 
			{
				Console.Write (data [i, j] + "\t");
			}
			Console.WriteLine ();
		}
	}
}

class Program
{
	static void Main(string[] args) 
	{ 
		Console.WriteLine ("Enter row!");
		int row = int.Parse (Console.ReadLine ());
		Console.WriteLine ("Enter column!");

		int column = int.Parse (Console.ReadLine ());
		Matrix first = new Matrix (column, row);
		Console.WriteLine ("First:");
		first.Create ();
		first.Print ();

		Console.WriteLine ("Enter row!");
		int row2 = int.Parse (Console.ReadLine ());
		Console.WriteLine ("Enter column!");
		int column2 = int.Parse (Console.ReadLine ());
		Console.WriteLine ("Second:");
		Matrix second = new Matrix (column2, row2);
		second.Create ();
		second.Print ();

		do
		{
			Console.WriteLine ("Choose action:\n" +
				"1 - Addition\n" +
				"2 - Subtraction\n" +
				"3 - Multiplication\n" +
				"4 - Exit");
			switch (Convert.ToInt32 (Console.ReadLine ())) 
			{
			case 1:
				{
				Console.WriteLine ();
				Console.WriteLine ("Addition:");
				Matrix Addition = first + second;
				Addition.Print ();
				break;
				}
			case 2:
				{
				Console.WriteLine ();
				Console.WriteLine ("Subtraction:");
				Matrix Subtraction = first - second;
				Subtraction.Print ();
				break;
				}
			case 3:
				{
				Console.WriteLine ();
				Console.WriteLine ("Multiplication:");
				Matrix Mult = first * second;
				Mult.Print ();
				break;
				}	
			case 4:
				{
				Matrix.brake=true;
				break;
				}
			default:
			Console.WriteLine ("Error!");
			break;
			}
		}
		while(!Matrix.brake);
	}
}
