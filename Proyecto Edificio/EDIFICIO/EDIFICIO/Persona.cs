using System;

namespace EDIFICIO
{
	public class Persona
	{
		// ATRIBUTOS
		protected string nom;
		protected int edad;
		protected string celular;
		protected string cedula;
		protected string genero;
		protected string estadoCivil;
		
		// CONSTRUCTORES
		public Persona()
		{
			this.nom = "";
			this.edad = 0;
			this.celular = "";
			this.cedula  = "";
			this.genero = "";
			this.estadoCivil = "";
		}
		public Persona(string n, int e ,string ced, string cel, string g, string es){
			this.nom = n;
			this.edad = e;
			this.cedula = ced;
			this.celular = cel;
			this.genero = g;
			this.estadoCivil = es;
		}
		// LEER Y MOSTRAR
		
		public void leerP(){
			Console.WriteLine("Ingrese Nombre: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingrese Edad: ");
			this.edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese C.I.: ");
			this.cedula = Console.ReadLine();
			Console.WriteLine("Ingrese Genero: ");
			this.genero = Console.ReadLine();
			Console.WriteLine("Ingrese Estado Civil: ");
			this.estadoCivil = Console.ReadLine();
		}
		
		public void mostrarP(){
			Console.WriteLine("Nom:"+this.nom+"-Edad:"+this.edad+"-C.I.:"+this.cedula+"-Genero:"+this.genero+"-Est.Civil:"+this.estadoCivil );
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
		public string getCedula(){
			return this.cedula;
		}
		public void setCedula(string ced){
			this.cedula = ced;
		}
		public string getCelular(){
			return this.celular;
		}
		public void setCelular(string cel){
			this.celular = cel;
		}
		public string getGenero(){
			return this.genero;
		}
		public void setGenero(string g){
			this.genero = g;
		}
		public string getEstadoCivil(){
			return this.estadoCivil;
		}
		public void setEstadoCivil(string es){
			this.estadoCivil = es;
		}
	}
}
