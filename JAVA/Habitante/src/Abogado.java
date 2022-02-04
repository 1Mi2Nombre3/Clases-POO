
import java.util.Scanner;

public class Abogado extends Habitante {
    // ATRIBUTOS
    private String registro;
    private String tipo;
    
   // CONSTRUCTORES
    public Abogado(){
        super();
        this.registro = "";
        this.tipo = "";
    }
    public Abogado(String n, String d, int e, String r, String t){
        super(n,d,e);
        this.registro = r;
        this.tipo = t;
    }
   // LEER Y MOSTRAR
    public void mostrarA(){
        super.mostrarH();
        System.out.println("Registro:"+this.registro + "-Tipo:" + this.tipo);
    }
    public void leerA(){
        super.leerH();
        Scanner enter = new Scanner(System.in);
        System.out.println("Ingrese Registro: ");
        this.registro = enter.nextLine();
        System.out.println("Ingrese Tipo: ");
        this.tipo = enter.nextLine();
    }
    // GETTERS / SETTERS

    public String getRegistro() {
        return registro;
    }

    public void setRegistro(String registro) {
        this.registro = registro;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    } 
}
