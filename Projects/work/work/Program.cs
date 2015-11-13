using System;
using System.Collections;

namespace work
{
class work
	{
		public static bool brake = false;
		public double zarp(double  time, int day, int d)
		{
			double zrp = time * day * d;
			return zrp;
		}

		}
		class child : work 
	{ 
		public string fix( string x)
		{
			return x;
		}

		}
		class child2 : work 
	{ 
	public double sred(int ps)
	{
		double zp = (double)20.8 * 8 * ps;
		return zp;

		}
		}
		
	class MainClass
	{
		public static void Main (string[] args)
		{
			ArrayList list = new ArrayList ();
			Console.WriteLine (" Введите работника");
			list.Add (Console.ReadLine ());
			Console.WriteLine ("Введите фиксированную ЗП");
			string fix = Convert.ToString(Console.ReadLine());
			Console.WriteLine ("Выберите действие :\n" +
				"1 - расчитать среднемесячную заработную плату;\n" +
				"2 - вывести фиксированную ЗП;\n" +
				"3 - расчитать среднемесячную ЗП для повременщиков;\n" +
				"4 - Выход. ");
				
			do {
				switch (Convert.ToInt32 (Console.ReadLine ())) {
				case 1:
					{
						Console.WriteLine ("Введите отработанное время в день");
						int time = Convert.ToInt32 (Console.ReadLine ());
						Console.WriteLine ("Введите кол-во дней");
						int day = Convert.ToInt32 (Console.ReadLine ());
						Console.WriteLine ("Введите почасовую ставку");
						int d = Convert.ToInt32 (Console.ReadLine ());
						work work1 = new work ();
						Console.WriteLine ("ЗП:");
						Console.WriteLine (work1.zarp (time, day, d) + "$");
						break;
					}
				case 2:
					{
						child ch = new child ();
						Console.WriteLine ("ЗП:");
						Console.WriteLine (ch.fix (fix) + "$");
						break;	
					}
				case 3:
					{
						Console.WriteLine ("Введите почасовую ставку");
						int hour = Convert.ToInt32 (Console.ReadLine ());
						child2 ch2 = new child2 ();
						Console.WriteLine ("ЗП:");
						Console.WriteLine (ch2.sred (hour) + "$");
						break;
						
					}
				case 4: 
					{
						work.brake = true;
						break;
					}
					
				}
			} while(!work.brake);
		}
	}
}



