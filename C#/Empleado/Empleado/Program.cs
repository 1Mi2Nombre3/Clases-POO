using System;

namespace Empleado
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Sueldo basico actual 2021: 2064bs
			
			Console.WriteLine("Ingrese cantidad de empleados: ");
			int ce = int.Parse(Console.ReadLine());
			Empleado a = new Empleado(ce);
			a.mostrarEmpleado(ce);
			double s = a.pagaTotal();
			Console.WriteLine("La reserva total para pagar salarios es de: "+s);
			
			
			Console.ReadKey(true);
		}
	}
}