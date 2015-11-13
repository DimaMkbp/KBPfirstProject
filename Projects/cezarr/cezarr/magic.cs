using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MagicQuad
{    class Program
	{        static void Main(string[] args)
		{ string randomLine = "ЙЦУКЕНГШЩЗХФЪЫВАПРОЛДЖЭЧСМИТЬБЮ";
			Random rand = new Random();
			Console.WriteLine("Введите сообщение:");
			String line = Console.ReadLine().ToUpper().Replace(" ", "");
				Console.WriteLine("Магический квадрат: " +  "\n");
						int[,] quad = {
						{9,16,2,7},
						{6,3,13,12},
							{15,10,8,1}
						};
							
						for(int i=0; i < 3; i++) {
							for(int j=0; j < 4; j++)
								Console.Write(quad[i,j] + "\t");
							Console.WriteLine();
						}               
							Console.WriteLine();            
			    
			Console.WriteLine("шифрованный магический квадрат:");
			string cryptedString = "";
			for (int i = 0; i < 3; i++)
			{ for (int j = 0; j < 4; j++)
				{ if ((quad[i, j] - 1) < line.Length)
					{ Console.Write(line[quad[i, j] - 1] + "\t");
						cryptedString += line[quad[i, j] - 1];                    }
				else
				{ char randomChar = randomLine[rand.Next(0, randomLine.Length - 1)];
					Console.Write(randomChar + "\t");
					cryptedString += randomChar;                    }                }
				Console.WriteLine();            }
			Console.WriteLine("\nЗашифрованная строка:");
			Console.WriteLine(cryptedString);
			Console.ReadKey();        }    }    }

