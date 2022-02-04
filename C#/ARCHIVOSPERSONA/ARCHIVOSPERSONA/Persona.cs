using System;
namespace ARCHIVOSPERSONA
{
	[Serializable]
	public class Persona
	{
		// ATRIBUTOS
		private string nom;
		private string ocup;
		private int edad;
		
		// CONSTRUCTORES
		public Persona()
		{
			this.nom = "";
			this.ocup = "";
			this.edad = 0;
		}
		public Persona(string n, string o, int e){
			this.nom = n;
			this.ocup = o;
			this.edad = e;
		}
		
		// LEER Y MOSTRAR
		public void leer(){
			Console.WriteLine("Ingresar nombre: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingresar ocupacion: ");
			this.ocup = "";
			Console.WriteLine("Ingresar Edad: ");
			this.edad = 0;
		}
		public void mostrar(){
			Console.WriteLine("NOM:"+this.nom+"-OCUP"+this.ocup+"-EDAD"+this.edad);
		}
		
		// GETTERS / SETTERS
		public string getNom(){
			return this.nom;
		}
		public void setNom(string n){
			this.nom = n;
		}
		public string getOcup(){
			return this.ocup;
		}
		public void setOcup(string o){
			this.ocup = o;
		}
		public int getEdad(){
			return this.edad;
		}
		public void setEdad(int e){
			this.edad = e;
		}
	}
}
