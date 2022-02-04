using System;

namespace Empleado
{
	public class Empleado
	{
		// ATRIBUTOS
		
		private string cedula;
		private string nombre;
		private string direccion;
		private string genero;
		private double sueldoBasico;
		private int antiguedad;
		
		// ATRIBUTOS PARA VECTOR
		
		private int cantidadEmpleados;
		private String [] cedula1 = new string[50];
		private String [] nombre1 = new string[50];
		private String [] direccion1 = new string[50];
		private String [] genero1 = new string[50];
		private double [] sueldoBasico1 = new double[50];
		private int [] antiguedad1 = new int[50];
		
		// CONSTRUCTORES
		
		public Empleado(){
			this.cedula = "";
			this.nombre = "";
			this.direccion = "";
			this.genero = "";
			this.sueldoBasico = 0;
			this.antiguedad = 0;
		}
		public Empleado(string c, string n, string d, string g, double sb, int a){
			this.cedula = c;
			this.nombre = n;
			this.direccion = d;
			this.genero = g;
			this.sueldoBasico = sb;
			this.antiguedad = a;
		}
		
		public Empleado(int ce){
			this.cantidadEmpleados = ce;
			for(int i=0 ; i<ce ; i++){
				Console.WriteLine("===Empleado: "+(i+1)+"====");
				Console.WriteLine("Ingresar cedula: ");
				this.cedula1[i] = Console.ReadLine();
				Console.WriteLine("Ingresar nombre: ");
				this.nombre1[i] = Console.ReadLine();
				Console.WriteLine("Ingresar direccion: ");
				this.direccion1[i] = Console.ReadLine();
				Console.WriteLine("Ingresar genero: ");
				this.genero1[i] = Console.ReadLine();
				Console.WriteLine("Ingresar sueldo basico: ");
				this.sueldoBasico1[i] = double.Parse(Console.ReadLine());
				Console.WriteLine("Ingresar antiguedad: ");
				this.antiguedad1[i] = int.Parse(Console.ReadLine());
			}
		}
		
		// LEER Y MOSTRAR
		
		public void leerEmpleado(){
			Console.WriteLine("Ingresar cedula: ");
			this.cedula = Console.ReadLine();
			Console.WriteLine("Ingresar nombre: ");
			this.nombre = Console.ReadLine();
			Console.WriteLine("Ingresar direccion: ");
			this.direccion = Console.ReadLine();
			Console.WriteLine("Ingresar genero: ");
			this.genero = Console.ReadLine();
			Console.WriteLine("Ingresar sueldo basico: ");
			this.sueldoBasico = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingresar antiguedad: ");
			this.antiguedad = int.Parse(Console.ReadLine());
		}
		public void mostrarEmpleado(){
			Console.WriteLine("Cedula: "+this.cedula);
			Console.WriteLine("Nombre: "+this.nombre);
			Console.WriteLine("Direccion: "+this.direccion);
			Console.WriteLine("Genero: "+this.genero);
			Console.WriteLine("Suelda Basico: "+this.sueldoBasico);
			Console.WriteLine("Antiguedad: "+this.antiguedad);
		}
		public void mostrarEmpleado(int ce){
			for(int i=0 ; i<this.cantidadEmpleados ; i++){
				Console.WriteLine("===Empleado: "+(i+1)+"====");
				Console.WriteLine("Cedula: "+this.cedula1[i]);
				Console.WriteLine("Nombre: "+this.nombre1[i]);
				Console.WriteLine("Direccion: "+this.direccion1[i]);
				Console.WriteLine("Genero: "+this.genero1[i]);
				Console.WriteLine("Suelda Basico: "+this.sueldoBasico1[i]);
				Console.WriteLine("Antiguedad: "+this.antiguedad1[i]);
			}
		}
		
		// GETTERS AND SETTERS
		
		public string getCedula(){
			return this.cedula;
		}
		public void setCedula(String c){
			this.cedula = c;
		}
		
		public string getNombre(){
			return this.nombre;
		}
		public void setNombre(String n){
			this.nombre = n;
		}
		
		public string getDireccion(){
			return this.direccion;
		}
		public void setDireccion(String d){
			this.direccion = d;
		}
		
		public string getGenero(){
			return this.genero;
		}
		public void setGenero(String g){
			this.genero = g;
		}
		
		public double getSueldaBasico(){
			return this.sueldoBasico;
		}
		public void setSueldoBasico(double sb){
			this.sueldoBasico = sb;
		}
		
		public int getAntiguedad(){
			return this.antiguedad;
		}
		public void setAntiguedad(int a){
			this.antiguedad = a;
		}
		
		//SOBRECARGA DE OPERADORES
		
		public static Empleado operator ++(Empleado a)
		{
			double extra = 0;
			extra = (a.sueldoBasico * 5) / 100;
			a.sueldoBasico = a.sueldoBasico + extra;
			return a;
		}
		
		public static Empleado operator *(Empleado a, Empleado b){
			double extra = 0;
			if(a.antiguedad > 5){
				extra = (a.sueldoBasico*10) / 100;
				a.sueldoBasico = a.sueldoBasico + extra;
			}
			else{
				a.sueldoBasico = a.sueldoBasico + extra;
			}
			extra = 0;
			if(b.antiguedad > 5){
				extra = (b.sueldoBasico*10) / 100;
				b.sueldoBasico = b.sueldoBasico + extra;
			}
			else{
				b.sueldoBasico = b.sueldoBasico + extra;
			}
			Console.WriteLine("Liquido pagable de: "+a.nombre+" es de: "+a.sueldoBasico);
			Console.WriteLine("Liquido pagable de: "+b.nombre+" es de: "+b.sueldoBasico);
			
			return a;
		}
		
		// METODOS
		
		public void buscarEmpleado(){
			Console.WriteLine("Ingresar el nombre: ");
			string x = Console.ReadLine();
			for(int i=0 ; i<this.cantidadEmpleados ; i++){
				if(x.Equals(this.nombre1[i])){
					Console.WriteLine("Empleado:"+(i+1)+" "+this.nombre1[i]+", "+this.cedula1[i]+", "+this.direccion1[i]+", "+this.genero1[i]+", "+this.sueldoBasico1[i]+", "+this.antiguedad1[i]);
				}
			}
		}
		public double pagaTotal(){
			double s=0;
			for(int i=0 ; i<this.cantidadEmpleados ; i++){
				s = s + this.sueldoBasico1[i];
			}
			return s;
		}
	}
}
