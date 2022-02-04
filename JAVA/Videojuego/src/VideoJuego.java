
import java.util.Scanner;

public class VideoJuego {
    // ATRIBUTOS
    private String nom;
    private String tipo;
    private int canJugadores;
    private int lanzamiento;
    private String conexion;
    private String version;
    
    // CONSTRUCTORES
    
    public  VideoJuego(){
        this.nom = "";
        this.tipo = "";
        this.canJugadores = 0;
        this.lanzamiento = 0;
        this.conexion = "";
        this.version = "";
    }
    public VideoJuego(String n, String t, int cj , int l ,String c, String v){
        this.nom = n;
        this.tipo = t;
        this.canJugadores = cj;
        this.lanzamiento = l;
        this.conexion = c;
        this.version = v;
    }
    // LEER Y MOSTRAR
    
    public void leerVideoJuego(){
        Scanner enter = new Scanner(System.in);
        
        System.out.println("Ingrese Nombre: ");
        this.nom = enter.next();
        System.out.println("Ingrese Tipo: ");
        this.tipo = enter.next();
        System.out.println("Ingrese cant de jugadores: ");
        this.canJugadores = enter.nextInt();
        System.out.println("Lanzamiento: ");
        this.lanzamiento = enter.nextInt();
        System.out.println("Ingrese conexion: ");
        this.conexion = enter.next();
        System.out.println("Ingrese version: ");
        this.version = enter.next();
    }
    public void mostrarVideoJuego(){
        System.out.println("Nombre: " + this.nom);
        System.out.println("Tipo: " + this.tipo);
        System.out.println("Cant de jugadores: " + this.canJugadores);
        System.out.println("Lazamiento: " + this.lanzamiento);
        System.out.println("Conexion: " + this.conexion);
        System.out.println("Versión: " + this.version);
    }
    
    // GETTERS AND SETTERS
    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public int getCanJugadores() {
        return canJugadores;
    }

    public void setCanJugadores(int canJugadores) {
        this.canJugadores = canJugadores;
    }

    public int getLanzamiento() {
        return lanzamiento;
    }

    public void setLanzamiento(int lanzamiento) {
        this.lanzamiento = lanzamiento;
    }

    public String getConexion() {
        return conexion;
    }

    public void setConexion(String conexion) {
        this.conexion = conexion;
    }

    public String getVersion() {
        return version;
    }

    public void setVersion(String version) {
        this.version = version;
    }
    
    // METODOS
    public void agregarJugador(){
        this.canJugadores = this.canJugadores + 1;
    }
    public void agregarJugador(int x){
        this.canJugadores = this.canJugadores + x;
    }
    public void agregarJugador(int x, int y){
        this.canJugadores = this.canJugadores + x + y;
    }
}
