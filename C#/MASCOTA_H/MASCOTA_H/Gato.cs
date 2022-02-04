using System;

namespace MASCOTA_H
{
	public class Gato:Mascota
	{
		// ATRIBUTOS
		private string raza;
		
		// CONSTRUCTORES
		public Gato():base()
		{
			this.raza = "";
		}
		public Gato(string n, int e ,string c, string r):base(n,e,c){
			this.raza = r;
		}
		
		//LEER Y MOSTRAR
		public void leer(){
			base.leerM();
			Console.WriteLine("Ingrese raza");
			this.raza = Console.ReadLine();
		}
		public void mostrar(){
			base.mostrarM();
			Console.WriteLine("Raza:"+this.raza);
		}
		// GETTERS / SETTERS
		
		public string getRaza(){
			return this.raza;
		}
		public void setRaza(string r){
			this.raza = r;
		}
	}
}
