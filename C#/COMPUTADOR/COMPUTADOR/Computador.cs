using System;
namespace COMPUTADOR
{
	
	public class Computador
	{
		private string procesador;
		private string tarjetaGrafica;
		
		private int nmpri = 0;
		private int nmsec = 0;
		private MemoriaSecundaria[] ms;
		private MemoriaPrincipal[] mp = new MemoriaPrincipal[50];
		
		public Computador()
		{
			this.procesador = "";
			this.tarjetaGrafica = "";
			this.nmpri = 0;
			this.nmsec = 0;
		}
		public Computador(string p, string tg, int nm, MemoriaSecundaria[] a){
			this.procesador = p;
			this.tarjetaGrafica = tg;
			
			// MEMORIA PRINCIPAL
			this.nmpri = 3;
			MemoriaPrincipal x = new MemoriaPrincipal("8gb","575MHz");
			MemoriaPrincipal y = new MemoriaPrincipal("16gb","533MHz");
			MemoriaPrincipal z = new MemoriaPrincipal("4gb","600MHz");
			this.mp[0] = x;
			this.mp[1] = y;
			this.mp[2] = z;
			
			// MEMORIA SECUNDARIA
			this.nmsec = nm;
			this.ms = new MemoriaSecundaria[nmsec];
			for(int i=0 ; i<this.nmsec ; i++){
				MemoriaSecundaria aux = new MemoriaSecundaria();
				aux = a[i];
				this.ms[i] = aux;
			}
		
		}
		public void leerC(){
			Console.WriteLine("Ingrese Procesador: ");
			this.procesador = Console.ReadLine();
			Console.WriteLine("Ingrese Tarjeta Grafica: ");
			this.tarjetaGrafica = Console.ReadLine();
			Console.WriteLine("==DATOS DE MEMORIA PRINCIPAL==");
			Console.WriteLine("Numero de Memoria Principal(al menos 1): ");
			do{
				this.nmpri = int.Parse(Console.ReadLine());
			}while(this.nmpri <= 0);
			for(int i=0 ; i<this.nmpri ; i++){
				MemoriaPrincipal m1 = new MemoriaPrincipal();
				m1.leer();
				this.mp[i] = m1;
			}
			Console.WriteLine("==DATOS DE MEMORIA SECUNDARIA==");
			Console.WriteLine("Ingrese cantidad de memorias secundarias: ");
			this.nmsec = int.Parse(Console.ReadLine());
			ms = new MemoriaSecundaria[nmsec];
			for(int i=0 ; i<this.nmsec; i++){
				MemoriaSecundaria m2 = new MemoriaSecundaria();
				m2.leer();
				this.ms[i] = m2;
			}
		}
		public void mostrarC(){
			Console.WriteLine("Procesador:"+this.procesador+"-Tarjeta Grafica:"+this.tarjetaGrafica);
			Console.WriteLine("==DATOS DE MEMORIA PRINCIPAL==");
			for(int i=0 ; i<this.nmpri ;i++){
				this.mp[i].mostrar();
			}
			Console.WriteLine("==DATOS DE MEMORIA SECUNDARIA==");
			for(int i=0 ;i<this.nmsec ;i++){
				this.ms[i].mostrar();
			}
		}
		
		public string getProcesador(){
			return this.procesador;
		}
		public void setProcesador(string p){
			this.procesador = p; 
		}
		public string getTarjetaGrafica(){
			return this.tarjetaGrafica;
		}
		public void setTarjetaGrafica(string tg){
			this.tarjetaGrafica = tg;
		}
	}
}
