using System;
namespace CINE
{
	public class Pelicula
	{
		// ATRIBUTOS
		private string nom;
		private string genero;
		private int precio;
		
		// CONSTRUCTORES
		public Pelicula()
		{
			this.nom = "";
			this.genero = "";
			this.precio = 0;
		}
		public Pelicula(string n, string g, int p){
			this.nom = n;
			this.genero = g;
			this.precio = p;
		}
		
		// LEER Y MOSTRAR
		public void leerP(){
			Console.WriteLine("Ingrese Nombre: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingrese Genero: ");
			this.genero = Console.ReadLine();
			Console.WriteLine("Ingrese Precio: ");
			this.precio = int.Parse(Console.ReadLine());
		}
		public void mostrarP(){
			Console.WriteLine("Nom:"+this.nom+"-Genero:"+this.genero+"-Precio:"+this.precio);
		}
		
		// GETTERS / SETTERS
		public string getNom(){
			return this.nom;
		}
		public void setNom(string n){
			this.nom = n;
		}
		public string getGenero(){
			return this.genero;
		}
		public void setGenero(string g){
			this.genero = g;
		}
		public int getPrecio(){
			return this.precio;
		}
		public void setPrecio(int p){
			this.precio = p;
		}
		
	}
}
