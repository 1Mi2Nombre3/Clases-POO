using System;

namespace AGRE_COMP
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*    
			Estudiante[] e = new Estudiante[2];
			for(int i=0; i<2; i++){
				Estudiante z = new Estudiante();
				z.leer();
				e[i] = z;
			}
			Universidad x = new Universidad("SAN ANDRES","LA PAZ",1930,2,e);
			x.mostrarU();
			*/
			
			Universidad y = new Universidad();
			y.leerU();
			y.mostrarU();
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}