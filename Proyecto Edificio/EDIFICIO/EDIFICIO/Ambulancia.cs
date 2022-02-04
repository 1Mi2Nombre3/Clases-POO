using System;

namespace EDIFICIO
{
	public class Ambulancia
	{
		// ATRIBUTOS
		private string velocidad;
		private string color;
		
		// CONSTRCUTORES		
		public Ambulancia()
		{
			this.velocidad = "";
			this.color = "";
		}
		public Ambulancia(string v, string c){
			this.velocidad = v;
			this.color = c;
		}
		
		// LEER Y MOSTRAR
		public void leerAm(){
			Console.WriteLine("==AMBULACIA==");
			Console.WriteLine("Ingrese Velocidad: ");
			this.velocidad = Console.ReadLine();
			Console.WriteLine("Ingrese Color: ");
			this.color = Console.ReadLine();
		}
		public void mostrarAm(){
			Console.WriteLine("==AMBULACIA==");
			Console.WriteLine("Velocidad:"+this.velocidad+"-Color:"+this.color);
		}
		
		// GETTERS / SETTERS
		public string getVelocidad(){
			return this.velocidad;
		}
		public void setVelocidad(string v){
			this.velocidad = v;
		}
		public string getColor(){
			return this.color;
		}
		public void setColor(string c){
			this.color = c;
		}
	}
	
}
