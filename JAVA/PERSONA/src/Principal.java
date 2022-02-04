
import java.util.Scanner;

public class Principal {
    public static void main(String[] args) {
        Scanner enter = new Scanner(System.in);
        System.out.println("Ingrese cantidad de jugadores: ");
        int n = enter.nextInt();
        Jugador [] j1 = new Jugador[n];
        for(int i=0 ; i<n ; i++){
            System.out.println("=== Jugador: "+ (i+1)+" =====");
            Jugador aux = new Jugador();
            aux.leer();
            j1[i] = aux;
        }
        for(int i=0 ; i<n ; i++){
            if(j1[i].getPosicion().equalsIgnoreCase("Arquero")){
                System.out.println("=== Jugador: "+ (i+1)+" =====");
                j1[i].mostrar();
            }
        }
    }
}
