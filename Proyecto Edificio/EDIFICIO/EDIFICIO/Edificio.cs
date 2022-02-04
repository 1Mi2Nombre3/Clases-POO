using System;

namespace EDIFICIO
{
	public class Edificio
	{
		// ATRIBUTOS
		private string nom;
		private string tipo;
		private string direc;
		private string estruc;
		private int edifc;
		private int nrApartamento;
		private Apartamento[] apar = new Apartamento[100];    // Composicion
		private Administrador admin;			              // Agregacioón
		
		// CONSTRUCTORES
		public Edificio()
		{
			this.nom = "";
			this.tipo = "";
			this.direc = "";
			this.estruc = "";
			this.edifc = 0;
			this.nrApartamento = 1;
			this.admin = new Administrador();
		}
		public Edificio(string n, string t, string d, string es, int ed,int nrA, Apartamento[] a, Administrador ad){
			this.nom = n;
			this.tipo = t;
			this.direc = d;
			this.estruc = es;
			this.edifc = ed;
			this.nrApartamento = nrA;
			this.admin = new Administrador(); 
			this.admin = ad;
			if(this.nrApartamento != 0){
				for(int i=0 ; i<this.nrApartamento ;i++){
					this.apar[i] = a[i];
				}
			}
		}
		
		// LEER Y MOSTRAR
		public void leerE(){
			Console.WriteLine("=====DATOS DEL EDIFICIO=====");
			Console.WriteLine("Ingresar Nombre: ");
			this.nom = Console.ReadLine();
			Console.WriteLine("Ingresar Tipo: ");
			this.tipo = Console.ReadLine();
			Console.WriteLine("Ingresar Direccion: ");
			this.direc = Console.ReadLine();
			Console.WriteLine("Ingresar Estructura: ");
			this.estruc = Console.ReadLine();
			Console.WriteLine("Ingresar Edificacion: ");
			this.edifc = int.Parse(Console.ReadLine());
			
			this.admin = new Administrador(); 
			this.admin.leerADM();
			
			Console.WriteLine("Ingresar Nro.Apartamentos(al menos 1): ");
			do{
				this.nrApartamento = int.Parse(Console.ReadLine());
			}while(this.nrApartamento < 1);
			
			for(int i=0 ; i<this.nrApartamento ; i++){
				Console.WriteLine("==APARTAMENTO: " +(i+1)+" ==");
				Apartamento aux = new Apartamento();
				aux.leerA();
				this.apar[i] = aux;
			}
		}
		public void mostrarE(){
			Console.WriteLine("=====DATOS DEL EDIFICIO=====");
			Console.WriteLine("Nom:"+this.nom+"-Tipo:"+this.tipo+"-Dirección:"+this.direc+"-Estructura:"+this.estruc+"-Edificación:"+this.edifc);
			this.admin.mostrarADM();
			for(int i=0 ; i<this.nrApartamento ;i++){
				Console.WriteLine("==APARTAMENTO: "+(i+1)+" ==");
				this.apar[i].mostrarA();
			}
		}

		
		
		// GETTERS / SETTERS
		public string getNom(){
			return this.nom;
		}
		public void setNom(string n){
			this.nom = n;
		}
		public string getTipo(){
			return this.tipo;
		}
		public void setTipo(string t){
			this.tipo = t;
		}
		public string getDirec(){
			return this.direc;
		}
		public void setDirec(string d){
			this.direc = d;
		}
		public string getEstruc(){
			return this.estruc;
		}
		public void setEstruc(string es){
			this.estruc = es;
		}
		public int getEdific(){
			return this.edifc;
		}
		public void setEdific(int ed){
			this.edifc = ed;
		}
		public Apartamento[] getApartamento(){
			return this.apar;
		}
		public void setApartamento(Apartamento[] a){
			this.apar = a;
		}
		public Administrador getPersonal(){
			return this.admin;
		}
		public void setPersonal(Administrador ad){
			this.admin = ad;
		}
	}
}
















