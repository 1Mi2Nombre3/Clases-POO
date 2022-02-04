using System;
namespace EDIFICIO
{
	public class Medico: Persona
	{		
		// ATRIBUTOS
		private string especialidad;
		private int cam;
		private Ambulancia []am;  // ASOCIASION
		
		// CONSTRUCTORES
		public Medico():base()
		{
			this.especialidad = "";
			this.cam = 0;
		}
		public Medico(string n, int e, string ced, string cel, string g, string es,string esp,int c, Ambulancia[] a):base(n,e,ced,cel,g,es){
			this.nom = n;
			this.edad = e;
			this.cedula = ced;
			this.celular = cel;
			this.genero = g;
			this.estadoCivil = es;
			this.especialidad = esp;
			
			this.cam = c;
			if(a != null)
				this.am = a;
		}
		// LEER Y MOSTRAR
		public void leerM(){
				
			base.leerP();
			Console.WriteLine("Ingresar Especialidad: ");
			this.especialidad = Console.ReadLine();
			Console.WriteLine("Ingrese Cantidad Ambulancias");
			this.cam = int.Parse(Console.ReadLine());
			am = new Ambulancia[5];
			for(int i=0 ; i<this.cam ; i++){
				Ambulancia aux = new Ambulancia();
				aux.leerAm();
				this.am[i] = aux;
			}
		}
		public void mostrarM(){
			base.mostrarP();
			Console.WriteLine("Especialidad:"+this.especialidad+"-Cantidad Ambulancias:"+this.cam);
			for(int i=0 ; i<this.cam ; i++){
				this.am[i].mostrarAm();
			}
		}
		
		// GETTERS / SETTERS
		public string getEspecialidad(){
			return this.especialidad;
		}
		public void setEspecialidad(string e){
			this.especialidad = e;
		}
		public int getCam(){
			return this.cam;
		}
		public void setCam(int ca){
			this.cam = ca;
		}
		public Ambulancia[] getAmbulancia(){
			return this.am;
		}
		public void setAmbulancia(Ambulancia[] a){
			this.am = a;
		}
	}
	
}
