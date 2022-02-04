using System;

namespace ASOCIACION
{

	public class Persona
	{
		private string nom;
		private string cedula;
		private Auto a1;
		
		public Persona()
		{
			this.nom = "";
			this.cedula = "";
		}
		public Persona(string n, string c, Auto x){
			this.nom = n;
			this.cedula = c;
			if (x != null)
				this.a1 = x;
			
		}
		public void leer(){
			Console.WriteLine("Ingrese Nombre: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingrese Cedula");
			this.cedula = Console.ReadLine();
			Console.WriteLine("Ingrese datos del auto");
			this.a1.leer();
			
		}
		public void mostrar(){
			Console.WriteLine("NOM:"+this.nom+"-C.I:"+this.cedula);
			Console.WriteLine("Datos del auto");
			this.a1.mostrar();
		}
	}
}
