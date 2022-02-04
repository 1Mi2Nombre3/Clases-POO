
using System;

namespace AGRE_COMP
{
	public class Universidad
	{
		private string nom;
		private string dpto;
		private int fund;
		private int nc;
		private int ne;
		private Estudiante[] est;  				  // agregacion
		private Carrera[] car = new Carrera[50];  // Composicion(Obligatorio)
		
		public Universidad()
		{
			this.nom = "";
			this.dpto = "";
			this.fund = 0;
			this.nc = 0;
			this.ne = 0;
		}
		public Universidad(string n, string d, int f, int ne,  Estudiante[] e){
			this.nom = n;
			this.dpto = d;
			this.fund = f;
			this.nc = 3;
			this.ne = ne;
			
			// COMPOSICION 
			Carrera x = new Carrera("Medicima","Salud");
			Carrera y = new Carrera("Medicima","Puras");
			Carrera z = new Carrera("Medicima","Tecnica");
			this.car[0] = x;
			this.car[1] = y;
			this.car[2] = z;
			
			// AGREGACION
			this.est = new Estudiante[ne];
			this.ne = ne;
			for(int i=0 ; i<this.ne ; i++){
				Estudiante aux = new Estudiante();
				aux = e[i];
				this.est[i] = aux;
			}
		}
		public void leerU(){
			Console.WriteLine("Ingrese Nombre de Universidad: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingrese Departamento: ");
			this.dpto = Console.ReadLine();
			Console.WriteLine("Ingrese Fundacion: ");
			this.fund = int.Parse(Console.ReadLine());
			
			Console.WriteLine("DATOS DE CARRERRAS");
			Console.WriteLine("Cuantas carreras(al menos 1): ");
			do{
				this.nc = int.Parse(Console.ReadLine());	
			}while(nc <= 0);
			for(int i=0 ; i<this.nc ;i++){
				Carrera x = new Carrera();
				x.leer();
				this.car[i] = x;
			}
			Console.WriteLine("DATOS DE ESTUDIANTES");
			Console.WriteLine("Cuantos estudiantes: ");
			this.ne = int.Parse(Console.ReadLine());
			this.est = new Estudiante[this.ne];
			for(int i=0; i<this.ne ;i++){
				Estudiante y = new Estudiante();
				y.leer();
				this.est[i] = y;
			}
		}
		public void mostrarU(){
			Console.WriteLine("NOM:"+this.nom+"-DPTO:"+this.dpto+"-FUND:"+this.fund);
			Console.WriteLine("==DATOS DE CARRERAS==");
			for(int i=0; i<this.nc ;i++){
				this.car[i].mostrar();
			}
			Console.WriteLine("==DATOS DE ESTUDIANTES==");
			for(int i=0 ; i<this.ne ;i++){
				this.est[i].mostrar();
			}
		}
	}
}
