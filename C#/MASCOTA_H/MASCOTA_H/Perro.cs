using System;

namespace MASCOTA_H
{

	public class Perro: Mascota
	{
		// ATRIBUTOS
		private string raza;
		private bool pedigree;
		
		// CONSTRUCTORES
		public Perro():base()
		{
			this.raza = "";
			this.pedigree = false;
		}
		public Perro(string n, int e, string c,string r, bool p):base(n,e,c){
			this.raza = r;
			this.pedigree = p;
		}
		// LEER Y MOSTRAR
		
		public void leer(){
			base.leerM();
			Console.WriteLine("Ingrese Raza: ");
			this.raza = Console.ReadLine();
			Console.WriteLine("Ingrese Pedigree: ");
			this.pedigree = bool.Parse(Console.ReadLine());
		}
		public void mostrar(){
			base.mostrarM();
			Console.WriteLine("Raza:"+this.raza +"-Pedigree:"+this.pedigree);
		}
		// GETTERS / SETTERS
		
		public String getRaza(){
			return this.raza;
		}
		public void setRaza(string r){
			this.raza = r;
		}
		
		public bool getPedigree(){
			return this.pedigree;
		}
		public void setPedigree(bool p){
			this.pedigree = p;
		}
	}
}
