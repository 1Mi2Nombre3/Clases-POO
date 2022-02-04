using System;
namespace COMPUTADOR
{
	class Program
	{
		public static void Main(string[] args)
		{
			MemoriaPrincipal a = new MemoriaPrincipal("8GB","4500MHz");
			MemoriaPrincipal b = new MemoriaPrincipal("8GB","4500MHz");
			a.VerificaMemoria(b);
			
			Console.ReadKey(true);
			Console.ReadKey(true);
		}
	}
}