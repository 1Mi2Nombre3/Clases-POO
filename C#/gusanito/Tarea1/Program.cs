using System;

namespace Tarea1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("MENU");
			Console.WriteLine("  1. SERIE FIBONACCI");
			Console.WriteLine("  2. DETERMINAR SI UN NÚMERO ES PRIMO");
			Console.WriteLine("  3. INVERTIR UN NUMERO");
			Console.WriteLine("  4. Salir");
			
			int x,a,b,i,n,c;
			Console.WriteLine("Seleccione un número: ");
			x = int.Parse(Console.ReadLine());
			switch(x){
				case 1: 
					Console.WriteLine("Tamaño de la serie");
					n = int.Parse(Console.ReadLine());
					a = 0;
					b = 1;
					for(i=0 ; i<n ; i++){
						Console.Write(a+" ");
						a = a + b;
						b = a - b;
					}
					Console.WriteLine();
					Console.WriteLine("Fin de programa");
					Console.ReadKey();
					break;
				case 2: 
					Console.WriteLine("Número: ");
					n = int.Parse(Console.ReadLine());
					c = 0;
					for(i=1 ; i<=n ; i++){
						if(n%i == 0){
							c = c + 1;
						}
					}
					if (c==2){
						Console.WriteLine(n+" si es primo");
					}
					else{
						Console.WriteLine(n+" no es primo");
					}
					Console.WriteLine("Fin de programa");
					Console.ReadKey();
					break;
				case 3: 
					Console.WriteLine("Número: ");
					n = int.Parse(Console.ReadLine());
					while (n!=0){
						a = n % 10;
						n = (int)(n/10);
						Console.Write(a);
					}
					Console.WriteLine();
					Console.WriteLine("Fin de programa");
					Console.ReadKey();
					break;
				case 4: 
					Console.WriteLine("Fin de programa");
					Console.ReadKey();
					break;
				default: 
					Console.WriteLine("Opción no encontrada");
					Console.WriteLine("Fin de programa");
					Console.ReadKey();
					break;
			}
		}
	}
}