using System;
namespace EDIFICIO
{
	public class Conserje: Persona
	{
		// ATRIBUTOS 
		private string calificacion;
		private int promRegisMen;
		private int promSalidMen;
		private Lista lis;
		
		// CONSTRUCTORES
		public Conserje():base()
		{
			this.calificacion = "";
			this.promRegisMen = 0;
			this.promSalidMen = 0;
			lis = new Lista();
		}
		public Conserje(string n,int e,string ced,string cel, string g,string es,string cal, int prm, int psm, Lista l):base(n,e,ced,cel,g,es){
			this.nom = n;
			this.edad = e;
			this.cedula = ced;
			this.celular = cel;
			this.genero = g;
			this.estadoCivil = es;
			this.calificacion = cal;
			this.promRegisMen = prm;
			this.promSalidMen = psm;
			lis = new Lista();
			this.lis = l;
		}
		// LEER Y MOSTRAR
		public void leerC(){
			Console.WriteLine("==CONSERJE==");
			base.leerP();
			Console.WriteLine("Ingrese Calificación: ");
			this.calificacion = Console.ReadLine();
			Console.WriteLine("Ingrese Promedio de Registro Mensual: ");
			this.promRegisMen = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese Promedio de Salida Mensual: ");
			this.promSalidMen = int.Parse(Console.ReadLine());
			lis = new Lista();
			this.lis.leerL();
		}
		public void mostrarC(){
			Console.WriteLine("==CONSERJE==");
			base.mostrarP();
			Console.WriteLine("Calificación:"+this.calificacion+"-PromedioRegistroMensual:"+this.promRegisMen+"-PromedioSalidad Mensual"+this.promSalidMen);
			this.lis.mostrarL();
		}
		
		// GETTERS / SETTERS
		public string getCalificacion(){
			return this.calificacion;
		}
		public void setCalificacion(string at){
			this.calificacion = at;
		}
		public int getPromRegisMens(){
			return this.promRegisMen;
		}
		public void setPromSalidMens(int psm){
			this.promSalidMen = psm;
		}
		public Lista getLista(){
			return this.lis;
		}
		public void setLista(Lista l){
			this.lis = l;
		}
		
	}
}
