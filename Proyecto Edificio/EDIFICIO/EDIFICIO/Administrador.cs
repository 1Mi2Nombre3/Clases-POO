using System;
namespace EDIFICIO
{
	public class Administrador: Persona
	{
		// ATRIBUTOS
		private string universidad;
		private int permanencia;
		private double sueldo;
		private Conserje con; // ASOCIASION
		private int cantMed;
		private Medico[] m;  // ASOCIASION
		private int canMan;
		private Mantenimiento[] man; // ASOCIASION
		
		
		// CONSTRUCTORES
		public Administrador():base()
		{
			this.universidad = "";
			this.permanencia = 0;
			this.sueldo = 0;
			this.cantMed = 0;
			this.canMan = 0;
		}
		public Administrador(string n, int e, string ced, string cel, string g, string es,string u, int p, double s):base(n,e,ced,cel,g,es){
			this.universidad = u;
			this.permanencia = p;
			this.sueldo = s;
		}
		public Administrador(string n, int e, string ced, string cel, string g, string es,string u, int p, double s, Conserje c, int cm ,Medico[] med, int cman, Mantenimiento[]ma):base(n,e,ced,cel,g,es){
			this.universidad = u;
			this.permanencia = p;
			this.sueldo = s;
			if(c!=null){
				this.con = c;
			}
			if(ma != null){
				this.m = new Medico[5];
				this.cantMed = cm;
				for(int i=0 ; i<this.cantMed ; i++){
					this.m[i] = med[i];
				}
			}
			if(ma != null){
				this.man = new Mantenimiento[5];
				this.canMan = cman;
				for(int i=0 ; i<this.canMan; i++){
					this.man[i] = ma[i];
				}
			}
		}
		
		// LEER Y MOTRAR
		public void leerADM(){
			Console.WriteLine("==ADMINISTRADOR==");
			base.leerP();
			Console.WriteLine("Ingrese Universidad:");
			this.universidad = Console.ReadLine();
			Console.WriteLine("Ingrese Permanencia en Edificio: ");
			this.permanencia = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese sueldo Mensual: ");
			this.sueldo = double.Parse(Console.ReadLine());
			con = new Conserje();
			this.con.leerC();
			Console.WriteLine("==MEDICO==");
			Console.WriteLine("Ingrese Cantidad Medicos:");
			this.cantMed = int.Parse(Console.ReadLine());
			this.m = new Medico[this.cantMed];
			for(int i=0 ; i<this.cantMed ; i++){
				Medico aux = new Medico();
				aux.leerM();
				this.m[i] = aux;
			}
			Console.WriteLine("Ingrese Cantidad Mantenimiento: ");
			this.canMan = int.Parse(Console.ReadLine());
			man = new Mantenimiento[this.canMan];
			for(int i=0 ; i<this.canMan ; i++){
				Mantenimiento aux = new Mantenimiento();
				aux.leerMan();
				man[i] = aux;
			}
		}
		public void mostrarADMs(){
			Console.WriteLine("====ADMINISTRADOR====");
			base.mostrarP();
			Console.WriteLine("Universidad:"+this.universidad+"-Permanencia en Edificio:"+this.permanencia+"-Sueldo Mensual:"+this.sueldo);
		}
		public void mostrarADM(){
			Console.WriteLine("====ADMINISTRADOR====");
			base.mostrarP();
			Console.WriteLine("Universidad:"+this.universidad+"-Permanencia en Edificio:"+this.permanencia+"-Sueldo Mensual:"+this.sueldo);
			con.mostrarC();
			Console.WriteLine("==MEDICO==");
			for(int i=0 ; i<this.cantMed ; i++){
				Console.WriteLine("==MEDICO "+(i+1)+" ==");
				this.m[i].mostrarM();
			}
			Console.WriteLine("==MANTENIMIENTO==");
			for(int i=0 ; i<this.canMan ; i++){
				Console.WriteLine("==MANTENIMIENTO "+(i+1)+" ==");
				this.man[i].mostrarMan();
			}
		}
		// GETTERS / SETTERS
		
		public string getUniversidad(){
			return this.universidad;
		}
		public void setUniversidad(string u){
			this.universidad = u;
		}
		public int getPermanencia(){
			return this.permanencia;
		}
		public void setPermanencia(int p){
			this.permanencia = p;
		}
		public double getSueldo(){
			return this.sueldo;
		}
		public void setSueldo(double s){
			this.sueldo = s;
		}
		public Conserje getConserje(){
			return this.con;
		}
		public void setConserje(Conserje c){
			this.con = c;
		}
		public Medico[] getMedico(){
			return this.m;
		}
		public void setMedico(Medico[] med){
			this.m = med;
		}
		public Mantenimiento[] getMantenimiento(){
			return this.man;
		}
		public void setMantenimiento(Mantenimiento[] m){
			this.man = m;
		}
	}
}
