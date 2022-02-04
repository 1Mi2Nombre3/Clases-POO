using System;
namespace CINE
{
	public class Cine
	{
		// ATRIBUTOS
		private string nom;
		private string dir;
		
		private int nc;
		private int np;
		private Cliente[] cl;
		private Pelicula[] pel = new Pelicula[50];
		
		// CONSTRUCTORES
		public Cine()
		{
			this.nom = "";
			this.dir = "";
			this.nc = 0;
			this.np = 0;
		}
		public Cine(string n, string d,int nc, Cliente[]c){
			this.nom = n;
			this.dir = d;
			// PELICULAS 
			this.np = 3;
			Pelicula x = new Pelicula("Hombre Araña","Ficcion",35);
			Pelicula y = new Pelicula("¿Quien yo?","Comedia",20);
			Pelicula z = new Pelicula("Romeo y Julieta","Romance",25);
			this.pel[0] = x;
			this.pel[1] = y;
			this.pel[2] = z;
			
			// CLIENTES
			this.cl = new Cliente[nc];
			this.nc = nc;
			for(int i=0 ; i<this.nc ; i++){
				Cliente aux = new Cliente();
				aux = c[i];
				this.cl[i] = aux;
			}
		}
		
		// LEER Y MOSTRAR
		public void leerC(){
			Console.WriteLine("Ingrese Nombre de Cine: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingrese Direccion de Cine: ");
			this.dir = Console.ReadLine();
			Console.WriteLine("==DATOS DE PELICULA==");
			Console.WriteLine("Nro Peliculas (al menos 1): ");
			do{
				this.np = int.Parse(Console.ReadLine());
			}while(this.np <= 0);
			for(int i=0 ; i<this.np ; i++){
				Pelicula p1 = new Pelicula();
				p1.leerP();
				this.pel[i] = p1;
			}
			Console.WriteLine("==DATOS DE CLIENTE==");
			Console.WriteLine("Nro Clientes: ");
			this.nc = int.Parse(Console.ReadLine());
			for(int i=0 ; i<this.nc ; i++){
				Cliente auxc = new Cliente();
				auxc.leerCl();
				this.cl[i] = auxc;
			}
		}
		public void mostrarC(){
			Console.WriteLine("NOM:"+this.nom+"-DIR:"+this.dir);
			Console.WriteLine("==DATOS DE PELICULA");
			for(int i=0 ; i<this.np ;i++){
				this.pel[i].mostrarP();
			}
			Console.WriteLine("==DATOS DE CLIENTE==");
			for(int i=0 ;i<this.nc ;i++){
				cl[i].mostrarCl();
			}
		}
	}
}











