using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
	class Program
	{
		private static int smesh = 'а';
		private static int alphLength = 32;

		public static string Encrypt(string text, string keyWord)
		{
			StringBuilder ans = new StringBuilder();
			for (int i = 0; i < text.Length; i++)
			{
				int num = (text[i] + keyWord[i % keyWord.Length] - 2 * smesh) % alphLength;
				char c = (char)(num + smesh);
				ans.Append(c);
			}
			return ans.ToString();
		}

		public static string Decrypt(string shifr, string keyWord)
		{
			StringBuilder ans = new StringBuilder();
			for (int i = 0; i < shifr.Length; i++)
			{
				int num = (shifr[i] - keyWord[i % keyWord.Length] + alphLength) % alphLength;
				char c = (char)(num + smesh);
				ans.Append(c);
			}
			return ans.ToString();
		}

		static void Main(string[] args)
		{
					Console.WriteLine("0-Зашифровка\n1-Расшифровка");
			string choose = Console.ReadLine();
			Console.WriteLine(" Ключ: ");
			string key = Console.ReadLine();
			if (choose.Equals("0"))
			{
				Console.WriteLine("Фраза:");
				string text = Console.ReadLine();
				Console.WriteLine (Encrypt (text, key), Encoding.GetEncoding (1251));
				File.WriteAllText("code.txt", Encrypt(text, key), Encoding.GetEncoding(1251));
			}
			else
			{
				Console.WriteLine("Фраза: ");
				string code = Console.ReadLine();
				Console.WriteLine (Decrypt (code, key), Encoding.GetEncoding (1251));
				File.WriteAllText("text.txt", Decrypt(code, key), Encoding.GetEncoding(1251));
			}
		}

	}
}
