using System;
using System.Text;

class Test
{
	static void Main()
	{
		string originalText = "Оптимист – это человек, который еще не читал утренних газет.";
		Console.WriteLine(originalText);         
		string plainText = Playfair.Prepare(originalText);
		Console.WriteLine(plainText);
		string key = "йцукенгшщзхъфывапролджэячсмитьбю";  
		string key2 = "ъхзщшгнекуцйэждлорпавыфюбьтимсчя"; 
		string cipherText = Playfair.Encipher(key,key2, plainText);
		Console.WriteLine(cipherText);
		plainText = Playfair.Decipher(key,key2, cipherText);
		Console.WriteLine(plainText);
		Console.WriteLine();

	}
}

public class Playfair
{


	public static string Prepare(string originalText)
	{
		int length = originalText.Length;
		originalText = originalText.ToLower();
		StringBuilder sb = new StringBuilder();

		for(int i = 0; i < length; i++)
		{
			char c = originalText[i];
			if (c >= 1072 && c <= 1103)
			{

				if (sb.Length % 2 == 1 && sb[sb.Length - 1] == c)
				{                                 
					sb.Append('x');
				}
				sb.Append(c);
			}
		}

	
		if (sb.Length % 2 == 1)
		{
			sb.Append('х');
		}

		return sb.ToString();     
	}


	public static string Encipher(string key, string key2, string plainText)
	{
		int length = plainText.Length; 
		char a,b;   
		int a_ind, b_ind, a_row, b_row, a_col, b_col;   
		StringBuilder sb = new StringBuilder();

		for(int i = 0; i < length; i+=2)
		{
			a = plainText[i];
			b = plainText[i+1];

			a_ind = key.IndexOf(a);
			b_ind = key2.IndexOf(b);
			a_row = a_ind / 8;
			b_row = b_ind / 8;
			a_col = a_ind % 8;
			b_col = b_ind % 8;

			if(a_row == b_row)
			{
				if(a_col == 7)
				{
					sb.Append(key[a_ind - 7]);
					sb.Append(key2[b_ind + 1]);
				}
				else if(b_col ==7)
				{
					sb.Append(key[a_ind + 1]);
					sb.Append(key2[b_ind - 7]);
				} 
				else
				{
					sb.Append(key[a_ind + 1]);
					sb.Append(key2[b_ind + 1]);
				}
			}
			else if(a_col == b_col)
			{
				if(a_row == 3)
				{
					sb.Append(key[a_ind - 24]);
					sb.Append(key2[b_ind + 8]);
				}
				else if(b_row ==3)
				{
					sb.Append(key[a_ind + 8]);
					sb.Append(key2[b_ind - 24]);
				}
				else
				{
					sb.Append(key[a_ind + 8]);
					sb.Append(key2[b_ind + 8]);
				}
			}
			else
			{
				sb.Append(key[8*a_row + b_col]);
				sb.Append(key2[8*b_row + a_col]);
			}       
		}
		return sb.ToString();
	}



	public static string Decipher(string key,string key2, string cipherText)
	{
		int length = cipherText.Length; 
		char a,b;   
		int a_ind, b_ind, a_row, b_row, a_col, b_col;   
		StringBuilder sb = new StringBuilder();

		for(int i = 0; i < length; i+=2)
		{
			a = cipherText[i];
			b = cipherText[i+1];

			a_ind = key.IndexOf(a);
			b_ind = key2.IndexOf(b);
			a_row = a_ind / 8;
			b_row = b_ind / 8;
			a_col = a_ind % 8;
			b_col = b_ind % 8;


			if(a_row == b_row)
			{
				if(a_col == 0)
				{
					sb.Append(key[a_ind + 7]);
					sb.Append(key2[b_ind - 1]);
				}
				else if(b_col == 0)
				{
					sb.Append(key[a_ind - 1]);
					sb.Append(key2[b_ind + 7]);
				} 
				else
				{
					sb.Append(key[a_ind - 1]);
					sb.Append(key2[b_ind - 1]);
				}
			}
			else if(a_col == b_col)
			{
				if(a_row == 0)
				{
					sb.Append(key[a_ind + 24]);
					sb.Append(key2[b_ind - 8]);
				}
				else if(b_row == 0)
				{
					sb.Append(key[a_ind - 8]);
					sb.Append(key2[b_ind + 24]);
				}
				else
				{
					sb.Append(key[a_ind - 8]);
					sb.Append(key2[b_ind - 8]);
				}
			}
			else
			{
				sb.Append(key[8*a_row + b_col]);
				sb.Append(key2[8*b_row + a_col]);
			}       
		}
		return sb.ToString();
	}
}



