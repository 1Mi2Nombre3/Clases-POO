
import java.util.Scanner;

public class Principal {
    public static void main(String[] args) {
        /*
        System.out.println("===============");
        Mascota a = new Mascota("Pelusa","Esfinge","Gato","Cafe",4);
        Mascota b = new Mascota("Pelusa","Esfinge","Gato","Cafe",4);
        a.mostrarMascota();
        System.out.println("======================");
        b.mostrarMascota();
        
        System.out.println("======VERIFICAR RAZAS========");
        
        int res = a.verificarTipo(b.getTipo());
        if (res == 1){
            System.out.println("Son iguales");
        }
        else{
            System.out.println("Son distintos");
        }
        
        System.out.println("=======VERIFICAR NOMBRES========");
        
        Mascota c = new Mascota();
        c.verificarAtributo(a.getNom(), b.getNom());
        
        System.out.println("=======VERIFICAR EDADES========");
        
        verificarEdad(a,b);
        
        System.out.println("======VERIFICAR MASCOTAS IGUALES=======");
        
        if(a.verificarIguales(b)==true)
            System.out.println("Son Mascotas Iguales");
        else
            System.out.println("Son Mascotas distintas");
            
        */
        Scanner enter = new Scanner(System.in);
        System.out.println("=======Tamaño del vector==========");
        int n = enter.nextInt();
        Mascota a[ ] = new Mascota [n];
        System.out.println("====Leyendo elem del vector mascota====");
        leerVectorM(a,n);
        mostrarVectorM(a,n);
        ordenasVectorM(a,n);
        mostrarVectorM(a,n);
    }

    
    // PROCEDIMIENTOS O METODOS INTERNOS
    
    private static void verificarEdad(Mascota a, Mascota b) {
        if(a.getEdad()==b.getEdad())
            System.out.println("Edades iguales: "+ a.getEdad() +" "+ b.getEdad());
        else
            System.out.println("Edades desiguales: "+ a.getEdad() +" "+ b.getEdad());
    }

    private static void leerVectorM(Mascota[] a, int n) {
        for(int i=0 ; i<n ; i++){
            System.out.println("==========MASCOTA: " + (i + 1)+" ==============");
            Mascota aux = new Mascota();
            aux.leerMascota();
            a[i] = aux;
        }
    }

    private static void mostrarVectorM(Mascota[] a, int n) {
        for(int i=0 ; i<n ; i++){
            System.out.println("==========MASCOTA: " + (i + 1)+" ==============");
            a[i].mostrarMascota();
        }
    }

    private static void ordenasVectorM(Mascota[] a, int n) {
        System.out.println("=======ORDEN DE MASCOTAS POR EDAD=======");
        Mascota aux = new Mascota();
        for(int i=0 ; i<n-1 ; i++)
            for(int j=i+1 ; j<n ; j++){
                if(a[i].getEdad() > a[j].getEdad()){
                    aux = a[i];
                    a[i] = a[j];
                    a[j] = aux;
                }
        }
    }
}