using System;
namespace FRACCIONGENERICA
{
	class Program
	{
		static void compararNum(Fraccion<int> a, Fraccion<int> b)
		{
			if(a.getNum() == b.getNum()){
				Console.WriteLine("Numeros Iguales o Cadenas Iguales");
				Console.WriteLine(a.getNum());
				Console.WriteLine(b.getNum());
			}
			else
				Console.WriteLine("Numeros NO Iguales o Cadenas NO Iguales");
				Console.WriteLine(a.getNum());
				Console.WriteLine(b.getNum());
		}

		public static void Main(string[] args)
		{
			Fraccion<int> a = new Fraccion<int>(4,3);
			Fraccion<int> b = new Fraccion<int>(2,8);
			
			a.mostrar();
			b.mostrar();
			compararNum(a,b);
			
			Console.WriteLine("=============================");
			
			Fraccion<string> c = new Fraccion<string>("Diego","Jhon");
			Fraccion<string> d = new Fraccion<string>("Diego","Jhon");
			c.mostrar();
			d.mostrar();
			bool res = c.compararDen(d);
			if(res == true){
				Console.WriteLine("Son iguales");
				c.getDen();
				d.getDen();
			}
			else{
				Console.WriteLine("No son Iguales");
				c.getDen();
				d.getDen();
			}
			
			
			Console.ReadKey(true);
		}
	}
}