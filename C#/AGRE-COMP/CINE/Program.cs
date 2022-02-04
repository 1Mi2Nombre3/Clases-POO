using System;

namespace CINE
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Cantidad Clientes CINE1:");
			int n = int.Parse(Console.ReadLine());
			Cliente[] c = new Cliente[n];
			for(int i=0 ; i<n ;i++){
				Cliente aux = new Cliente();
				aux.leerCl();
				c[i] = aux;
			}
			Console.WriteLine("==================");
			Console.WriteLine("Cantidad Clientes CINE2:");
			int n1 = int.Parse(Console.ReadLine());
			Cliente[] c0 = new Cliente[n1];
			for(int i=0 ; i<n ;i++){
				Cliente aux = new Cliente();
				aux.leerCl();
				c0[i] = aux;
			}
			Console.WriteLine("");
			
			
			Cine c1 = new Cine("Monopolis","Av.Periferica",3,c);
			Cine c2 = new Cine("MultiCine","Av.Arce",2,c0);
			c2.mostrarC();
			
			Console.ReadKey(true);
			Console.ReadKey(true);

		}
	}
}