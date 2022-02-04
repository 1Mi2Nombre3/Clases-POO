using System;
namespace CINE
{
	public class Adulto: Cliente
	{
		// ATRIBUTOS
		private string cedula;
		
		// CONSTRUCTORES
		public Adulto():base()
		{
			this.cedula = "";
		}
		public Adulto(string n, int e, string c):base(n,e){
			this.cedula = c;
		}
		
		// LEER Y MOSTRAR
		public void leer(){
			base.leerCl();
			Console.WriteLine("Ingrese Cedula: ");
			this.cedula = Console.ReadLine();
		}
		public void mostrar(){
			base.mostrarCl();
			Console.WriteLine("CI:"+this.cedula);
		}
		
		// GETTERS / SETTERS
		public string getCedula(){
			return this.cedula;
		}
		public void setCedula(string c){
			this.cedula = c;
		}
	}
}
