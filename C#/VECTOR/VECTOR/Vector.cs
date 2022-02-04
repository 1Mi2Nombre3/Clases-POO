using System;

namespace VECTOR
{
	public class Vector
	{
		// ATRIBUTOS
		private int n;
		private int[] vec = new int[50];
		
		// CONSTRUCTORES
		
		public Vector(){
			this.n = 0;
		}
		public Vector(int n){
			this.n = n;
			for(int i=0 ; i<n ; i++){
				Console.WriteLine("Ingrese elem " + (i+1));
				this.vec[i] = int.Parse(Console.ReadLine());
			}
		}
		public Vector(int n, int[] x){
			this.n = n;
			for(int i=0 ; i < n ; i++){
				this.vec[i] = x[i];
			}
		}
		// LEER Y MOSTRAR
		
		public void leerV(){
			Console.WriteLine("Ingrese N: ");
			this.n = int.Parse(Console.ReadLine());
			for(int i=0 ; i < n ; i++){
				Console.WriteLine("elem: " + (i+1));
				this.vec[i] = int.Parse(Console.ReadLine());
			}
		}
		public void mostrarV(){
			Console.WriteLine("N: "+this.n);
			for(int i=0 ; i<this.n ;i++){
				Console.Write(this.vec[i]+",");
			}
			Console.WriteLine();
		}
		// GETTERS AND SETTERS
		public int getN(){
			return this.n;
		}
		public void setN(int x){
			this.n = x;
		}
		// SOBRECARGA DE OPERADORES
		
		public static Vector operator +(Vector a, Vector b){
			// suma los elementos de 2 vectores si tienen el mismo tamaño
			Vector res = new Vector();
			res.n = a.n;
			if(a.n == b.n){
				for(int i=0 ; i<res.n ; i++){
					res.vec[i] = a.vec[i] + b.vec[i];
				}
			}
			else{
				Console.WriteLine("no se puede, tamaños distintos");
			}
			return res;
		}
		/*
		public static int operator +(Vector a, Vector b){
			// Sumar los elem de a y los elem de b
			int s1 = 0;
			for(int i=0 ; i<a.n ; i++){
				s1 = s1 + this.vec[i];
			}
			int s2 = 0;
			for(int i=0 ; i<b.n ; i++){
				s2 = s2 + b.vec[i];
			}
			int s = s1 + s2;
			return s;
		}
		*/
		
		public static Vector operator --(Vector a){
			for(int i=0 ; i<a.n ; i++){
				a.vec[i]--;
			}
			return a;
		}
		
		public static bool operator >(Vector a, Vector b){
			// Un vector es mayor que otro cuando la suma de sus elementos es mayor que otro
			int s1 = 0;
			for(int i=0; i<a.n ; i++){
				s1 = s1 + a.vec[i];
			}
			int s2 = 0;
			for(int i=0; i<b.n ; i++){
				s2 = s2 + b.vec[i];
			}
			if(s1 > s2){
				return true;
			}
			else{
				return false;
			}
		}
		
		public static bool operator <(Vector a, Vector b){
			// Un vector es menor que otro cuando la suma de sus elementos es mayor que otro
			int s1 = 0;
			for(int i=0; i<a.n ; i++){
				s1 = s1 + a.vec[i];
			}
			int s2 = 0;
			for(int i=0; i<b.n ; i++){
				s2 = s2 + b.vec[i];
			}
			if(s1 < s2){
				return true;
			}
			else{
				return false;
			}
		}
		
		public static Vector operator !(Vector a){
			for(int i=0 ; i<a.n ; i++){
				a.vec[i] = a.vec[i] * (-1);
			}
			return a;
		}
		// METODOS
		public void suma(){
			// Este suma los elementos del vector
			int s = 0;
			for(int i=0 ; i<this.n ; i++){
				s =  s + this.vec[i];
			}
			Console.WriteLine("La suma es: " + s);
		}
		public void suma(int z){
			// Suma el entero a Z a cada elemento del vector
			for(int i=0 ; i<this.n ; i++){
				this.vec[i] = this.vec[i] + z;
			}
			this.mostrarV();
		}
	}
}
