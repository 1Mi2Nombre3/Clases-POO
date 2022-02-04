using System;

namespace AGRE_COMP
{
	
	public class Estudiante
	{
		private string nom;
		private string cedula;
		private int edad; 
		
		public Estudiante()
		{
			this.nom = "";
			this.cedula = "";
			this.edad = 0;
		}
		public Estudiante(string n, string c, int e){
			this.nom = n;
			this.cedula = c;
			this.edad = e;
		}
		
		public void leer(){
			Console.WriteLine("Ingrese Nombre: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingrese Cedula: ");
			this.cedula = Console.ReadLine();
			Console.WriteLine("Ingrese edad: ");
			this.edad = int.Parse(Console.ReadLine());
		}
		public void mostrar(){
			Console.WriteLine("Nom:"+this.nom+"-Cedula:"+this.cedula+"-Edad:"+this.edad);
		}
		
		public string getNom(){
			return this.nom;
		}
		public void setNom(string n){
			this.nom = n;
		}
		public string getCedula(){
			return this.cedula;
		}
		public void setCedula(string c){
			this.cedula = c;
		}
		public int getEdad(){
			return this.edad;
		}
		public void setEdad(int e){
			this.edad = e;
		}
	}
}
