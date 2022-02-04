
import java.util.Scanner;

public class Jugador extends Persona {
    // ATRIBUTOS
    private String posicion;
    
    // CONSTRUCTORES
    public Jugador(){
        super();
        this.posicion = "";
    }
    public Jugador(String n, int e, String p){
        super(n,e);
        this.posicion = p;
    }
    
    // LEER Y MOSTRAR
    public void leer(){
        Scanner enter = new Scanner(System.in);
        super.leerP();
        System.out.println("Ingrese la posición: ");
        this.posicion = enter.nextLine();
    }
    public void mostrar(){
        super.mostrarP();
        System.out.println("Posición:"+this.posicion);
    }
    
    // GETTERS SETTERS
    public String getPosicion() {
        return posicion;
    }
    public void setPosicion(String posicion) {
        this.posicion = posicion;
    }
    
}
