using System;

namespace MASCOTA_H
{
	public class Mascota
	{
		// ATRIBUTOS 
		protected string nom;
		protected int edad;
		protected string color;
		
		// CONSTRUCTORES
		public Mascota()
		{
			this.nom = "";
			this.edad = 0;
			this.color = "";
		}
		public Mascota(string n, int e, string c){
			this.nom = n;
			this.edad = e;
			this.color = c;
		}
		
		// LEER Y MOSTRAR
		public void leerM(){
			Console.WriteLine("Ingrese Nombre: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingrese Edad: ");
			this.edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese Color");
			this.color = Console.ReadLine();
		}
		public void mostrarM(){
			Console.WriteLine("Nombre:"+this.nom+"-Edad:"+this.edad+"-Color:"+this.color);
		}
		
		// GETTERS / SETTERS
		public string getNom(){
			return this.nom;
		}
		public void setNom(String n){
			this.nom = n;
		}
		
		public int getEdad(){
			return this.edad;
		}
		public void setEdad(int e){
			this.edad = e;
		}
		
		public string getColor(){
			return this.color;
		}
		public void setColor(string c){
			this.color = c;
		}
	}
}
