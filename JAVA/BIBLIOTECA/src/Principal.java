public class Principal {
    public static void main(String[] args) {
        Biblioteca a = new Biblioteca();
        Biblioteca b = new Biblioteca();
        a.leerBiblioteca();
        b.leerBiblioteca();
        System.out.println("===================");
        a.mostrarBiblioteca();
        System.out.println("===================");
        b.mostrarBiblioteca();
        System.out.println("===================");
       
        int s = a.verificaLibroComun(a, b);
        System.out.println("Hay "+s+" libros comunes en: "+a.getNombre()+" y "+b.getNombre());
    }
}
