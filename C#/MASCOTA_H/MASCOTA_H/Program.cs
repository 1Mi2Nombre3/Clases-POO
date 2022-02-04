using System;

namespace MASCOTA_H
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			Perro p1 = new Perro("fifi",3,"cafe","San bernando",true);
			p1.mostrar();
			
			Console.WriteLine("");
			
			Gato g1 = new Gato("Pelusa",4,"Blanco","Angora");
			g1.mostrar();
			
			Console.WriteLine("");
			
			Pez a1 = new Pez("Nemo",2,"MultiColor","Bacalao","Salada");
			a1.mostrar();
			
			Console.ReadKey(true);
			*/
			// Crear un vector de peces
			Pez[] v1 = new Pez[10];
			Console.WriteLine("Ingrese N: ");
			int n = int.Parse(Console.ReadLine());
			for(int i=0 ; i<n ;i++){
				Pez aux = new Pez();
				aux.leer();
				v1[i] = aux;
			}
			for(int i=0 ; i<n ; i++){
				v1[i].mostrar();
			}
			Console.ReadKey();
		}
	}
}