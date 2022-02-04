
import java.util.Scanner;

public class Habitante {
    // ATRIBUTOS
    protected String nom;
    protected String dir;
    protected int edad;
    // CONSTRUCTORES
    
    public Habitante(){
        this.nom = "";
        this.dir = "";
        this.edad = 0;
    }
    public Habitante(String n, String d, int e){
        this.nom = n;
        this.dir = d;
        this.edad = e;
    }
    // LEER Y MOSTRAR
    public void mostrarH(){
        System.out.println("Nombre:"+this.nom+"-Direccion: "+this.dir+"-Edad:"+this.edad);
    }
    public void leerH(){
        Scanner enter = new Scanner(System.in);
        System.out.println("Ingrese Nombre: ");
        this.nom = enter.nextLine();
        System.out.println("Ingrese Direccion: ");
        this.dir = enter.nextLine();
        System.out.println("Ingrese Edad: ");
        this.edad = enter.nextInt();
    }
    // GETTERS AND SETTERS

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getDir() {
        return dir;
    }

    public void setDir(String dir) {
        this.dir = dir;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }
    
    // METODOS
    
}
