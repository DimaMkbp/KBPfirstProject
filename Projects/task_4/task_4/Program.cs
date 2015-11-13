using System;

namespace task_4
{
	
	public class rectangle
	{  public static bool brake =false;
		int x, y, shirina, visota;

		public  rectangle(int x,int y,int shirina,int visota)
		{
			this.x = x;
			this.y = y;
			this.shirina = shirina;
			this.visota = visota;
		}
		public void perem(int l,int h,ref int x,ref int y)
		{
			x -= l;
			y -= h;
		}

		public void sovm(int x1,int x2,int y1,int y2,int shirina1,int shirina2, int visota1, int visota2)
		{

			if (x1 > x2)
			{
				int buf=x1;
				x1=x2;
				x2=buf;
			}
			if (x1 + shirina1 < x2 + shirina2)
			{
				x = x1;
				shirina = x2 - x1 + shirina2;
			}
			else
			{
				x = x1;
				shirina =shirina2;
			}

			if (y1 > y2)
			{
				int buf = y1;
				y1 = y2;
				y2 = buf;
			}
			if (y1 + visota1 < y2 + visota2)
			{
				y = y1;
				visota = y2 - y1 + visota2;
			}
			else
			{
				y = y1;
				visota = visota2;
			}
			Console.WriteLine("x={0},y={1},weight={2},height={3}",x,y,shirina,visota);
		}



		public void izm(int x,int y,ref int shirina,ref int visota)
		{
			shirina -= x;
			visota -= y;
		}

		public void show(int x,int y,int shirina,int visota)
		{
			Console.WriteLine("{0} {1} {2} {3}", x, y, shirina, visota);
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите х");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите у");
			int y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите ширину");
			int weight = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите высоту");
			int height = Convert.ToInt32(Console.ReadLine());
		
			Console.WriteLine("1 - Переместить");
			Console.WriteLine("2 - Изменить");
			Console.WriteLine("3 - Показать");
			Console.WriteLine("4 - Совместить");
			Console.WriteLine("5 - Выход");



			rectangle rect1 = new rectangle(x,y,weight,height);
		

			Console.WriteLine("Введите комманду");
			do {
				switch (Convert.ToInt32( Console.ReadLine()))
				{
				case 1:{
						Console.WriteLine("Значение перемещения х");
						int ValueX = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Значение премещения у");
						int ValueY = Convert.ToInt32(Console.ReadLine());

						rect1.perem(ValueX, ValueY,ref x, ref y); break;
					}
				case 2:{
						Console.WriteLine("Значение изменения ширины");
						int PickW = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Значение изменения высоты");
						int PickH = Convert.ToInt32(Console.ReadLine());
						rect1.izm(PickW,PickH,ref weight,ref height); break;}
				case 3: 
					{Console.WriteLine("x y Ширина Высота");
						rect1.show(x,y, weight,height); break;
					}
				case 4: {
						Console.WriteLine("Значение  х2");
						int x2 = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Значение  у2");
						int y2 = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Значение weight2");
						int weight2= Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Значение height2");
						int height2 = Convert.ToInt32(Console.ReadLine());
						rect1.sovm( x,x2,y, y2,weight,weight2, height,height2);break;
					}
				case 5: rectangle.brake=true; break;
				default: Console.WriteLine("Неверные данные, повторите!"); break;
				}
			} while (!rectangle.brake);
		}
	}
}