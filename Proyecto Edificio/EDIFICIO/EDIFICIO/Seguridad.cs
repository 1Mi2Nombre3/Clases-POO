using System;
namespace EDIFICIO
{
	public class Seguridad: Persona
	{
		// ATRIBUTOS
		private string tipoArma;
		private string nomArma;
		
		// CONSTRUCTORES
		public Seguridad():base()
		{
			this.tipoArma = "";
		}
		public Seguridad(string n, int e, string ced, string cel, string g, string es,int tt, double s,string ta,string na):base(n,e,ced,cel,g,es){
			this.nom = n;
			this.edad = e;
			this.cedula = ced;
			this.celular = cel;
			this.genero = g;
			this.estadoCivil = es;
			this.tipoArma = ta;
			this.nomArma = na;
		}
		
		// LEER Y MOSTRAR
		public void leerS(){
			Console.WriteLine("==SEGURIDAD==");
			Console.WriteLine("Ingrese Tipo de Arma: ");
			this.tipoArma = Console.ReadLine();
			Console.WriteLine("Ingrese Nombre de Arma");
			this.nomArma = Console.ReadLine();
		}
		public void mostrarS(){
			Console.WriteLine("==SEGURIDAD==");
			Console.WriteLine("Tipo de Arma:"+this.tipoArma+"-Nombre de Arma:"+this.nomArma);
		}
		
		// GETTERS / SETTERS
		public string getTipoArma(){
			return this.tipoArma;
		}
		public void setTipoArma(string ta){
			this.tipoArma = ta;
		}
		public string getNomArma(){
			return this.nomArma;
		}
		public void setNomArma(string na){
			this.nomArma = na;
		}
	}
}
