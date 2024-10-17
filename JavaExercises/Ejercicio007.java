class ThreadsJoin extends Thread {
	public ThreadsJoin(String nombre) {
		super();
		start();
	}
	public void run() {
		try {
			for (int i = 0; i < 4; i++) {
				System.out.println(getName() + " " + i);
				Thread.sleep(1000);
			}
			System.out.println("Fin - " + getName());
		} catch (InterruptedException e) {}
	}
}

public class Ejercicio07 {
	public static void main (String [] args) {
		System.out.println("Inicio - main");
		ThreadsJoin hilo1 = new ThreadsJoin("Hilo1");
		ThreadsJoin hilo2 = new ThreadsJoin("Hilo2");
		ThreadsJoin hilo3 = new ThreadsJoin("Hilo3");
		ThreadsJoin hilo4 = new ThreadsJoin("Hilo4");
		try {
			hilo1.join();
			hilo2.join();
			hilo3.join();
			hilo4.join();
			System.out.println("Fin - main");
		} catch (InterruptedException e) {
			
		}
		
	}
}