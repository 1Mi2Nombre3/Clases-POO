
public class Principal {

    public static void main(String[] args) {
        VideoJuego a = new VideoJuego();
        a.mostrarVideoJuego();
        System.out.println("=================");
        VideoJuego b = new VideoJuego("FIFA", "FUTBOL", 12, 2004, "Internet", "1.75V");
        b.mostrarVideoJuego();
        System.out.println("");
        b.agregarJugador();
        System.out.println(b.getCanJugadores());
        b.agregarJugador(5);
        System.out.println(b.getCanJugadores());
        b.agregarJugador(b.getCanJugadores(),5);
    }
}
