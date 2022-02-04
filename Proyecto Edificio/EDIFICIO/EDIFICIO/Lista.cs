using System;
namespace EDIFICIO
{
	public class Lista
	{
		// ATRIBUTOS
		private static int nrRes;
		private Residente[] x = new Residente[100];   // Composicion
		
		// CONSTRUCTORES
		public Lista(){
			x = new Residente[100];
		}
		public Lista(int n, Residente[] r){
			for(int i=0 ; i<n ;i++){
				x[nrRes] = r[i];
				nrRes++;
			}
		}
		
		// LEER Y MOSTRAR
		public void leerL(){
			Console.WriteLine("==LISTA==");
			Console.WriteLine("Ingrese Numero de Residentes: ");
			int n = int.Parse(Console.ReadLine());
			Residente [] aux = new Residente[100];
			for(int i=0 ; i<n ; i++){
				Console.WriteLine("==RESIDENTE "+(i+1)+" ==");
				Residente aux1 = new Residente();
				aux1.leerR();
				aux[i] = aux1;
				x[nrRes] = aux[i];
				nrRes++;
			}
		}
		public void mostrarL(){
			Console.WriteLine("==LISTA==");
			for(int i=0 ; i<nrRes ;i++){
				Console.WriteLine("==RESIDENTE "+(i+1)+" ==");
				x[i].mostrarR();
			}
		}
		
		// GETTERS / SETTERS
		public Residente[] getResidente(){
			return this.x;
		}
		public void setResidente(Residente[] res){
			this.x = res;
		}
		
		// METODOS
		public void agregResid(int n, Residente[] res){
			for(int i=0 ; i<n ;i++){
				x[nrRes] = res[i];
				nrRes++;
			}
		}
		public void agregResid(Apartamento a){ // Agregar a la lista los Residentes del Apartamento
			int n = a.getCanResidente();
			Residente[] r = a.getResidente();
			for(int i=0; i<n ;i++){
				x[nrRes] = r[i];
				nrRes++;
			}
		}
		public void borrarResidU(){
			nrRes--;
		}
	}
}