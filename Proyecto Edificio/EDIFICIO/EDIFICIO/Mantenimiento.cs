using System;
namespace EDIFICIO
{
	public class Mantenimiento: Persona
	{
		// ATRIBUTOS
		private string tipo;
		private int experiencia;
		
		// CONSTRUCTORES
		public Mantenimiento():base(){
			this.tipo = "";
			this.experiencia = 0;
		}
		public Mantenimiento(string n,int e,string ced,string cel, string g, string es,string t, int ex):base(n,e,ced,cel,g,es){
			this.tipo = t;
			this.experiencia = ex;
		}
		// LEER Y PERSONA
		public void leerMan(){
			base.leerP();
			Console.WriteLine("Ingresar tipo:");
			this.tipo = Console.ReadLine();
			Console.WriteLine("Ingresar experiencia:");
			this.experiencia = int.Parse(Console.ReadLine());
		}
		public void mostrarMan(){
			base.mostrarP();
			Console.WriteLine("Tipo:"+this.tipo+"-Experiencia:"+this.experiencia);
		}
		
		// GETTERS / SETTERS
		public string getTipo(){
			return this.tipo;
		}
		public void setTipo(string t){
			this.tipo = t;
		}
		public int getExperiencia(){
			return this.experiencia;
		}
		public void setExperiencia(int ex){
			this.experiencia = ex;
		}
	}
}
