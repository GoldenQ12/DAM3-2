package packageJavaPSP;

public class Ejercicio11 {
	public static void main ( String[] args ) {
		SimpleThread thread1 = new SimpleThread("pares");
		SimpleThread thread2 = new SimpleThread("impares");
		SimpleThread thread3 = new SimpleThread("numeros");
		thread1.start();
		thread2.start();
		thread3.start();
	}
}

class SimpleThread extends Thread {
	public SimpleThread ( String nombre) {
		super(nombre);
	}
	
	public void run() {
		if (getName().equals("pares")) {
			//Pares
			int resultado = 0;
			for (int i= 0; i < 1000; i++) {

				if ( i % 2 == 0) {
					System.out.println(i + "");
					resultado+=i;
				}
			}
			System.out.println(resultado + "");
		}

		if (getName().equals("impares")) {
			int resultado = 0;
			for (int i= 0; i < 1000; i++) {

				if ( i % 2 != 0) {
					System.out.println(i + "");
					resultado+=i;
				}
			}
			System.out.println(resultado + "");
			//Impares
		}
		if (getName().equals("numeros")) {
			//numeros
			int resultado = 0;
			for (int i= 0; i < 1000; i++) {

				if ( i % 10 == 2 || i % 10 == 3) {
					System.out.println(i + "");
					resultado+=i;
				}
			}
			System.out.println(resultado + "");
		}
	}
}