using System;

namespace gusanito
{
	class Program
	{
		static void mostrarM(int[,] a, int n, int m){
			int i,j;
			for(i=0 ; i<n ; i++){
				for(j=0 ; j<m ; j++){
					Console.Write(a[i,j]+" ");
				}
				Console.WriteLine("");
			}
		}
		public static void Main(string[] args)
		{
			int p,i,j,n,m;
			n = int.Parse(Console.ReadLine());
			m = int.Parse(Console.ReadLine());
			int[,] a = new int[n,m];
			p = 2;
			for(i=0 ; i<n ; i++){
				if(i%2==0){
					for(j=0; j<m ;j++){
						a[i,j] = p; p = p + 2;
					}
				}
				else{
					for(j=m-1 ; j>-1 ; j--){
						a[i,j] = p ; p = p + 2;
					}
				}
			}
			mostrarM(a,n,m);
			Console.ReadKey();
		}
	}
}