using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MagicQuad
{    class Program
	{        static void Main(string[] args)
		{ string randomLine = "АБВГДЕЁЖЗИКЛМНОПРСТУФХЦШЩЪЫЬЭЮЯ";
			Random rand = new Random();
			Console.WriteLine("Введите сообщение:");
			String line = Console.ReadLine().ToUpper().Replace(" ", "");

			Console.WriteLine("Магический квадрат: " +  "\n");
			int[,] quad = {
				{9,16,2,7},
				{6,3,13,12},
				{15,10,8,1},
				{4,5,11,14}

			};

			for(int i=0; i < 4; i++) {
				for(int j=0; j < 4; j++)
					Console.Write(quad[i,j] + "\t");
				Console.WriteLine();
			}               
			Console.WriteLine();                     
		Console.WriteLine ("Шифрование сообщения:");
		string _cryptedString = "";
		for (int j = 0; j < 4; j++)
		{ for (int i = 0; i < 4; i++)
			{ if ((quad[j, i] - 1) < line.Length)
				{ Console.Write(line[quad[j, i] - 1] + "\t");
					_cryptedString += line[quad[j, i] - 1];                    }
			else
			{ char _randomChar = randomLine[rand.Next(0, randomLine.Length - 1)];
				Console.Write(_randomChar + "\t");
				_cryptedString += _randomChar;                    }                }
			Console.WriteLine();            }
		Console.WriteLine("\nЗашифрованная строка:");
		Console.WriteLine(_cryptedString);

		Console.ReadKey();        }    }    }


