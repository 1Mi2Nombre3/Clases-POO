
import java.util.Scanner;

public class Biblioteca {
    Scanner enter = new Scanner(System.in);
    // ATRIBUTOS
    private String nombre;
    private String direccion;
    private int cantidadLibros;
    private String[] libro = new String [100];
    private String[] autor = new String[100];
    private String[] genero = new String[100];
   
    // CONSTRUCTORES
    public Biblioteca(){
        this.nombre = "";
        this.direccion = "";
        this.cantidadLibros = 0;
    }
    public Biblioteca(String nom){
        this.nombre = nom;
        this.direccion = "";
        this.cantidadLibros = 0;
    }
    public Biblioteca(String nom, String dir){
        this.nombre = nom;
        this.direccion = dir;
        this.cantidadLibros = 0;
    }
    public Biblioteca(String nom, String dir, int cl){
        this.nombre = nom;
        this.direccion = dir;
        this.cantidadLibros = cl;
        for (int i=0 ; i<cl ; i++){
            System.out.println("==LIBRO: "+(i+1)+"==");
            System.out.println("Ingrese nombre: ");
            this.libro[i] = enter.next();
            System.out.println("Autor del libro: ");
            this.autor[i] = enter.next();
            System.out.println("Genero del libro: ");
            this.genero[i] = enter.next();
        }
    }
    // LEER Y MOSTRAR
    public void leerBiblioteca(){
        System.out.println("Ingrese el nombre de la biblioteca: ");
        this.nombre = enter.next();
        System.out.println("Ingrese la direccion: ");
        this.direccion = enter.next();
        System.out.println("Ingrese la cantidad de libros: ");
        this.cantidadLibros = enter.nextInt();
        for (int i=0 ; i<this.cantidadLibros ; i++){
            System.out.println("==LIBRO: "+(i+1)+"==");
            System.out.println("Ingrese nombre: ");
            this.libro[i] = enter.next();
            System.out.println("Autor del libro: ");
            this.autor[i] = enter.next();
            System.out.println("Genero del libro: ");
            this.genero[i] = enter.next();
        }
    }
    public void mostrarBiblioteca(){
        System.out.println("BIBLIOTECA: "+this.nombre);
        System.out.println("Direccion: "+this.direccion);
        System.out.println("Cantidad de libros: " + this.cantidadLibros);
        for (int i=0 ; i<this.cantidadLibros ; i++){
            System.out.println("==LIBRO: "+(i+1)+"==");
            System.out.println("Nombre: " + this.libro[i]);
            System.out.println("Autor: " + this.autor[i]);
            System.out.println("Genero: " + this.genero[i]);
        }
    }
    
    public void mostrarLibros(){
        for(int i=0 ; i<this.cantidadLibros ; i++){
            System.out.println("Libro:"+(i+1)+". "+this.libro[i]);
        }
    }
    
    // GETTERS / SETTERS

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public int getCantidadLibros() {
        return cantidadLibros;
    }

    public void setCantidadLibros(int cantidadLibros) {
        this.cantidadLibros = cantidadLibros;
    }

    public String[] getLibro() {
        return libro;
    }

    public void setLibro(String[] libro) {
        this.libro = libro;
    }

    public String[] getAutor() {
        return autor;
    }

    public void setAutor(String[] autor) {
        this.autor = autor;
    }

    public String[] getGenero() {
        return genero;
    }

    public void setGenero(String[] genero) {
        this.genero = genero;
    }
    
    // METODOS
    public void buscarLibro(){
        System.out.println("Ingrese el nombre del libro a buscar: ");
        String bl = enter.next();
        System.out.println("De la Blioteca: "+this.nombre);
        for(int i=0 ; i<this.cantidadLibros ; i++){
            if(bl.equalsIgnoreCase(this.libro[i]))
            {
                System.out.println("°LibroNro:"+ (i+1)+" °Nombre:" + this.libro[i] +" °Autor:" + this.autor[i] +" °Genero:"+ this.genero[i]);
            }
        }
    }
    public void buscarLibro(String libro){
        System.out.println("De la Blioteca: "+this.nombre);
        for(int i=0 ; i<this.cantidadLibros ; i++){
            if(libro.equalsIgnoreCase(this.libro[i]))
            {
                System.out.println("°LibroNro:"+ (i+1)+" °Nombre:" + this.libro[i] +" °Autor:" + this.autor[i] +" °Genero:"+ this.genero[i]);
            }
        }
    }
    
    // Error al tener 3 mismos (buscarLibro) con 1 solo argumento y ser void
    // Reemplazado por (buscarAutor)
    // Reemplazado por (buscarGenero)
    
    /*
    public void buscarLibro(String autor){
        System.out.println("De la Blioteca: "+this.nombre);
        for(int i=0 ; i<this.cantidadLibros ; i++){
            if(autor.equalsIgnoreCase(this.autor[i])){
                System.out.println("°LibroNro:"+ (i+1)+" °Nombre:" + this.libro[i] +" °Autor:" + this.autor[i] +" °Genero:"+ this.genero[i]);
            }
        }
    }
    */
    
    public void buscarAutor(String autor){
        System.out.println("De la Blioteca: "+this.nombre);
        for(int i=0 ; i<this.cantidadLibros ; i++){
            if(autor.equalsIgnoreCase(this.autor[i])){
                System.out.println("°LibroNro:"+ (i+1)+" °Nombre:" + this.libro[i] +" °Autor:" + this.autor[i] +" °Genero:"+ this.genero[i]);
            }
        }
    }
    
    public void buscarGenero(String genero){
        System.out.println("De la Blioteca: "+this.nombre);
        for(int i=0 ; i<this.cantidadLibros ; i++){
            if(genero.equalsIgnoreCase(this.genero[i])){
                System.out.println("°LibroNro:"+ (i+1)+" °Nombre:" + this.libro[i] +" °Autor:" + this.autor[i] +" °Genero:"+ this.genero[i]);
            }
        }
    }
    public int cantidadLibros(Biblioteca a, Biblioteca b, String autor){
        int s = 0;
        for(int i=0 ; i<a.cantidadLibros; i++){
            if(autor.equalsIgnoreCase(a.autor[i])){
                System.out.println("Biblioteca 1: "+ "°LibroNro:"+ (i+1)+" °Nombre:" + a.libro[i] +" °Autor:" + a.autor[i] +" °Genero:"+ a.genero[i]);
                s++;
            }
        }
        for(int i=0 ; i<b.cantidadLibros; i++){
            if(autor.equalsIgnoreCase(b.autor[i])){
                System.out.println("Biblioteca 2: "+ "°LibroNro:"+ (i+1)+" °Nombre:" + b.libro[i] +" °Autor:" + b.autor[i] +" °Genero:"+ b.genero[i]);
                s++;
            }
        }
        return s;
    }
    public int verificaLibroComun(Biblioteca a, Biblioteca b){
        int s = 0;
        if(a.cantidadLibros >= b.cantidadLibros){
            for(int i=0 ; i<a.cantidadLibros ; i++){
                for(int j=0 ; j<b.cantidadLibros ; j++){
                    if(a.libro[i].equalsIgnoreCase(b.libro[j])){
                        System.out.println(b.libro[j]);
                        s++;
                        break;
                    }
                }
            }
        }
        else{
             for(int i=0 ; i<b.cantidadLibros ; i++){
                for(int j=0 ; j<a.cantidadLibros ; j++){
                    if(b.libro[i].equalsIgnoreCase(a.libro[j])){
                        System.out.println(a.libro[j]);
                        s++;
                        break;
                    }
                }
            }
        }
        return s;
    }
}
