using System;

namespace MASCOTA_H
{
	public class Pez: Mascota
	{
		// ATRIBUTOS
		private string tipo;
		private string tipoAgua;
		
		// CONSTRUCTORES
		public Pez():base()
		{
			this.tipo = "";
			this.tipoAgua = "";
		}
		public Pez(string n, int e, string c, string t, string ta):base(n,e,c){
			this.tipo = t;
			this.tipoAgua = ta;
		}
		
		// LEER Y MOSTRAR
		public void leer(){
			base.leerM();
			Console.WriteLine("Ingrese el tipo: ");
			this.tipo = Console.ReadLine();
			Console.WriteLine("Ingrese eñ tipo de Agua: ");
			this.tipoAgua = Console.ReadLine();
		}
		public void mostrar(){
			base.mostrarM();
			Console.WriteLine("Tipo:"+this.tipo+"-Tipo de Agua:"+this.tipoAgua);
		}
		
		// GETTERS / SETTERS
		public string getTipo(){
			return this.tipo;
		}
		public void setTipo(string t){
			this.tipo = t;
		}
		public string getTipoAgua(){
			return this.tipoAgua;
		}
		public void setTipoAgua(string ta){
			this.tipoAgua = ta;
		}
	}
}
