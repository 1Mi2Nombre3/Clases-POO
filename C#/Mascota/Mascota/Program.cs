using System;

namespace Mascota
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*
			Mascota a = new Mascota("Pelusa","angora","gato","blanco",4);
			Mascota b = new Mascota("Pelusa","angora","gato","blanco",4);
			
 * 			a.mostrarMascota();
			Console.WriteLine("=====================");
			
			a.setColor("negro");             // Cambia o (COLOCA) el color desde el parentesis
			Console.WriteLine("Color: "+a.getColor()); // Muestra u (OBTIENE) el color desde un WriteLine
			a.setColor("blanco");
			Console.WriteLine("============================");
			
			//1 verificar Raza
			int respuesta;
			respuesta = a.verificaRaza1("angora");
			Console.WriteLine(respuesta);
			
			
			//2 Verificar Raza2
			bool c;
			c = (a.verificaRaza2("angora"));
			Console.WriteLine(c);
			
			//Verificar Mascotas
			Console.WriteLine("====================");
			a.mostrarMascota();
			b.mostrarMascota();
			Console.WriteLine("====================");
			if(a.verificarIguales(b)){
				Console.WriteLine("Son iguales");
			}
			else{
				Console.WriteLine("Son distintos");
			}
			Console.ReadKey();
			*/
			
			// 3 Dado un vector de mascotas ordenar por edad
			int n = int.Parse(Console.ReadLine());
			Mascota [n] = new Mascota M;
			Console.WriteLine("leyendo elementos del vector de mascota");
			leerVectorM();
			mostrarVectorM();
			ordenarVectorM();
			mostrarVectorM();
			
		}
	}
}