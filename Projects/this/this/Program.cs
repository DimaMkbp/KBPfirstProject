using System;


	class rect{
		public int height ;
		public int width;
		public rect ( int a , int b ){
		width = a;
		height = b; 
	}
		public int area () {
			return width*height;
		}
	class MainClass
	{
		public static void Main(string[] args)
		{
			rect r1 = new rect (2, 3);
			rect r2 = new rect (4, 5);
				Console.WriteLine(
					"Площадь прямоугольника r1: " + r1.area());
				Console.WriteLine(
					"Площадь прямоугольника r2: " + r2.area());
		}
	}
}
