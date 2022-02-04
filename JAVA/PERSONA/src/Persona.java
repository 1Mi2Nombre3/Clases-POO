
import java.util.Scanner;

public class Persona {
    // ATRIBUTOS
    protected String nom;
    protected int edad;
    
    // CONSTRUCTORES
    public Persona(){
        this.nom = "";
        this.edad = 0;
    }
    public Persona(String n, int e){
        this.nom = n;
        this.edad = e;
    }
    
    // LEER Y MOSTRAR
    public void leerP(){
        Scanner enter = new Scanner(System.in);
        System.out.println("Ingerse nombre: ");
        this.nom = enter.nextLine();
        System.out.println("Ingrese edad: ");
        this.edad = enter.nextInt();
    }
    public void mostrarP(){
        System.out.println("Nom:"+this.nom+"-Edad:"+this.edad);
    }
    // GETTERS SETTERS
    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }
    
    // METODOS
    public void comparar(Arbitro x){
        if(this.edad > x.getEdad()){
            System.out.println("El mas joven es el arbitro");
            this.mostrarP();
        }
        else{
            if(this.edad < x.getEdad()){
                System.out.println("El mas joven es el jugador");
                this.mostrarP();
            }
            else{
                System.out.println("Son de la msima edad");
            }
        }
    }
    
}
