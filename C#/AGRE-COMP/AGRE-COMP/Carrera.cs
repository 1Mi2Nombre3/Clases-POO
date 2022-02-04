using System;

namespace AGRE_COMP
{
	public class Carrera
	{
		private string nom;
		private string area;
		
		public Carrera()
		{
			this.nom = "";
			this.area = "";
		}
		public Carrera(string n, string a){
			this.nom = n;
			this.area = a;
		}
		
		public void leer(){
			Console.WriteLine("Ingrese Nombre: ");
			Console.ReadLine();
			Console.WriteLine("Ingrese Area: ");
			Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("Nom:"+this.nom+"-Area:"+this.area);
		}
		
		public string getNom(){
			return this.nom;
		}
		public void setNom(string n){
			this.nom = n;
		}
		public string getArea(){
			return this.area;
		}
		public void setArea(string a){
			this.area = a;
		}
	}
}
