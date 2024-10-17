
public class Ejercicio01 {

	public static void main(String[] argv) {
        SimpleThread1 hilo1= new SimpleThread1("Hilos1");
        SimpleThread1 hilo2= new SimpleThread1("Hilos2");
        hilo1.start();
        hilo2.start();
    }
}

class SimpleThread1 extends Thread{
    public SimpleThread1(String nombre) {
        super(nombre);
    }

    public void run() {
        for(int p=0;p<10;p++) {
            System.out.println(p+" "+getName());
        }
        System.out.println("Fin! "+getName());
    }

}
