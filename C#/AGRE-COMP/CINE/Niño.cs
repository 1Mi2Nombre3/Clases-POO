using System;

namespace CINE
{
	public class Niño: Cliente
	{
		// ATRIBUTOS
		private bool tutor;
		
		// CONSTRUCTORES
		public Niño():base()
		{
			this.tutor = false;
		}
		public Niño(string n, int e, bool t):base(n,e){
			this.tutor = t;
		}
		
		// LEER Y MOSTRAR
		public void leer(){
			base.leerCl();
			Console.WriteLine("Tutor: ");
			this.tutor = bool.Parse(Console.ReadLine());
		}
		public void mostrar(){
			base.mostrarCl();
			Console.WriteLine("Tutor:"+this.tutor);
		}
		
		// GETTERS / SETTERS
		public bool getTutor(){
			return this.tutor;
		}
		public void setTutor(bool t){
			this.tutor = t;
		}
	}
}
