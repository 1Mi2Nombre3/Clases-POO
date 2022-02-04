
import java.util.Scanner;

public class Arbitro extends Persona{
    // ATRIBUTOS
    private int experiencia;
    
    // CONSTRUCTORES
    public Arbitro(){
        super();
        this.experiencia = 0;
    }
    public Arbitro(String n, int e, int ex){
        super(n,e);
        this.experiencia = ex;
    }
    
    // LEER Y MOSTRAR
    public void leer(){
        Scanner enter = new Scanner(System.in);
        super.leerP();
        System.out.println("Ingrese años de experiencia: ");
        this.experiencia = enter.nextInt();
    }
    public void mostrar(){
        super.mostrarP();
        System.out.println("Experiencia:"+this.experiencia);
    }
    
    // GETTERS SETTERS
    public int getExperiencia() {
        return experiencia;
    }

    public void setExperiencia(int experiencia) {
        this.experiencia = experiencia;
    }
}
