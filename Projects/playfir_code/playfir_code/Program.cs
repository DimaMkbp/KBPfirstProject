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
		string key = "каниулыбвгдежзймопрстфхцчшщъьэюя";  
		string cipherText = Playfair.Encipher(key, plainText);
		Console.WriteLine(cipherText);
		plainText = Playfair.Decipher(key, cipherText);
		Console.WriteLine(plainText);
		Console.WriteLine();
//		originalText = "Hide the gold in the tree stump.";
//		Console.WriteLine(originalText);         
//		plainText = Playfair.Prepare(originalText);
//		Console.WriteLine(plainText);
//		key = "playfirexmbcdghjknostuvwz";     
//		cipherText = Playfair.Encipher(key, plainText);
//		Console.WriteLine(cipherText);
//		plainText = Playfair.Decipher(key, cipherText);
//		Console.WriteLine(plainText);
//		Console.ReadLine(); 
	}
}

public class Playfair
{

	/*
        'Prepare' removes all characters that are not letters i.e. all numbers, punctuation,
        spaces etc. are removed (uppercase is also converted to lowercase).

        If the seond letter of a pair is the same as the first letter, an 'x' is inserted.

        Also, if the length of the string is odd, an 'x' is appended to make it an even length
        as Playfair can only encrypt even length strings.

        If you want numbers, punctuation etc. you must spell it out e.g.
        'stop' for period, 'one', 'two' etc.
    */

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

		// If the string is an odd length, append an 'x'
		if (sb.Length % 2 == 1)
		{
			sb.Append('х');
		}

		return sb.ToString();     
	}

	/*
        'Encipher' uses the Playfair cipher to encipher some text.
        The key is a string containing all 26 letters in the alphabet, except one'.
    */
	public static string Encipher(string key, string plainText)
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
			b_ind = key.IndexOf(b);
			a_row = a_ind / 8;
			b_row = b_ind / 8;
			a_col = a_ind % 8;
			b_col = b_ind % 8;

			if(a_row == b_row)
			{
				if(a_col == 7)
				{
					sb.Append(key[a_ind - 7]);
					sb.Append(key[b_ind + 1]);
				}
				else if(b_col ==7)
				{
					sb.Append(key[a_ind + 1]);
					sb.Append(key[b_ind - 7]);
				} 
				else
				{
					sb.Append(key[a_ind + 1]);
					sb.Append(key[b_ind + 1]);
				}
			}
			else if(a_col == b_col)
			{
				if(a_row == 3)
				{
					sb.Append(key[a_ind - 24]);
					sb.Append(key[b_ind + 8]);
				}
				else if(b_row ==3)
				{
					sb.Append(key[a_ind + 8]);
					sb.Append(key[b_ind - 24]);
				}
				else
				{
					sb.Append(key[a_ind + 8]);
					sb.Append(key[b_ind + 8]);
				}
			}
			else
			{
				sb.Append(key[8*a_row + b_col]);
				sb.Append(key[8*b_row + a_col]);
			}       
		}
		return sb.ToString();
	}


	/*
        'Decipher' uses the Playfair cipher to decipher some text.
        The key is a string containing all 26 letters of the alphabet, except one.
    */
	public static string Decipher(string key, string cipherText)
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
			b_ind = key.IndexOf(b);
			a_row = a_ind / 8;
			b_row = b_ind / 8;
			a_col = a_ind % 8;
			b_col = b_ind % 8;


			if(a_row == b_row)
			{
				if(a_col == 0)
				{
					sb.Append(key[a_ind + 7]);
					sb.Append(key[b_ind - 1]);
				}
				else if(b_col == 0)
				{
					sb.Append(key[a_ind - 1]);
					sb.Append(key[b_ind + 7]);
				} 
				else
				{
					sb.Append(key[a_ind - 1]);
					sb.Append(key[b_ind - 1]);
				}
			}
			else if(a_col == b_col)
			{
				if(a_row == 0)
				{
					sb.Append(key[a_ind + 24]);
					sb.Append(key[b_ind - 8]);
				}
				else if(b_row == 0)
				{
					sb.Append(key[a_ind - 8]);
					sb.Append(key[b_ind + 24]);
				}
				else
				{
					sb.Append(key[a_ind - 8]);
					sb.Append(key[b_ind - 8]);
				}
			}
			else
			{
				sb.Append(key[8*a_row + b_col]);
				sb.Append(key[8*b_row + a_col]);
			}       
		}
		return sb.ToString();
	}
}



