using System;

namespace COMPUTADOR
{
	public class MemoriaPrincipal
	{
		private string capacidad;
		private string velocidadProcesado;
		
		public MemoriaPrincipal()
		{
			this.capacidad = "";
			this.velocidadProcesado = "";
		}
		public MemoriaPrincipal(string c, string vp){
			this.capacidad = c;
			this.velocidadProcesado = vp;
		}
		
		public void leer(){
			Console.WriteLine("Ingrese Capacidad: ");
			this.capacidad = Console.ReadLine();
			Console.WriteLine("Ingrese Velocidad de Procesado: ");
			this.velocidadProcesado = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("Capacidad:"+this.capacidad+"-Vel_Procesado:"+this.velocidadProcesado);
		}
		
		public string getCapacidad(){
			return this.capacidad;
		}
		public void setCapacidad(string c){
			this.capacidad = c;
		}
		public string getVelocidadProcesado(){
			return velocidadProcesado;
		}
		public void setvelocidadProcesado(string vp){
			this.velocidadProcesado = vp;
		}
		
		public void VerificaMemoria(MemoriaPrincipal a){
			if(this.velocidadProcesado.Equals(a.velocidadProcesado)){
				Console.WriteLine("Tienen la misma velocidad");
			}
			else{
				Console.WriteLine("No Tienen la misma velocidad");
			}
		}
	}
}
