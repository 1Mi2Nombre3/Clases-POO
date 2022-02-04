using System;

namespace EDIFICIO
{
	public class A_Vivienda: Apartamento{
		// ATRIBUTOS
		private int numHab;
		private string tipo;
		
		// CONSTRUCTORES
		public A_Vivienda():base()
		{	
			this.numHab = 0;
			this.tipo = "";
		}
		public A_Vivienda(double tmc, double p, int nh, string t):base(tmc, p){
			this.numHab = nh;
			this.tipo = t;
		}
		
		// LEER Y MOSTRAR
		public void leerAv(){
			base.leerA();
			Console.WriteLine("==VIVIENDA==");
			Console.WriteLine("Ingrese NroHabitaciones: ");
			this.numHab = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese tipo de vivienda: ");
			this.tipo = Console.ReadLine();
		}
		public void mostrarAv(){
			base.mostrarA();
			Console.WriteLine("NroHabitaciones:"+this.numHab+"-Tipo Vivienda:"+this.tipo);
		}
		
		// GETTERS / SETTERS
		public int getNumHab(){
			return this.numHab;
		}
		public void setNumHab(int nh){
			this.numHab = nh;
		}
		public string getTipo(){
			return this.tipo;
		}
		public void setTipo(string t){
			this.tipo = t;
		}	
	}
}
