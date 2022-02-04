using System;

namespace FRACCION
{
	class Program
	{
		static void sumar(Fraccion a, Fraccion b)
		{
			Fraccion c = new Fraccion();
			c.setNum((a.getNum() * b.getDen()) + (a.getDen() * b.getNum()));
			c.setDen(a.getDen() * b.getDen());
			c.mostrarFraccion();
		}

		static void multiplicar(Fraccion a, Fraccion b)
		{
			Fraccion c = new Fraccion();
			c.setNum(a.getNum() * b.getNum());
			c.setDen(a.getDen() * b.getDen());
			c.mostrarFraccion();
		}
		
		public static void Main(string[] args)
		{
			/*
	
			Fraccion a = new Fraccion(4,3);
			Fraccion b = new Fraccion(2,5);
			Fraccion c = new Fraccion();
			
			Console.WriteLine("MULTIPLICAR");
			multiplicar(a,b);
			Console.WriteLine("SUMAR");
			sumar(a,b);
			
			Console.ReadKey();
			Console.ReadKey();
			
			*/
			Fraccion a = new Fraccion(5,2);
			Fraccion b = new Fraccion(4,2);
			Fraccion c = new Fraccion();
			c = a*b;
			c.mostrarFraccion();
			Console.WriteLine("====================");
			c.mostrarFraccion();
			c++;
			c.mostrarFraccion();
			c--;
			c.mostrarFraccion();
			Console.WriteLine("====================");
			
			if(a==b)
				Console.WriteLine("Fracciones iguales");
			else
				Console.WriteLine("Fracciones distintas");
			
			
			
			Console.ReadKey();
		}			
	}
}