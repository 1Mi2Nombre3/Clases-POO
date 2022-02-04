using System;

namespace EDIFICIO
{
	public class Apartamento
	{
		// ATRIBUTOS
		private string tipoDepar;
		private double precio;
		private int cantR;
		private Residente[] res;  			 // Agregacion
		private Telefono t = new Telefono(); // Composicion
		private int cantM;
		private Mantenimiento[] man;         // Agregacion  
		
		// CONSTRUCTORES
		public Apartamento()
		{
			this.tipoDepar = "";
			this.precio = 0;
			this.cantR = 0;
			this.cantM = 0;
		}
		public Apartamento(string td, double p, Telefono t1){
			this.tipoDepar = td;
			this.precio = p;
			this.t = t1;
		}
		public Apartamento(string td, double p, int cr, Residente[] x, Telefono t1,int cm,Mantenimiento[] m){
			this.tipoDepar = td;
			this.precio = p;
			this.cantR = cr;
			if(x!=null){
				this.res = new Residente[this.cantR];
				for(int i=0; i<this.cantR ; i++){
					this.res[i] = x[i];
				}
			}
			if(this.cantR > 5){
				Console.WriteLine("Ingrese Numero de Residentes: (no mas de 5): ");
				do{
					this.cantR = int.Parse(Console.ReadLine());
				}while(this.cantR > 5);
			}
			this.t = t1;
			this.man = new Mantenimiento[5];
			this.cantM = cm;
			for(int i=0 ; i<this.cantM ; i++){
				man[i] = m[i];
			}
		}
		
		// LEER Y MOSTRAR
		public void leerA(){
			Console.WriteLine("==DATOS DE APARTAMENTO==");
			Console.WriteLine("Ingrese Tipo de Departamento: ");
			this.tipoDepar = Console.ReadLine();
			Console.WriteLine("Ingrese Precio Mensual: ");
			this.precio = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese Numero de Residentes: (no mas de 5): ");
			do{
				this.cantR = int.Parse(Console.ReadLine());
			}while(this.cantR > 5);
			
			res = new Residente[this.cantR];
			for(int i=0 ; i<this.cantR ; i++){
				Console.WriteLine("==RESIDENTE: " +(i+1)+" ==");
				Residente aux = new Residente();
				aux.leerR();
				res[i] = aux;
			}
			t.leerTe();
			Console.WriteLine("==MANTENIMIENTO==");
			this.man = new Mantenimiento[5];
			Console.WriteLine("Ingrear Cantidad de Mantenimiento: ");
			this.cantM = int.Parse(Console.ReadLine());
			for(int i=0 ; i<this.cantM ; i++){
				Console.WriteLine("==Mantenimiento "+(i+1)+" ==");
				Mantenimiento aux = new Mantenimiento();
				aux.leerMan();
				this.man[i] = aux;
			}
			
		}
		public void mostrarA(){
			Console.WriteLine("==DATOS DE APARTAMENTO==");
			Console.WriteLine("Tipo de Departamento:"+this.tipoDepar+"-Precio:"+this.precio);
			if(this.cantR != 0){
				for(int i=0 ; i<this.cantR ; i++){
					Console.WriteLine("==RESIDENTE: " +(i+1)+" ==");
					this.res[i].mostrarR();
				}	
			}
			t.mostrarTe();
			
			Console.WriteLine("==MANTENIMIENTO==");
			for(int i=0 ; i<this.cantM ; i++){
					Console.WriteLine("==MANTENIMIENTO: " +(i+1)+" ==");
					this.man[i].mostrarMan();
				}
		}
			
		// GETTERS / SETTERS
		public string getTipoDepar(){
			return this.tipoDepar;
		}
		public void setTipoDepar(string td){
			this.tipoDepar = td;
		}
		public double getPrecio(){
			return this.precio;
		}
		public void setPrecio(double p){
			this.precio = p;
		}
		public int getCanResidente(){
			return this.cantR;
		}
		public void setCanResidente(int cr){
			this.cantR = cr;
		}
		public Residente[] getResidente(){
			return this.res;
		}
		public void setResidente(Residente[] re){
			this.res = re;
		}
		public Telefono getTelefono(){
			return this.t;
		}
		public void setTelefono(Telefono te){
			this.t = te;
		}
		
		// METODOS
		public static Apartamento operator ++(Apartamento a){
			double r = a.precio;
			r = (r*5)/100;
			a.precio = a.precio + r;
			return a;
		}
	}
}
