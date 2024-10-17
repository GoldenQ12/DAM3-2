
public class Ejercicio08 {

	public static void main (String [] args) {
		Contador cont = new Contador();
		ContadorHilo hilo1 = new ContadorHilo("Hilo1", cont);
		ContadorHilo hilo2 = new ContadorHilo("Hilo2", cont);
		ContadorHilo hilo3 = new ContadorHilo("Hilo3", cont);
		ContadorHilo hilo4 = new ContadorHilo("Hilo4", cont);
		
		hilo1.start();
		hilo2.start();
		hilo3.start();
		hilo4.start();
		
		try {
			hilo1.join();
			hilo2.join();
			hilo3.join();
			hilo4.join();
		} catch (InterruptedException e) {
			System.out.println("Interrupcion del hilo...");
		}
		System.out.println("Terminamos el programa...");
	}
}

class Contador {
	protected int contador = 0;
	
	public int getContador() {
		return this.contador;
	}
	
	public void setContador(int valor) {
		this.contador = valor;
	}
}

class ContadorHilo extends Thread {
	Contador cont;
	ContadorHilo(String p_nombre, Contador p_cont) {
		super (p_nombre);
		this.cont = p_cont;
	}
	public void run() {
		for (int i = 0; i < 3; i++) {
			try {
				int a = cont.getContador();
				sleep((long)(Math.random() * 10));
				cont.setContador(a + 1);
				System.out.println(getName() + " - contador: " + cont.getContador());
				sleep((long)(Math.random() * 10));
			} catch (InterruptedException e) {
				System.out.println("Interrupcion del hilo...");
			}
			System.out.println("Fin " + getName() + "...");
		}
	}
}















