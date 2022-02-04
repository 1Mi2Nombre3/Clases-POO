using System;

namespace EDIFICIO
{
	public class Residente : Persona
	{
		// ATRIBUTOS
		private string pais;
		private int cantHij;
		private string ocupacion;
		
		// CONSTRUCTORES
		public Residente():base()
		{
			this.pais = "";
			this.cantHij = 0;
			this.ocupacion = "";
		}
		public Residente(string n, int e, string ced, string cel, string g, string es, string p, int ch, string o):base(n,e,ced,cel,g,es){
			this.pais = p;
			this.cantHij = ch;
			this.ocupacion = o;
		}
		
		// LEER Y MOSTRAR
		public void leerR(){
			base.leerP();
			Console.WriteLine("Ingrese Pais: ");
			this.pais = Console.ReadLine();
			Console.WriteLine("Ingrese Cantidad Hijos:");
			this.cantHij = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese Ocupacion: ");
			this.ocupacion = Console.ReadLine();
		}
		public void mostrarR(){
			base.mostrarP();
			Console.WriteLine("Pais:"+this.pais+"-CantHij:"+this.cantHij+"-Ocupación:"+this.ocupacion);
		}
		
		// GETTERS / SETTERS
		
		public string getPais(){
			return this.pais;
		}
		public void setPais(string p){
			this.pais = p;
		}
		public int getCantHij(){
			return this.cantHij;
		}
		public void setCantHij(int ch){
			this.cantHij = ch;
		}
		public string getOcupacion(){
			return this.ocupacion;
		}
		public void setOcupacion(string o){
			this.ocupacion = o;
		}
	}
}
