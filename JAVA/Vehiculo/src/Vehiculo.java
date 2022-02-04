import java.util.Scanner;

public class Vehiculo {

    // Atributos o Caracterizticas
    private String placa;
    private String marca;
    private int modelo;
    private String tipo;
    private String color;
    private int nroPuertas;

    // Metodos
    public Vehiculo() {
        this.placa = "";
        this.marca = "";
        this.modelo = 0;
        this.tipo = "";
        this.color = "";
        this.nroPuertas = 0;
    }
    
    public Vehiculo(String placa, String marca, int modelo, String tipo, String color, int nroPuertas) {
        this.placa = placa;
        this.marca = marca;
        this.modelo = modelo;
        this.tipo = tipo;
        this.color = color;
        this.nroPuertas = nroPuertas;
    }

    public void leerVehiculo() {
        Scanner enter = new Scanner(System.in);

        System.out.println("PLACA: ");
        this.placa = enter.next();

        System.out.println("MARCA: ");
        this.marca = enter.next();

        System.out.println("MODELO: ");
        this.modelo = enter.nextInt();

        System.out.println("TIPO: ");
        this.tipo = enter.next();

        System.out.println("COLOR: ");
        this.color = enter.next();

        System.out.println("Numero de Puertas: ");
        this.nroPuertas = enter.nextInt();
    }

    public void mostrarVehiculo() {
        System.out.println("PLACA: " + this.placa);
        System.out.println("MARCA: " + this.marca);
        System.out.println("MODELO: " + this.modelo);
        System.out.println("TIPO: " + this.tipo);
        System.out.println("COLOR: " + this.color);
        System.out.println("NUMERO DE PUERTAS: " + this.nroPuertas);
    }

    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public int getModelo() {
        return modelo;
    }

    public void setModelo(int modelo) {
        this.modelo = modelo;
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

    public int getNroPuertas() {
        return nroPuertas;
    }

    public void setNroPuertas(int nroPuertas) {
        this.nroPuertas = nroPuertas;
    }
    public boolean verificarIguales(Vehiculo x){
        if(this.placa.equals(x.getPlaca()))
        {
            return true;
        }
        else{
            return false;
        }
    }
}
