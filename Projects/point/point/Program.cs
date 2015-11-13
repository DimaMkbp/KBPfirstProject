using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lb9
{
	class Point
	{
		protected int Xpos;
		protected int Ypos;
		public Point(int x, int y)
		{
			Xpos = x;
			Ypos = y;
		}
		public virtual void Draw()
		{
			Console.WriteLine("Точка в: ({0},{1})", Xpos, Ypos);
		}
	}
	class ColorPoint : Point
	{
		string clr;
		public ColorPoint(int x, int y, string color)
			: base(x, y)
		{
			clr = color;
		}
		public override void Draw()
		{
			Console.WriteLine("Точка в: ({0},{1}) цвета: {2}", Xpos, Ypos, clr);
		}
	}
	class Line : Point
	{
		protected int Xo;
		protected int Yo;
		public Line(int x, int y, int a, int u)
			: base(x, y)
		{
			Xo = a;
			Yo = u;
		}
		public override void Draw()
		{
			Console.WriteLine("Линия: Начальная точка ({0},{1}) конечная точка ({2},{3}) ", Xpos, Ypos, Xo, Yo);
		}
	}
	class ColoredLine : Line
	{
		string clr;

		public ColoredLine(int x, int y, int a, int u, string color)
			: base(x, y, a, u)
		{
			Xo = a;
			Yo = u;
			clr = color;

		}
		public override void Draw()
		{
			Console.WriteLine("Линия: Начальная точка ({0},{1}) конечная точка ({2},{3}) цвет: {4} ", Xpos, Ypos, Xo, Yo, clr);
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Родительский класс point");
			Console.WriteLine("point введите координату X ");
			int k = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("point введите координату Y ");
			int l = Convert.ToInt16(Console.ReadLine());
			Point onepoint = new Point(k, l);
			onepoint.Draw();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Дочерний класс ColorPoint");
			Console.WriteLine("ColorPoint введите координату X ");
			k = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("ColorPoint введите координату Y ");
			l = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("ColorPoint введите цвет");
			string s = Console.ReadLine();
			Point pt = new ColorPoint(k, l, s);
			pt.Draw();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Класс Line, образован от класса Point   ");
			Console.WriteLine("Line введите координату X  ");
			k = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Line введите координату Y ");
			l = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Координаты конца линии   ");
			Console.WriteLine("Line введите координату X  ");
			int m = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Line введите координату Y ");
			int z = Convert.ToInt16(Console.ReadLine());
			Point lin = new Line(k, l, m, z);
			lin.Draw();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Класс ColoredLine, образован от класса Line   ");
			Console.WriteLine("ColoredLine введите координату X  ");
			k = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("ColoredLine введите координату Y ");
			l = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Координаты конца линии   ");
			Console.WriteLine("ColoredLine введите координату X  ");
			m = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("ColoredLine введите координату Y ");
			z = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("ColorLine введите цвет");
			s = Console.ReadLine();
			Point cln = new ColoredLine(k, l, m, z, s);
			cln.Draw();
			Console.WriteLine();
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}