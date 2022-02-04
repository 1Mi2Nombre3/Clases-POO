using System;

namespace CINE
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Cine a = new Cine();
			a.leerCine();
			Console.WriteLine("===================");
			a.mostrarCine();
			a.mostrarPelicula("Comedia");
			a++;
			a.mostrarCine();
			Console.ReadKey(true);
			Console.ReadKey(true);
			Console.ReadKey(true);
			Console.ReadKey(true);
		}
	}
}