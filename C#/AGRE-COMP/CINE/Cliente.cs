using System;
namespace CINE
{
	public class Cliente
	{
		// ATRIBUTOS
		protected string nom;
		protected int edad;
		
		// CONSTRUCTORES
		public Cliente()
		{
			this.nom = "";
			this.edad = 0;
		}
		public Cliente(string n, int e){
			this.nom = n;
			this.edad = e;
		}
		
		// LEER Y MOSTRAR
		public void leerCl(){
			Console.WriteLine("Ingrese Nombre: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingrese Edad: ");
			this.edad = int.Parse(Console.ReadLine());
		}
		public void mostrarCl(){
			Console.WriteLine("Nom:"+this.nom+"-Edad:"+this.edad);
		}
		
		// GETTERS / SETTERS
		public string getNom(){
			return this.nom;
		}
		public void setNom(string n){
			this.nom = n;
		}
		public int getEdad(){
			return this.edad;
		}
		public void setEdad(int e){
			this.edad = e;
		}
	}
}
