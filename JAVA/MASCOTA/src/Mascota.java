
import java.util.Scanner;

public class Mascota {
    // ATRIBUTOS
    private String nom;
    private String raza;
    private String tipo;
    private String color;
    private int edad;
    
    // CONSTRUCTORES
    
    public Mascota(){
        this.nom = "";
        this.raza = "";
        this.tipo = "";
        this.color = "";
        this.edad = 0;
        
    }
    public Mascota(String n, String r, String t, String c, int e){
        this.nom = n;
        this.raza = r;
        this.tipo = t;
        this.color = c;
        this.edad = e;
    }
    // GETTERS AND SETTERS

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getRaza() {
        return raza;
    }

    public void setRaza(String raza) {
        this.raza = raza;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }
    
    // METODOS
    public void leerMascota(){
        Scanner enter = new Scanner(System.in);
        
        System.out.println("NOMBRE: ");
        this.nom = enter.next();
        System.out.println("RAZA: ");
        this.raza = enter.next();
        System.out.println("TIPO: ");
        this.tipo = enter.next();
        System.out.println("COLOR: ");
        this.color = enter.next();
        System.out.println("EDAD: ");
        this.edad = enter.nextInt();
    }
    
    public void mostrarMascota(){
        System.out.println("Nombre: "+this.nom);
        System.out.println("Raza: "+this.raza);
        System.out.println("Tipo: "+this.tipo);
        System.out.println("Color: "+this.color);
        System.out.println("Edad: "+this.edad);
    }
    
    public int verificarTipo(String x){
        int resp;
        if(x.equalsIgnoreCase(this.tipo) == true){
            resp = 1;
        }
        else{
            resp = 0;
        }
        return resp;
    }
    
    public void verificarAtributo(String a, String b){
        if(a.equals(b)){
            System.out.println("Son iguales");
            System.out.println(a);
            System.out.println(b);
        }
        else{
            System.out.println("Son distintos");
            System.out.println(a);
            System.out.println(b);
        }
    } 
    
    public boolean verificarIguales(Mascota m){
        if((this.nom.equals(m.nom)) && (this.raza.equals(m.raza)) && (this.tipo.equals(m.tipo)) && (this.color.equals(m.color)) && (this.edad == m.edad))
            return true;
        else{
            return false;
        }
    }
    
}
