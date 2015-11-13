using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MagicQuad
{    class Program
	{        static void Main(string[] args)
		{ string _randomLine = "ЙЦУКЕНГШЩЗХФЪЫВАПРОЛДЖЭЧСМИТЬБЮ";
			Random _rand = new Random();
			Console.WriteLine("Введите сообщение:");
			String _line = Console.ReadLine().ToUpper().Replace(" ", "");
			int _d = (int)Math.Ceiling(Math.Sqrt(_line.Length));
			if (_d % 2 != 1)
				_d++;
			Console.WriteLine("Магический квадрат: " +  "\n");
			int[,] _quad = {
			{9,16,2,7},
			{6,3,13,12},
				{15,10,8,1}
			};
				
			for(int i=0; i < 3; i++) {
				for(int j=0; j < 4; j++)
					Console.Write(_quad[i,j] + "\t");
				Console.WriteLine();
			}               
				Console.WriteLine();            
			Console.WriteLine("Шифрование сообщения:");
			string _cryptedString = "";
			for (int j = 0; j < 4; j++)
			{ for (int i = 0; i < 3; i++)

				{ if ((_quad[i, j] - 1) < _line.Length)
					{ Console.Write(_line[_quad[i, j] - 1] + "\t");
						_cryptedString += _line[_quad[i, j] - 1];                    }
				else
				{ char _randomChar = _randomLine[_rand.Next(0, _randomLine.Length - 1)];
					Console.Write(_randomChar + "\t");
					_cryptedString += _randomChar;                    }                }
				Console.WriteLine();            }
			Console.WriteLine("\nЗашифрованная строка:");
			Console.WriteLine(_cryptedString);
			Console.ReadKey();     
		}    
	}  
}