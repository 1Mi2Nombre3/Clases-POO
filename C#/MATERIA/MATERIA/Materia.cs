using System;

namespace MATERIA
{
	public class Materia
	{
		// ATRIBUTOS
		private string sigla;
		private string nom;
		private string paralelo;
		private int n;
		private string[] est = new string[100];
		
		// CONSTRUCTORES
		public Materia()
		{
			this.sigla = "";
			this.nom = "";
			this.paralelo = "";
			this.n = 0;
		}
		public Materia(string s){
			this.sigla = s;
			this.nom = "";
			this.paralelo = "";
			this.n = 0;
		}
		public Materia(string s, string nom){
			this.sigla = s;
			this.nom = nom;
			this.paralelo = "";
			this.n = 0;
		}
		public Materia(string s, string nom, string p, int n){
			this.sigla = s;
			this.nom = nom;
			this.paralelo = p;
			this.n = n;
			// esto si inicializa datos del vector;
			for(int i=0 ; i<this.n ; i++){
				Console.WriteLine("Ingrese Nombre de estudiante: "+ (i+1));
				this.est[i] = Console.ReadLine();
			}
		}
		public Materia(string s, string nom, string p, int n, string[] a){
			this.sigla = s;
			this.nom = nom;
			this.paralelo = p;
			this.n = n;
			for(int i=0 ; i<this.n ; i++){
				this.est[i] = a[i];
			}
		}
		
		//LEER Y MOSTRAR
		
		public void leeMateria(){
			Console.WriteLine("Ingrese sigla: ");
			this.sigla = Console.ReadLine();
			
			Console.WriteLine("Ingrese nombre de materia: ");
			this.nom = Console.ReadLine();
			
			Console.WriteLine("Ingrese paralelo: ");
			this.paralelo = Console.ReadLine();
			
			Console.WriteLine("Ingrese numero de estudiantes: ");
			this.n = int.Parse(Console.ReadLine());
			
			Console.WriteLine("ingrese los nombres de estudiantes");
			for(int i=0 ; i<this.n ; i++){
				Console.WriteLine("Estudiante: " + i +" :");
				Console.ReadLine();
			}
			
		}
		public void mostrarMateria(){
			Console.WriteLine("SIGLA: "+this.sigla);
			Console.WriteLine("NOMBRE DE MATERIA: " + this.nom);
			Console.WriteLine("PARALELO: " + this.paralelo);
			Console.WriteLine("CANTIDAD DE ESTUDIANTES: " + this.n);
			for(int i =0 ; i<this.n ;i++){
				Console.WriteLine(this.est[i]);
			}
		}
		// SETTERS AND GETTERS
		
		public string getSigla(){
			return this.sigla;
		}
		public void setSigla(String s){
			this.sigla = s;
		}
		
		public string getNom(){
			return this.nom;
		}
		public void setNom(String n){
			this.nom = n;
		}
		
		public string getParalelo(){
			return this.paralelo;
		}
		public void setPlaca(String p){
			this.paralelo = p;
		}
		
		public int getN(){
			return this.n;
		}
		public void setN(int n){
			this.n = n;
		}
		
		// para vector porque return no puede retornar un conjunto de datos
		
		public string getEst(int i){
			return this.est[i];
		}
		public void setEst(int i, string x){
			this.est[i] = x;
		}
		
		// METODOS
		
		public void adicionarEst(string est){
			
		}
		public void adicionarEst(string est, int i){
			
		}
		
		public void sumarMateria(){
			
		}
		public Materia sumarMateria(Materia a, Materia b){
				
		}
	}	
}













