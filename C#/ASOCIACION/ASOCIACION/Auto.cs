using System;

namespace ASOCIACION
{
	public class Auto
	{
		private string placa;
		private string marca;
		
		public Auto()
		{
			this.placa = "";
			this.marca = "";
		}
		public Auto(string p, string m){
			this.placa = p;
			this.marca = m;
		}
		public void leer(){
			Console.WriteLine("Ingrese Placa: ");
			this.placa = Console.ReadLine();
			Console.WriteLine("Ingrese Marca: ");
			this.marca = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("Placa:"+this.placa+"-Marca:"+this.marca);
		}
	}
}
