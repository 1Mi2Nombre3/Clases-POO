using System;
using System.Collections.Generic;
namespace FRACCIONGENERICA
	
{
	public class Fraccion<T>
	{
		private T num;
		private T den;
		
		public Fraccion(T n, T d)
		{
			this.num = n;
			this.den = d;
		}
		public void mostrar(){
			Console.WriteLine("Num:"+this.num + "-Den:"+this.den);
		}
		
		public T getNum(){
			return this.num;
		}
		public void setNum(T n){
			this.num = n;
		}

		public T getDen(){
			return this.den;
		}
		public void setDen(T d){
			this.den = d;
		}
		
		public bool compararDen(Fraccion<string> d)
		{
			if(this.getDen().Equals(d.getDen())){
				return true;
			}
			else{
				return false;
			}
		}
	}
}
