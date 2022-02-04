using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ARCHIVOSPERSONA
{
	public class ArchivoPersona
	{
		// ATRIBUTOS
		private FileStream archi;
		private BinaryFormatter conversor;
		
		// CONSTRUCTORES
		public ArchivoPersona() // puede ser agregado o no, si quieres borralo
		{}
		
		public bool guardarPersona(Persona x){
			// Try Cath Funciona para agarrar errores
			try{
				this.archi = new FileStream("archivo.txt",FileMode.OpenOrCreate, FileAccess.Write);
				
				this.conversor = new BinaryFormatter();
				this.conversor.Serialize(this.archi, x);
				
				this.archi.Close();
				return true;
			}
			catch(Exception e){
				Console.WriteLine(e.Message);
				return false;
			}
		}
		public Persona recuperarPersona(){
			Persona z = null; // es igual que, z = new Persona();
			try{
				this.archi = new FileStream("archivo.txt",FileMode.Open, FileAccess.Read);
				this.conversor = new BinaryFormatter();
				z =(Persona)this.conversor.Deserialize(this.archi);
				
				this.archi.Close();
				return z;
			}
			catch(Exception e){
				Console.WriteLine(e.Message);
				return null;
			}
		}
	}
}
