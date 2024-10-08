
class SimpleThread3 extends Thread{
    public SimpleThread3 (String nombre) {
        super(nombre);
    }

    public void run() {
        for (int i = 0; i<10; i++) {
            System.out.println(i + " " + getName());
            try {
                sleep((long)(Math.random()* 1000));
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
        System.out.println("Fin! " + getName());
    }
}

public class Ejercicio06 {

    public static void main(String[] args) {
        SimpleThread3 hilo1 = new SimpleThread3("Hilo1");
        SimpleThread3 hilo2 = new SimpleThread3("Hilo2");

        hilo1.start();
        hilo2.start();
    }

}