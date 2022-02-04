import java.util.Scanner;
public class Tv {
    
    // ATRIBUTOS
    private float precio;
    private String resolucion;
    private int garantia;
   
    // CONSTRUCTORES
   public Tv(){
       precio = 0;
       resolucion = "";
       garantia = 0;
   }
   public Tv(float p, String r, int g) {
        this.precio = p;
        this.resolucion = r;
        this.garantia = g;
    }
   
    // LEER Y MOSTRAR
   public void leerTv(){
       Scanner enter = new Scanner(System.in);
       System.out.println("Ingrese Precio: ");
       this.precio = enter.nextFloat();
       System.out.println("Ingrese Resolución");
       this.resolucion = enter.next();
       System.out.println("Ingrese Garantia en años: ");
       this.garantia = enter.nextInt();
   }
   public void mostrarTv(){
       System.out.println("Precio: "+ this.precio);
       System.out.println("Resolucion: "+ this.resolucion);
       System.out.println("Garantia: "+ this.garantia+" años");
   }
    // SETTERS AND SETTERS

    public float getPrecio() {
        return precio;
    }

    public void setPrecio(float precio) {
        this.precio = precio;
    }

    public String getResolucion() {
        return resolucion;
    }

    public void setResolucion(String resolucion) {
        this.resolucion = resolucion;
    }

    public int getGarantia() {
        return garantia;
    }

    public void setGarantia(int garantia) {
        this.garantia = garantia;
    }
    // METODOS
    
}
    

