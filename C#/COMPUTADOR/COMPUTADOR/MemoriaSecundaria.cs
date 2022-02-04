using System;
namespace COMPUTADOR
{
	public class MemoriaSecundaria
	{
		private string marca;
		private string velocidadTransferencia;
		
		public MemoriaSecundaria()
		{
			this.marca = "";
			this.velocidadTransferencia = "";
		}
		public MemoriaSecundaria(string m, string vt){
			this.marca = m;
			this.velocidadTransferencia = vt;
		}
		
		public void leer(){
			Console.WriteLine("Ingrese Marca: ");
			this.marca = Console.ReadLine();
			Console.WriteLine("Ingrese la Velocidad Transferencia: ");
			this.velocidadTransferencia = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("Marca:"+this.marca+"-Velocidad Transferencia:"+this.velocidadTransferencia);
		}
		
		public string getMarca(){
			return this.marca;
		}
		public void setMarca(string m){
			this.marca = m;
		}
		public string getVelocidadTransferencia(){
			return this.velocidadTransferencia;
		}
		public void setVelocidadTransferencia(string vt){
			this.velocidadTransferencia = vt;
		}
	}
}
