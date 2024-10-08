
public class Ejercicio05 {
	public static void main(String[] args) {
		SimpleThread2 hilo1 = new SimpleThread2("Hilo1");
		SimpleThread2 hilo2 = new SimpleThread2("Hilo2");
		hilo1.start();
		hilo2.start();
	}
}

class SimpleThread2 extends Thread {
	public SimpleThread2(String nombre) {
		super(nombre);
	}
	public void run() {
		for (int i = 0; i < 10; i++) {
			System.out.println(i + " " + getName());
		}
		System.out.println("Fin! " + getName());
	}
}