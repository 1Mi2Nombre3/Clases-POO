using System;
namespace EDIFICIO
{
	public class Telefono
	{
		// ATRIBUTOS
		private string numero;
		private string linea;
		
		// CONSTRUCTORES
		public Telefono()
		{
			this.numero = "";
			this.linea = "";
		}
		public Telefono(string n, string l){
			this.numero = n;
			this.linea = l;
		}
		// LEER Y MOSTRAR
		public void leerTe(){
			Console.WriteLine("==DATOS DEL TELEFONO==");
			Console.WriteLine("Numero: ");
			this.numero = Console.ReadLine();
			Console.WriteLine("Linea: ");
			this.linea = Console.ReadLine();
		}
		public void mostrarTe(){
			Console.WriteLine("==DATOS DEL TELEFONO==");
			Console.WriteLine("Num:"+this.numero+"-Linea:"+this.linea);
		}
		// GETTERS / SETTERS
		
		public string getNumero(){
			return this.numero;
		}
		public void setNumero(string n){
			this.numero = n;
		}
		public string getLinea(){
			return this.linea;
		}
		public void setLinea(string l){
			this.linea = l;
		}
		
	}
}
