using System;

namespace FRACCION
{
	public class Fraccion
	{	
		// Atributos
		
		private int numerador;
		private int denominador;
		
		// Constructores
		
		public Fraccion()
		{
			this.numerador = 0;
			this.denominador = 1;
		}
		public Fraccion(int num, int den){
			this.numerador = num;
			if (den != 0){
				this.denominador = den;
			}
			else{
				Console.WriteLine("ERROR");
			}
		}
		// Getters and Setters
		public void mostrarFraccion(){
			Console.WriteLine(this.numerador +"/"+this.denominador);
		}
		
		public int getNum(){
			return this.numerador;
		}
		public void setNum(int num){
			this.numerador = num;
		}
		public int getDen(){
			return this.denominador;
		}
		public void setDen(int den){
			this.denominador = den;
		}
		// Sobrecarga Operadores
		
		public static Fraccion operator * (Fraccion f1, Fraccion f2){			
			Fraccion res = new Fraccion();
			res.numerador = f1.numerador*f2.numerador;
			res.denominador = f1.denominador*f2.denominador;
			return res;
		}
		
		public static Fraccion operator ++ (Fraccion f){
			f.numerador = f.numerador + 1;
			f.denominador++;
			return f;
		}
		public static Fraccion operator -- (Fraccion f){
			f.numerador = f.numerador - 1;
			f.denominador--;
			return f;
		}
		public static bool operator == (Fraccion f1, Fraccion f2){
			if(f1.numerador == f2.numerador && f1.denominador == f2.denominador){
				return true;
			}
			else{
				return false;
			}
		}
		public static bool operator != (Fraccion f1, Fraccion f2){
			if(f1.numerador != f2.numerador && f1.denominador != f2.denominador){
				return true;
			}
			else{
				return false;
			}
		}
		// Metodos
		
		public void leerFraccion(){
			Console.WriteLine("NUM: ");
			int x = this.numerador = int.Parse(Console.ReadLine());
			Console.WriteLine("DEN: ");
			this.denominador = int.Parse(Console.ReadLine());
			while(x==0){
				Console.WriteLine("DEN: ");
				x = this.denominador = int.Parse(Console.ReadLine());
			}
			this.denominador = x;
		}
		/*
		public void multiplicar(Fraccion a, Fraccion b){
			this.numerador = a.numerador * b.numerador;
			this.denominador = a.denominador * b.denominador;
		}
		*/
		
		
		
		
		
		
		
		
	}
}
