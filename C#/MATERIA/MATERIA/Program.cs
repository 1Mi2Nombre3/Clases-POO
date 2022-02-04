using System;

namespace MATERIA
{
	class Program
	{
		public static void Main(string[] args)
		{
			Materia a = new Materia();
			a.mostrarMateria();
			
			Console.WriteLine("=====================");
			
			Materia b = new Materia("INF111");
			b.mostrarMateria();
			
			Console.WriteLine("=====================");
			
			Materia c = new Materia("INF121","Algoritmos y programacion");
			c.mostrarMateria();
			
			Console.WriteLine("=====================");
	
			Materia d = new Materia("INF131", "Estructura de datos" , "A" , 3);
			d.mostrarMateria();
			
			Console.WriteLine("=====================");
			// Para el vector tenemos que tener un vector
			
			String[] x = new String[5];
			for(int i=0 ; i<5 ; i++){
				Console.WriteLine("Nombre del Estudiante: " + (i+1));
				x[i] = Console.ReadLine();
			}
			Materia e = new Materia("INF143","Taller de Programacion","B",5,x);
			e.mostrarMateria();
			
			
			
			
			
			
			
			
			Console.ReadKey();
		}
	}
}