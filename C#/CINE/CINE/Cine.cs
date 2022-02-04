using System;

namespace CINE
{
	public class Cine
	{
		// ATRIBUTOS
		
		private string nombre;
		private string direccion;
		private int cantidadPelicula = 0;
		private string[] nombrePelicula = new string[100];
		private string[] generoPelicula = new string[100];
		private int[] precioPelicula = new int[100];
		
		// CONSTRUCTORES
		
		public Cine(){
			this.nombre = "";
			this.direccion = "";
			this.cantidadPelicula = 0;
		}
		public Cine(string nom, string d, int cp){
			this.nombre = nom;
			this.direccion = d;
			this.cantidadPelicula = cp;
			for(int i=0 ; i<this.cantidadPelicula ; i++){
				Console.WriteLine("===== PELICULA:"+(i+1)+"=====");
				Console.WriteLine("ingrese nombre: ");
				this.nombrePelicula[i] = Console.ReadLine();
				Console.WriteLine("ingrese genero: ");
				this.generoPelicula[i] = Console.ReadLine();
				Console.WriteLine("ingrese precio de butaca: ");
				this.precioPelicula[i] = int.Parse(Console.ReadLine());
			}
		}
		
		// LEER Y MOSTRAR
		
		public void leerCine(){
			Console.WriteLine("Ingres nombre de Cine: ");
			this.nombre = Console.ReadLine();
			Console.WriteLine("Ingrese direccion: ");
			this.direccion = Console.ReadLine();
			Console.WriteLine("Ingrese cantidad de peliculas: ");
			this.cantidadPelicula = int.Parse(Console.ReadLine());
			for(int i=0 ; i<this.cantidadPelicula ; i++){
				Console.WriteLine("===== PELICULA:"+(i+1)+"=====");
				Console.WriteLine("ingrese nombre: ");
				this.nombrePelicula[i] = Console.ReadLine();
				Console.WriteLine("ingrese genero: ");
				this.generoPelicula[i] = Console.ReadLine();
				Console.WriteLine("ingrese precio de butaca: ");
				this.precioPelicula[i] = int.Parse(Console.ReadLine());
			}
		}
		public void mostrarCine(){
			Console.WriteLine("Nombre: "+this.nombre);
			Console.WriteLine("Direccion: "+this.direccion);
			Console.WriteLine("Cantidad de peliculas: "+this.cantidadPelicula);
			for(int i=0 ; i<this.cantidadPelicula ; i++){
				Console.WriteLine("===== PELICULA:"+(i+1)+"=====");
				Console.WriteLine("nombre: "+this.nombrePelicula[i]);
				Console.WriteLine("genero: "+this.generoPelicula[i]);
				Console.WriteLine("precio: "+this.precioPelicula[i]);
			}
		}
		// GETTERS AND SETTERS
		
		public string getNombre() {
			return this.nombre;
	    }
	
	    public void setNombre(string nom) {
	        this.nombre = nom;
	    }
		
		public string getDireccion(){
			return this.direccion;
		}
		public void setDireccion(string d){
			this.direccion = d;
		}
		
		public int getCantidadPelicula(){
			return this.cantidadPelicula;
		}
		public void setCantidadPelicula(int cp){
			this.cantidadPelicula =  cp;
		}
		
	    public String[] getNombrePelicula() {
			return this.nombrePelicula;
	    }
	
	    public void setNombrePelicula(String[] np) {
	        this.nombrePelicula = np;
	    }
	
	    public String[] getGneroPelicula() {
			return this.generoPelicula;
	    }
	
	    public void setGeneroPelicula(String[] gp) {
			this.generoPelicula = gp;
	    }
	
	    public int[] getPrecioPelicula() {
			return this.precioPelicula;
	    }
	
	    public void setPrecioPelicula(int[] pp) {
	        this.precioPelicula = pp;
	    }
		// SOBRECARGA DE OPERADORES
		
		public static Cine operator ++(Cine a){
			for(int i=0 ;i<a.cantidadPelicula ;i++){
				
				a.precioPelicula[i] = a.precioPelicula[i] + 5;
			}
			return a;
		}
		// METODOS
		public void mostrarPelicula(string gen){
			for(int i=0 ;i<this.cantidadPelicula ;i++){
				if(this.generoPelicula[i].Equals(gen)){
					Console.WriteLine("Nombre:"+this.nombrePelicula[i]+" Genero:"+this.generoPelicula[i]+" Precio:"+this.precioPelicula[i]);
				}
			}
		}
		
		public void mostrarPelicula(int x){
			Console.WriteLine("Nombre:"+this.nombrePelicula[x]+" Genero:"+this.generoPelicula[x]+" Precio:"+this.precioPelicula[x]);
		}	
		
	}
}
