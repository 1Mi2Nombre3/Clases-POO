
import java.util.Scanner;

public class Profesor extends Habitante{
    // ATRIBUTOS
    private String colegio;
    private String esp;
    
    // CONSTRUCTORES
    
    public Profesor(){
        super();
        this.colegio = "";
        this.esp = "";
    }
    public Profesor(String n, String d, int e, String c, String es){
        super(n,d,e);
        this.colegio = c;
        this.esp = es;
    }
    
    // LEER Y MOSTRAR
    
    public void mostrarP(){
        super.mostrarH();
        System.out.println("Colegio:"+this.colegio+"-Especialidad: "+this.esp);
    }
    public void leerP(){
        Scanner enter = new Scanner(System.in);
        super.leerH(); 
        System.out.println("Ingrese Colegio: ");
        this.colegio = enter.nextLine();
        System.out.println("Ingrese Especialidad: ");
        this.esp = enter.nextLine();
    }
    
    // GETTERS / SETTERS

    public String getColegio() {
        return colegio;
    }

    public void setColegio(String colegio) {
        this.colegio = colegio;
    }

    public String getEsp() {
        return esp;
    }

    public void setEsp(String esp) {
        this.esp = esp;
    }
    
    
    
}
