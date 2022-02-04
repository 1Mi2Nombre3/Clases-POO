using System;

namespace VECTOR
{
	class Program
	{
		public static void Main(string[] args)
		{
			Vector a = new Vector();
			Vector b = new Vector();
			a.leerV();
			b.leerV();
			a.mostrarV();
			b.mostrarV();
			/*
			Console.WriteLine("=============================");
			a.mostrarV();
			Console.WriteLine("=============================");
			a.suma();
			Console.WriteLine("==============Suma 1===============");
			a.suma(3);
			Console.WriteLine("===============Suma 2==============");
			
			Console.WriteLine("===========OPERADOR==============");
			Vector c = new Vector();
			c = a + b;
			c.mostrarV();
			/*
			Console.WriteLine("===========OPERADOR==============");
			Console.WriteLine(a+b);
		
			
			Console.WriteLine("=======OPERADOR -- =============");
			a--;
			a.mostrarV();
			*/
			/*
			if(a>b)
				Console.WriteLine("es mayor ");
			else
				Console.WriteLine("es menor");
			
			Console.ReadKey(true);
			*/
			Console.WriteLine("=======OPERADOR ! =============");
			a = !a;
			a.mostrarV();
			Console.ReadKey(true);
		}
	}
}