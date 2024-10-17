
public class Ejercicio04 {
	public static void main (String [] args) {
		SimpleThreadRunnable hilo1 = new SimpleThreadRunnable("Hilo1");
		SimpleThreadRunnable hilo2 = new SimpleThreadRunnable("Hilo2");
		Thread h1 = new Thread(hilo1);
		Thread h2 = new Thread(hilo2);
		h1.start();
		h2.start();
	}
}

class SimpleThreadRunnable implements Runnable {
	String nombre;
	public SimpleThreadRunnable(String nom) {
		this.nombre = nom;
	}
	public void run() {
		for (int i = 0; i < 10; i++) {
			System.out.println(i + " " + nombre);
		}
		System.out.println("Fin! " + nombre);
	}
}
