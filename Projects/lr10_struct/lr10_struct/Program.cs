using System;
using System.IO;
using System.Collections.Generic;

namespace lr10_struct
{
	struct train {
		public string place ; 
		public int tr_number;
		public DateTime timearr;

		public override string ToString()
		{
			return (string.Format( "Пункт назначения\t{0};\nНомер поезда\t{1};\nВремя прибытия\t{2};" , place,tr_number,timearr ) );
		}
	}
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			train [] mas = new train[3];

			Console.WriteLine ("Ввод в массив данных");

				mas=addmas (3);
		

		}
		public static void print(train [] a)
		{
			

			Console.WriteLine ("Поиск по времени");
			Console.WriteLine ("Введите время");
			DateTime time= Convert.ToDateTime(Console.ReadLine());


			foreach (train elem in a) {
				if ( time<=elem.timearr)
				Console.WriteLine (elem);
			}
		 	
		}
		public static train[] addmas(int n){
			train [] mas = new train[n];
					for (int i = 0; i != mas.Length; i++) {
				Console.WriteLine ("Введите пункт назначения : ");
				mas[i].place = Console.ReadLine ();
				Console.WriteLine ("Номер поезда : ");
				mas[i].tr_number = Convert.ToInt32 (Console.ReadLine ());
				Console.WriteLine ("Время прибытия:");
				mas[i].timearr = Convert.ToDateTime(Console.ReadLine ());

			}
			Array.Sort (mas, new Comparison<train>((a,b)=>a.place.CompareTo(b.place)));

				foreach (train elem in mas) {
				
					Console.WriteLine (elem);
				
				
				

			}
			print (mas);
			return mas;
		}
	}
}
