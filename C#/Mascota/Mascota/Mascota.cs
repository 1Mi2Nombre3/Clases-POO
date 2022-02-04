using System;

namespace Mascota
{
	public class Mascota
	{
		//ATRIBUTOS 
		private string nom;
		private string raza;
		private string tipo;
		private string color;
		private int edad;
		
		//CONSTRUCTORES
		public Mascota()
		{
			nom = "";
			raza = "";
			tipo = "";
			color = "";
			edad = 0;
		}
		public Mascota(string nom, string raza, string tipo, string color, int edad){
			this.nom = nom;
			this.raza = raza;
			this.tipo = tipo;
			this.color = color;
			this.edad = edad;
		}
		
		//Mostrar y Leer
		
		public void leerMascota(){
			Console.WriteLine("NOMBRE: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("RAZA: ");
			this.raza = Console.ReadLine();
			Console.WriteLine("TIPO: ");
			this.tipo = Console.ReadLine();
			Console.WriteLine("COLOR: ");
			this.color = Console.ReadLine();
			Console.WriteLine("EDAD: ");
			this.edad = int.Parse(Console.ReadLine());
		}
		
		public void mostrarMascota(){
			Console.WriteLine("Nombre: "+this.nom);
			Console.WriteLine("Raza:" + this.raza);
			Console.WriteLine("Tipo: "+this.tipo);
			Console.WriteLine("Color: "+this.color);
			Console.WriteLine("Edad: "+this.edad);
		}
		
		//GETTERS AND SETTERS
		
		public string getNom(){
			return nom;
		}
		public void setNom(string nom){
			this.nom = nom;
		}
		
		public string getRaza(){
			return raza;
		}
		public void setRaza(string raza){
			this.raza = raza;
		}
		
		public string getTipo(){
			return tipo;
		}
		public void setTipo(string tipo){
			this.tipo = tipo;
		}
		
		public string getColor(){
			return color;
		}
		public void setColor(string color){
			this.color = color;
		}
		public int getEdad(){
			return edad;
		}
		public void setErdad(int edad){
			this.edad = edad;
		}
		
		public int verificaRaza1(string x){
			int resp;
			if(x.Equals(this.raza)){
				resp = 1;
			}
			else{
				resp = 0;
			}
			return resp;
		}
		public bool verificaRaza2(string x)
		{
			if(this.raza.Equals(x)){
				return true;
			
			}
			else{
				return false;
			}
		}
		public bool verificarIguales(Mascota m){
			if(this.nom.Equals(m.nom) && (this.tipo.Equals(m.tipo)) && (this.raza.Equals(m.raza)) && (this.color.Equals(m.color)) && (this.edad.Equals(m.edad))){
				return true;
			}
			else{
				return false;
			}
		}
		
	}
}
