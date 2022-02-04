public class Principal {
    public static void main(String[] args) {
        // Vehiculo x
        /*
        Vehiculo x;
        x = new Vehiculo();
        x.leerVehiculo();
         System.out.println("=============================");
        x.mostrarVehiculo();
        System.out.println("=============================");
        
        // Vehiculo y
        Vehiculo y = new Vehiculo();
        y.mostrarVehiculo();
        System.out.println("=============================");
        //Vehculo a1
        Vehiculo a1 = new Vehiculo("abc123","susuki",2005,"camioneta","negro",2);
        a1.mostrarVehiculo();
        System.out.println("=============================");
        
        System.out.println(a1.getColor());
        */
        //COMPARAR SI 2 VEHICULOS SON IGUALES
        
        Vehiculo v1 = new Vehiculo("abc123","susuki",2005,"camioneta","negro",2);
        Vehiculo v2 = new Vehiculo("abc123","susukis",2000,"camionetas","negros",12);
        
        if(v1.verificarIguales(v2)){
            System.out.println("IGUALES");
        }
        else{
            System.out.println("DISTINTOS");
        }
    }
}
