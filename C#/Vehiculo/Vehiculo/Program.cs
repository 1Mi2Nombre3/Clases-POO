using System;

namespace Vehiculo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Vehiculo x
			Console.WriteLine("=========================");
			Vehiculo x;
			x = new Vehiculo();
			x.leerVehiculo();
			x.mostrarVehiculo();
			
			// Vehiculo y
			Console.WriteLine("=========================");
			Vehiculo y = new Vehiculo("aer123","TOYOTA",123,",minibus","rojo",4);
			y.mostrarVehiculo();
			
			
			//EJERCICIO GETTERS AND SETTERS
			Console.WriteLine("=========================");
			Vehiculo a1 = new Vehiculo("aer123","TOYOTA",123,",minibus","rojo",4);
			a1.mostrarVehiculo();
			Console.WriteLine(a1.getColor());
			Console.ReadKey();		
		}
	}
} 