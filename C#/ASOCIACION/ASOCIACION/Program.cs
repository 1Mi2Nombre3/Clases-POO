using System;

namespace ASOCIACION
{
	class Program
	{
		public static void Main(string[] args)
		{
			Auto x = new Auto("abc-123","Toyota");
			
			Persona p1 = new Persona("Ana Lopez","12345lp",x);
			p1.mostrar();
			
			
			Console.ReadKey(true);
		}
	}
}