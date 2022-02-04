using System;

namespace Vehiculo
{
	public class Vehiculo
	{
		// Atributos
		private string placa;
		private string marca;
		private int modelo;
		private string tipo;
		private string color;
		private int nroPuertas;
		
		// Metodos
		public Vehiculo()
		{
			this.placa = "";
			this.marca = "";
			this.modelo = 0;
			this.tipo = "";
			this.color = "";
			this.nroPuertas = 0;
		}
		
		public Vehiculo(String placa, String marca, int modelo, String tipo, String color, int nroPuertas)
		{
	        this.placa = placa;
	        this.marca = marca;
	        this.modelo = modelo;
	        this.tipo = tipo;
	        this.color = color;
	        this.nroPuertas = nroPuertas;
    	}
		
		public void leerVehiculo(){
			Console.WriteLine("PLACA: ");
			string p = Console.ReadLine();
			this.placa = p;
			
			Console.WriteLine("MARCA: ");
			this.marca = Console.ReadLine();
			
			Console.WriteLine("MODELO: ");
			this.modelo = int.Parse(Console.ReadLine());
			
			Console.WriteLine("TIPO");
			this.tipo = Console.ReadLine();
			
			Console.WriteLine("COLOR: ");
			this.color = Console.ReadLine();
			
			Console.WriteLine("NUMERO DE PUERTAS");
			this.nroPuertas = int.Parse(Console.ReadLine());
		}
		public void mostrarVehiculo(){
			Console.WriteLine("PLACA: "+this.placa);
			Console.WriteLine("MARCA: "+this.marca);
			Console.WriteLine("MODELO: "+this.modelo);
			Console.WriteLine("TIPO: "+this.tipo);
			Console.WriteLine("COLOR: "+this.color);
			Console.WriteLine("NUMERO DE PUERTAS: "+this.nroPuertas);
		}
		
		
		public string getPlaca() {
        	return placa;
    	}

	    public void setPlaca(string placa) {
	        this.placa = placa;
	    }
	
	    public string getMarca() {
	        return marca;
	    }
	
	    public void setMarca(string marca) {
	        this.marca = marca;
	    }
	
	    public int getModelo() {
	        return modelo;
	    }
	
	    public void setModelo(int modelo) {
	        this.modelo = modelo;
	    }
	
	    public string getTipo() {
	        return tipo;
	    }
	
	    public void setTipo(string tipo) {
	        this.tipo = tipo;
	    }
	
	    public string getColor() {
	        return color;
	    }
	
	    public void setColor(string color) {
	        this.color = color;
	    }
	
	    public int getNroPuertas() {
	        return nroPuertas;
	    }
	
	    public void setNroPuertas(int nroPuertas) {
	        this.nroPuertas = nroPuertas;
	    }
	}
}
