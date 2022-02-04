using System;
namespace ARCHIVOSPERSONA
{
	class Program
	{
		public static void Main(string[] args)
		{
			Persona p1 = new Persona("Jhon","Estudiante",21);
			p1.mostrar();
			
			Console.WriteLine("==ESCRIBIENDO EN EL ARCHIVO==");
			ArchivoPersona a1 = new ArchivoPersona();
			if(a1.guardarPersona(p1)== true){
				Console.WriteLine("Persona guardadad en el archivo");
			}
			else{
				Console.WriteLine("ERROR");
			}
					
			Console.WriteLine("==RECUPERANDO EL OBJETO==");
			Persona w = new Persona();
			w = a1.recuperarPersona();
			w.mostrar();
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}